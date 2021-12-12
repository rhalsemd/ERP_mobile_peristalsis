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

        int i = 0;
        int Count_User;
        public void init()
        {
            Query query_user_count = new Query().Select("count(*)").From("User");
            Count_User = DB_Manager.getInstance().count_call(query_user_count);
            add_chatting_label= new Label[Count_User];

            Query query_get_user = new Query().Select("Name").From("User");
            DataTable dt_user_list = DB_Manager.getInstance().select(query_get_user.query);

            foreach (DataRow row in dt_user_list.Rows)
            {
                Label label_User_name = new Label();
                label_User_name.Text = row["Name"].ToString();
                label_User_name.BackColor = Color.White;
                this.Controls.Add(label_User_name);
                label_User_name.Dock = DockStyle.Top;
               // add_chatting_form[i] = new Label();
                //add_chatting_form[i].BackColor = Color.White;

                //this.Controls.Add(add_chatting_form[i]);


                //add_chatting_form[i].Dock = DockStyle.Top;
                //add_chatting_form[i].Click += new EventHandler(add_chatting_form_click);
                label_User_name.Click+= new EventHandler(add_chatting_form_click);
               // add_chatting_form[i++].Controls.Add(label_User_name);

            }
        }

        public void add_chatting_form_click(object sender, EventArgs e)//채팅 추가 버튼 누른 후 유저 이름 클릭 시 이벤트
        {
            this.Close();
        }
    }
}
