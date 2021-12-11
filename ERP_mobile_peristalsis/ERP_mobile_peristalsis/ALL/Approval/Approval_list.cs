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
    public partial class Approval_list : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public Approval_list(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;

        }

        private void Approval_list_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }
    }
}
