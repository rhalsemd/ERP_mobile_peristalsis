using ERP_mobile_peristalsis.chatting;
using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//채팅치는 칸의 컨트롤로 chatting log 출력을 위해 chatting name칼럼에서 다양한 정보를 받아와 저장한다
namespace ERP_mobile_peristalsis
{
    public partial class typing_pannel : UserControl
    {
        string chatting_room_name;
        int width;// 채팅 로그를 받아오기 위해 chatting_name_pannel 에서 받아오는 width 값
        
        public typing_pannel(string chatting_room_name,int width)
        {
            InitializeComponent();
            this.chatting_room_name = chatting_room_name;
            this.width = width;
        }
        
        private void enter_button1_Click(object sender, EventArgs e)
        {
            chatting_textBox1.Text.Replace("Environment.NewLine", "");
            string query = "insert into Personal_Chatting_Log values('" + Config_Manager.GetInstance().userid + "','" + chatting_textBox1.Text + "', null,'" + Main.Chatting_form.chatting_room_name + "',now());";
            //엔터 입력을 받았을 때
            DB_Manager.getInstance().insert(query);
            chatting_log_column new_chat_log = new chatting_log_column(width, chatting_textBox1.Text);
            Main.Chatting_form.log.Controls.Add(new_chat_log);
            new_chat_log.BorderStyle = BorderStyle.FixedSingle;
            Main.Chatting_form.chatting_log_count++;
            new_chat_log.Dock = DockStyle.Bottom;
            Main.Chatting_form.log.Controls.SetChildIndex(new_chat_log, Main.Chatting_form.chatting_log_count);

            chatting_textBox1.Text = "";
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
                    chatting_log_column new_chat_log = new chatting_log_column(width, chatting_textBox1.Text);
                    Main.Chatting_form.log.Controls.Add(new_chat_log);
                    new_chat_log.BorderStyle  = BorderStyle.FixedSingle;
                    Main.Chatting_form.chatting_log_count++;
                    new_chat_log.Dock = DockStyle.Bottom;
                    Main.Chatting_form.log.Controls.SetChildIndex(new_chat_log, Main.Chatting_form.chatting_log_count);

                    chatting_textBox1.Text = "";
                }
                chatting_textBox1.Text = "";
            }
        }
    }
}
