using ERP_mobile_peristalsis.chatting;
using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
//채팅치는 칸의 컨트롤로 chatting log 출력을 위해 chatting name칼럼에서 다양한 정보를 받아와 저장한다
//쓰레드를 활용해서 채팅을 계속 읽어와 초기화시켜주는 작업을 진행한다.
namespace ERP_mobile_peristalsis
{
    
    delegate void threadDelegate_1();
    public partial class typing_pannel : UserControl
    {
        public Thread thread_check_new;
        string chatting_room_name;
        int width;// 채팅 로그를 받아오기 위해 chatting_name_pannel 에서 받아오는 width 값
        int last = 0;
        public void renew_thread()// 채티을 실시간으로 불러와서 업데이트해주는 쓰레드에
        {
            while (Main.form_switch[2])
            {
                Thread.Sleep(100);
                if(Main.Chatting_form.loadfinished==true && Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log!=null)
                this.Invoke(new threadDelegate_1(real_func)) ;
            }
        }
        public void real_func()
        {
            
            int num = 0;
            Query query = new Query().Select("max(Key_num)").From("Personal_Chatting_Log").Where("Title='" + Main.Chatting_form.chatting_room_name + "'");
            //+"and Key_num >" + Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Last().last_chat_num.ToString()
            DataTable dt = DB_Manager.getInstance().select(query.query);
            foreach (DataRow row in dt.Rows)
            {
                if(!DBNull.Value.Equals(row["max(Key_num)"])&& Convert.ToInt32(row["max(Key_num)"])>last)
                num = Convert.ToInt32(row["max(Key_num)"]);
            } 
            if (num!=0)
            {
                //if(Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Any())
                if ((Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Last().last_chat_num < num && Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.First().last_chat_num < num))
                {
                    Query new_chatting_log = new Query().Select("*").From("Personal_Chatting_Log").Where("Title='" + Main.Chatting_form.chatting_room_name + "' and Key_num > " + Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Last().last_chat_num);
                    string a = new_chatting_log.query;
                    DataTable dt_chatting_log = DB_Manager.getInstance().select(new_chatting_log.query + "order by Datetime desc");
                    foreach (DataRow row in dt_chatting_log.Rows)
                    {
                        if ((!string.Equals(row["Writter"].ToString(), Config_Manager.GetInstance().userid) )&& Convert.ToInt32( row["Key_num"])> Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Last().last_chat_num&& Convert.ToInt32(row["Key_num"]) > Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.First().last_chat_num)
                        {
                            int aa = Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Last().last_chat_num;
                                int k = aa;
                            int bb = Convert.ToInt32(row["Key_num"]);
                                int kk = bb;
                            chatting_log_column new_chat_log = new chatting_log_column(false, this.Width, row["Log"].ToString(), row["Log"].ToString(), Convert.ToInt32(row["Key_num"]));
                            Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Add(new_chat_log);//채팅이 추가되었음으로 채팅로그를 추가해준다.
                            Main.Chatting_form.log.Controls.Add(new_chat_log);
                            new_chat_log.BorderStyle = BorderStyle.FixedSingle;
                            Main.Chatting_form.chatting_log_count++;//채팅 갯수를 세어주는 카운터
                            new_chat_log.Dock = DockStyle.Bottom;
                            Main.Chatting_form.log.Controls.SetChildIndex(new_chat_log, Main.Chatting_form.chatting_log_count);
                            last =Convert.ToInt32(row["Key_num"]);
                        }
                    }
                }
            }
        }
        public typing_pannel(string chatting_room_name,int width)
        {
            InitializeComponent();
            Main.Chatting_form.typing_pannel = this;
            this.chatting_room_name = chatting_room_name;
            this.width = width;
            thread_check_new = new Thread(renew_thread);
            thread_check_new.Start();
        }

        private void enter_button1_Click(object sender, EventArgs e)
        {
            if (!string.Equals(chatting_textBox1.Text,""))
            {
                chatting_textBox1.Text.Replace("Environment.NewLine", "");
                string query = "insert into Personal_Chatting_Log values('" + Config_Manager.GetInstance().userid + "','" + chatting_textBox1.Text + "', null,'" + Main.Chatting_form.chatting_room_name + "',now());";
                //엔터 입력을 받았을 때
                DB_Manager.getInstance().insert(query);
                chatting_log_column new_chat_log = new chatting_log_column(width, chatting_textBox1.Text, chatting_room_name);
                Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Add(new_chat_log);//채팅이 추가되었음으로 채팅로그를 추가해준다.
                Main.Chatting_form.log.Controls.Add(new_chat_log);
                new_chat_log.BorderStyle = BorderStyle.FixedSingle;
                Main.Chatting_form.chatting_log_count++;
                new_chat_log.Dock = DockStyle.Bottom;
                Main.Chatting_form.log.Controls.SetChildIndex(new_chat_log, Main.Chatting_form.chatting_log_count);
                //num 받아오기 설정
                new_chat_log.last_chat_num = DB_Manager.getInstance().chat_num(chatting_room_name, chatting_textBox1.Text);
                chatting_textBox1.Text = "";
            }
        }

        private void chatting_textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chatting_textBox1.Text != Environment.NewLine)
                {
                    chatting_textBox1.Text.Replace("Environment.NewLine", "");
                    string query = "insert into Personal_Chatting_Log values('" + Config_Manager.GetInstance().userid + "','" + chatting_textBox1.Text + "', null,'" + Main.Chatting_form.chatting_room_name + "',now());";
                    //엔터 입력을 받았을 때
                    DB_Manager.getInstance().insert(query);
                    chatting_log_column new_chat_log = new chatting_log_column(width, chatting_textBox1.Text, chatting_room_name);
                    Main.Chatting_form.clicked_chatting_name_panel.collect_chatting_log.Add(new_chat_log);//채팅이 추가되었음으로 채팅로그를 추가해준다.
                    Main.Chatting_form.log.Controls.Add(new_chat_log);
                    new_chat_log.BorderStyle  = BorderStyle.FixedSingle;
                    Main.Chatting_form.chatting_log_count++;//채팅 갯수를 세어주는 카운터
                    new_chat_log.Dock = DockStyle.Bottom;
                    Main.Chatting_form.log.Controls.SetChildIndex(new_chat_log, Main.Chatting_form.chatting_log_count);
                    new_chat_log.last_chat_num = DB_Manager.getInstance().chat_num(chatting_room_name, chatting_textBox1.Text);
                    chatting_textBox1.Text = "";
                }
                chatting_textBox1.Text = "";
            }
        }
    }
}
