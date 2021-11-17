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
        public static readonly Approval approval = new Approval();
        public Approval_add()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            approval.Show();
        }
    }
}
