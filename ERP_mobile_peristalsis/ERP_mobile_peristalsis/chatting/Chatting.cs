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
        int check_do = 0;
        
        public Chatting()
        {
            InitializeComponent();
        }
        
        private void Chatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.chatting_switch = false;
            this.Hide();
            e.Cancel = true;
        }
        private int count_personal_chatting()
        {
            Query query_count = new Query().Select("count(*)").From("meta_chatting").Where("name = '" + Config_Manager.GetInstance().userid + "' or owner = '" + Config_Manager.GetInstance().userid + "'");

            DataTable dt_count = DB_Manager.getInstance().select(query_count.query);//여기에 채팅방 갯수를 넣어야된다.
            string st_count = "";
            foreach (DataRow row in dt_count.Rows)
            {
                st_count = row["count(*)"].ToString();
            }
            int count = Convert.ToInt32(st_count);
            return count;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            int count = count_personal_chatting();//채팅방 갯수를 세어주는 카운트
            splitContainer1.Panel1.BackColor = Color.White;
            //Query query = new Query().Select("chat_name").From("meta_chatting").Where("name = '" + Config_Manager.GetInstance().userid + "' or owner = '" + Config_Manager.GetInstance().userid + "'");


            chatting_name_pannel[] newpanel_class = new chatting_name_pannel[count];
            for(int i = 0; i < count; i++)
            {
                newpanel_class[i] = new chatting_name_pannel();//여기서 객체 하나마다 채팅방 정보를 넣어야 된다.

            }

            if (check_do==0)
            for (int i = 0; i < count; i++)
            {
                check_do++;
                newpanel_class[i].Size = new Size(splitContainer1.Panel1.Width, 45);
               // newpanel_class[i].Location = new Point(0, 45 * i);
                newpanel_class[i].BackColor = Color.White;
                newpanel_class[i].chatting_room_name = "kimharve";
                    newpanel_class[i].Dock = DockStyle.Top;
                splitContainer1.Panel1.Controls.Add(newpanel_class[i]);
            }
            else
            {
                for(int i=0;i<count;i++)
                newpanel_class[i].Size = new Size(splitContainer1.Panel1.Width, 45 * i);
            }
            splitContainer1.SendToBack();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    public SplitContainer For_panel2_return()
        {
            return splitContainer1;
        }

        private void Chatting_Load(object sender, EventArgs e)
        {
            Singleton_chatting.instance().splitcontainer_set(splitContainer1);
            splitContainer1.Panel2.BackColor = Color.White;
        }

        private void Chatting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Singleton_chatting.instance().check--;
        }
    }
}
