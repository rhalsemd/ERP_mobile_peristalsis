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
            
        }
    }
}
