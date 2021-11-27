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
        public chatting_log_column(bool my)//생성자에 프로필 이미지와 채팅 로그, 사용자 명를 변수로 전해줘야된다.
        {
            InitializeComponent();
            Bitmap bmp;
            PictureBox profile_picturebox = new PictureBox();
            Label textlog = new Label();
            if (my == true)
            {
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
                profile_picturebox.Dock = DockStyle.Right;
                profile_picturebox.Image = System.Drawing.Image.FromFile("C:/Users/dudtn/Desktop/dog.jpg");
                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.Purple;
            }
            else
            {
                this.Controls.Add(profile_picturebox);
                this.Controls.Add(textlog);
                profile_picturebox.Dock = DockStyle.Left;                
                profile_picturebox.Image = System.Drawing.Image.FromFile("C:/Users/dudtn/Desktop/dog.jpg");
                textlog.Dock = DockStyle.Fill;
                textlog.BackColor = Color.Purple;
            }
        }
    }
}
