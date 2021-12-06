﻿using ERP_mobile_peristalsis.manager;
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
        public int closed = 0; //창 초기화를 위해 꺼진적이 있는지 체크
        public int clicked = -1; // 클릭한 채팅방 확인용
        public int check_chatting_log = 0;
        public int check_chatting_log_panel = 0;
        int count;
        public chatting_name_pannel[] newpanel_class;
        public SplitContainer splitcontainer;
        public Chatting()
        {
            InitializeComponent();
        }

        private void Chatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.chatting_switch = false;
            this.Hide();
            e.Cancel = true;
            splitcontainer = null;
            closed++;
            for(int i = 0; i < count; i++)
            {
            }
        }
        private int count_personal_chatting()
        {
            Query query_count = new Query().Select("count(*)").From("Personal_Chat_Meta").Where("User1 = '" + Config_Manager.GetInstance().userid + "' or User2 = '" + Config_Manager.GetInstance().userid + "'");

            DataTable dt_count = DB_Manager.getInstance().select(query_count.query);//여기에 채팅방 갯수를 넣어야된다.
            string st_count = "";
            foreach (DataRow row in dt_count.Rows)
            {
                st_count = row["count(*)"].ToString();
            }
            int count = Convert.ToInt32(st_count);
            return count;
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
            count = count_personal_chatting();//채팅방 갯수를 세어주는 카운트

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
        }
        private void delete()
        {

        }
    }
}