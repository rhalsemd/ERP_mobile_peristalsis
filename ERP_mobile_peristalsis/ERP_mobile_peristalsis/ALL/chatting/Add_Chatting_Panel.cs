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
//새 채팅을 만들기 위해서 사용하는 패널( 새창 띄워준다)
namespace ERP_mobile_peristalsis.chatting
{
    public partial class Add_Chatting_Panel : Form
    {
        Label[] add_chatting_label;
        public Add_Chatting_Panel()
        {
            InitializeComponent();
            init();
            this.Size = new Size(200, 200);
        }
        int Count_User;
        public void init()
        {
            Query query_user_count = new Query().Select("count(*)").From("User");
            Count_User = DB_Manager.getInstance().count_call(query_user_count);
            add_chatting_label = new Label[Count_User];

            Query query_get_user = new Query().Select("ID,Name").From("User");
            DataTable dt_user_list = DB_Manager.getInstance().select(query_get_user.query);

            foreach (DataRow row in dt_user_list.Rows)
            {
                bool check = false;// 채팅방이 구현되어있는지 확인
                for (int i = 0; i < Main.Chatting_form.count; i++)
                {
                    if (Main.Chatting_form.newpanel_class[i].chatting_room_label.Text == row["Name"].ToString() || Config_Manager.GetInstance().userName == row["Name"].ToString())
                        check = true;
                }
                if (check != true)//채팅방이 없다면
                    add_column(row);
            }
        }
        void add_column(DataRow row)
        {
            Label label_User_name = new Label();
            label_User_name.Text = row["Name"].ToString();
            label_User_name.BackColor = Color.White;
            this.Controls.Add(label_User_name);
            label_User_name.Dock = DockStyle.Top;
            label_User_name.Click += new EventHandler(add_chatting_form_click);
        }

        public void add_chatting_form_click(object sender, EventArgs e)//채팅 추가 버튼 누른 후 유저 이름 클릭 시 이벤트
        {
            Label add_chatting_name_label = (Label)sender;
            Query query = new Query().Insert("Personal_Chat_Meta").Values("'" + Config_Manager.GetInstance().userName + "/" + add_chatting_name_label.Text + "','" + Config_Manager.GetInstance().userName + "','" + add_chatting_name_label.Text + "'");
            DB_Manager.getInstance().insert(query.query);
            this.Close();
            Main.Chatting_form.Close();
            Main.Chatting_form = new Chatting();
            Main.Chatting_form.init(); //채팅창 초기화하는 함수
            Main.Chatting_form.Show();
        }
    }
}


