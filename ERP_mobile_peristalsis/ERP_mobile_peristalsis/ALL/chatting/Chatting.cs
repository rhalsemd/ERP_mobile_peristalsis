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

namespace ERP_mobile_peristalsis
{
    public partial class Chatting : Form
    {
        public List<chatting_log_column> chatting_log_column_list = new List<chatting_log_column>();
        public chatting_log_pannel log;// 채팅로그가 올라가는 패널 현재 화면에 띄워진 패널을 여기에 저장하여  typing_pannel에서 불러와 사용
        Button button_add_chatting = new Button();
        public Label partner_name = new Label();
        public int closed = 0; //창 초기화를 위해 꺼진적이 있는지 체크
        public int clicked = -1; // 클릭한 채팅방 확인용
        public int check_chatting_log = 0;
        public int check_chatting_log_panel = 0;
        int count;
        public string chatting_room_name; // 현재 클릭되어 보여지고 있는 채팅방 이름
        public chatting_name_pannel[] newpanel_class;
        public SplitContainer splitcontainer;
        public int chatting_log_count;
        public Chatting()
        {
            InitializeComponent();
            button_add_chatting.Click += button_add_chatting_click;
        }
        public void button_add_chatting_click(object sender, EventArgs e)
        {
            Add_Chatting_Panel panel_add_chatting = new Add_Chatting_Panel();
            panel_add_chatting.ShowDialog() ;
        }

        private void Chatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.form_switch[2] = false;
            this.Hide();
            e.Cancel = true;
            splitcontainer = null;
            closed++;
            for(int i = 0; i < count; i++)
            {
            }
        }
        
        public void init()
        {
            int chatting_namming_count = 0;
            check_chatting_log = 0;
            check_chatting_log_panel = 0;
            splitcontainer = null;
            splitcontainer = new SplitContainer();
            splitcontainer.Dock = DockStyle.Fill;

            Main.Chatting_form.Controls.Add(splitcontainer);

            
            splitcontainer.Panel2.BackColor = Color.White;
            splitcontainer.Panel1.BackColor = Color.White;
            Query query_count = new Query().Select("count(*)").From("Personal_Chat_Meta").Where("User1 = '" + Config_Manager.GetInstance().userid + "' or User2 = '" + Config_Manager.GetInstance().userid + "'");
            count = DB_Manager.getInstance().count_call(query_count);//채팅방 갯수를 세어주는 카운트

            Query query = new Query().Select("Title").From("Personal_Chat_Meta").Where("User1 = '" + Config_Manager.GetInstance().userid + "' or User2 = '" + Config_Manager.GetInstance().userid + "'");
            DataTable dt_chatting =  DB_Manager.getInstance().select(query.query);


            newpanel_class = null;
            newpanel_class = new chatting_name_pannel[count];

            foreach (DataRow row in dt_chatting.Rows)//채팅이름 폼에 정보를 저장하는 반복문 이미지 저장도 같이한다.
            {
                newpanel_class[chatting_namming_count] = new chatting_name_pannel();
                newpanel_class[chatting_namming_count].number = chatting_namming_count;
                newpanel_class[chatting_namming_count].chatting_room_name = row["Title"].ToString();
                //newpanel_class[chatting_namming_count].set_chatting_profile_image();
                newpanel_class[chatting_namming_count++].set_chatting_name_label_text();
            }
            //채팅이름 창을 띄워주는 반복문
            if (check_chatting_log == 0)
                for (int i = 0; i < count; i++)
                {
                    check_chatting_log++;
                    newpanel_class[i].Size = new Size(splitcontainer.Panel1.Width, 45);
                    // newpanel_class[i].Location = new Point(0, 45 * i);
                    newpanel_class[i].BackColor = Color.White;
                    newpanel_class[i].Dock = DockStyle.Top;
                    splitcontainer.Panel1.Controls.Add(newpanel_class[i]);
                }
            else
            {
                for (int i = 0; i < count; i++)
                    newpanel_class[i].Size = new Size(splitcontainer.Panel1.Width, 45 * i);
            }
            
            //panel2 의 채팅 상대 이름 출력하는 코드
            Main.Chatting_form.partner_name.AutoSize = false;
            Main.Chatting_form.partner_name.TextAlign = ContentAlignment.MiddleCenter;

            Main.Chatting_form.splitcontainer.Panel2.Controls.Add(Main.Chatting_form.partner_name);
            Main.Chatting_form.partner_name.Dock = DockStyle.Top;

            //새채팅 생성하는 버튼 생성하는 코드
            button_add_chatting.Text = "새 채팅";
            splitcontainer.Panel1.Controls.Add(button_add_chatting);
            //splitcontainer.Panel1.Controls.SetChildIndex(button_add_chatting, 0);
            button_add_chatting.Dock = DockStyle.Top;

        }
        
    }
}
