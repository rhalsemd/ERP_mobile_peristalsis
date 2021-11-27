using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis.chatting
{
    public partial class chatting_log_column : UserControl
    {
        public chatting_log_column(bool my ,int width)//생성자에 프로필 이미지와 채팅 로그, 사용자 명를 변수로 전해줘야된다.
        {
            InitializeComponent();
            this.Size = new Size(width-70,80);
            Bitmap bmp;
            PictureBox profile_picturebox = new PictureBox();
            Label textlog = new Label();

            if (my == true)
            {
                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.White;
                textlog.Text = "123456789,10,11,12,13,14,15,16,17,18";
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
            else
            {
                profile_picturebox.Size = new Size(80, 50);
                profile_picturebox.Dock = DockStyle.Left;                
                //profile_picturebox.Image = System.Drawing.Image.FromFile("C:/Users/dudtn/Desktop/dog.jpg");이미지 삽입할 때 활용
                profile_picturebox.BorderStyle = BorderStyle.FixedSingle;

                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.White;
                textlog.Text = "123456789,10,11,12,13,14,15,16,17,18";

                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
            }
        }
    }
}
