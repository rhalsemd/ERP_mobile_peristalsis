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
    public partial class Approval_add : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public static Approval approval = new Approval();
        public Approval_add(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {

        }

        private void Approval_add_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Approval_open_button_Click(object sender, EventArgs e)
        {
            approval.Show();
        }
    }
}
