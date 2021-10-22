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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            splitContainer1.Panel1.BackColor = Color.White;

            int count = 13;//여기에 채팅방 갯수를 넣어야된다.

            chatting_name_pannel[] newpanel_class = new chatting_name_pannel[count];
            for(int i = 0; i < count; i++)
            {
                newpanel_class[i] = new chatting_name_pannel();//여기서 객체 하나마다 채팅방 정보를 넣어야 된다.

            }
            if (check_do==0)
            for (int i = 0; i < count; i++)
            {
                check_do++;
                newpanel_class[i].Size = new Size(splitContainer1.Panel1.Width, 45*i);
                newpanel_class[i].BackColor = Color.White;
                    newpanel_class[i].chatting_room_name = "kimharve";
                
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
            splitContainer1.Panel2.BackColor = Color.FromArgb(235, 224, 208);
        }
    public SplitContainer For_panel2_return()
        {
            return splitContainer1;
        }
    }
}
