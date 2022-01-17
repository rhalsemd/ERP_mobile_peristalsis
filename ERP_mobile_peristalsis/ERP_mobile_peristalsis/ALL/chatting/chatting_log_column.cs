using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis.chatting
{
    public partial class chatting_log_column : UserControl
    {
        public int last_chat_num = 0;
        public chatting_log_column(int width, string chatting_log,string chatting_room_name)
        {
            this.Size = new Size(width - 70, 80);
            Label textlog = new Label();
            this.BackColor = Color.White;
            textlog.BringToFront();
            textlog.BackColor = Color.White;
            textlog.AutoSize = false;
            textlog.TextAlign = ContentAlignment.MiddleRight;
            textlog.Text = chatting_log;
            this.Controls.Add(textlog);
            textlog.Dock = DockStyle.Fill;
            string query = "select now()";
            DataTable dt_chatting = DB_Manager.getInstance().select(query);
            this.last_chat_num = DB_Manager.getInstance().last_chat_num(chatting_room_name);
            
        }
        public chatting_log_column(bool my ,int width,string chatting_log,string chatting_with,int num)//생성자에 프로필 이미지와 채팅 로그, 사용자 명를 변수로 전해줘야된다.
        {
            this.last_chat_num = num;
            InitializeComponent();
            this.Size = new Size(width-70,80);
            PictureBox profile_picturebox = new PictureBox();
            profile_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Label textlog = new Label();

            if (my == true)
            {
                textlog.BringToFront();
                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.White;
                textlog.AutoSize = false;
                textlog.TextAlign = ContentAlignment.MiddleRight;
                textlog.Text = chatting_log;
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
            else
            {
                profile_picturebox.Size = new Size(80, 50);
                profile_picturebox.BorderStyle = BorderStyle.FixedSingle;
                textlog.TextAlign = ContentAlignment.MiddleLeft;
                textlog.SendToBack();
                profile_picturebox.BringToFront();
                textlog.Dock = DockStyle.Fill;
                profile_picturebox.Dock = DockStyle.Left;
                try
                {
                    Query query = new Query().Select("Picture").From("cpp_project.User").Where("Name = '" + chatting_with + "'");
                    DataTable dt = DB_Manager.getInstance().select(query.query);
                    if (!(dt.Rows[0][0].Equals(DBNull.Value)))
                    {
                        byte[] img = (byte[])dt.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);
                        profile_picturebox.Image = Image.FromStream(ms);
                    }
                }
                catch { }


                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
            this.Controls.SetChildIndex(textlog, 0);
                textlog.BackColor = Color.White;
                textlog.Text = chatting_log;

                
        }
    }
}
