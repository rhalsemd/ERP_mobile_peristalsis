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
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public organization_chart(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
        }

        private void Organization_chart_search_textbox_Click(object sender, EventArgs e)
        {
            Organization_chart_search_textbox.Text = "";
        }

        private void organization_chart_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }
    }
}
