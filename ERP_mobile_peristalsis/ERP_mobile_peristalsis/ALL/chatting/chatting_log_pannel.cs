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
    public partial class chatting_log_pannel : UserControl
    {
        public chatting_log_pannel()
        {
            InitializeComponent();
        }

        private void chatting_log_pannel_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

    }
}
