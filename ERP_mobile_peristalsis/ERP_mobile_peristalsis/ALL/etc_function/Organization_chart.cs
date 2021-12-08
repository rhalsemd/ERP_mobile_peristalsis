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
    public partial class organization_chart : Form
    {
        public organization_chart()
        {
            InitializeComponent();
        }

        private void Organization_chart_search_textbox_Click(object sender, EventArgs e)
        {
            Organization_chart_search_textbox.Text = "";
        }
    }
}
