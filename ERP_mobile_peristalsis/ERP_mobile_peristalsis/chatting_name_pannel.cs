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
    public partial class chatting_name_pannel : UserControl
    {

        public string chatting_room_name = "";
        

        public chatting_name_pannel()
        {
            InitializeComponent();
        }


        private void chatting_name_pannel_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(192,192,192);
        }

        private void chatting_name_pannel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void chatting_name_pannel_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 192, 192);
            if (Singleton_chatting.instance().check == 0)
            {
                typing_pannel typping_add = new typing_pannel();
                SplitContainer getsplit = Singleton_chatting.instance().splitcontainer_get();
                typping_add.Size = new Size(getsplit.Panel2.Width, 100);
                typping_add.Dock = DockStyle.Bottom;
                getsplit.Panel2.Controls.Add(typping_add);
                Singleton_chatting.instance().check++;

                chatting_log_pannel log = new chatting_log_pannel();
                log.Size = new Size(getsplit.Panel2.Width, getsplit.Panel2.Height - 100);
                log.Dock = DockStyle.Fill;
                log.BackColor = Color.Black;
                getsplit.Panel2.Controls.Add(log);

            }

        }

        private void chatting_name_pannel_Load(object sender, EventArgs e)
        {

        }
    }
}
