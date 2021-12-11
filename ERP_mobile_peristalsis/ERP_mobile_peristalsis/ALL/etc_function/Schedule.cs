using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_mobile_peristalsis.manager;

namespace ERP_mobile_peristalsis
{
    public partial class Schedule : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public Schedule(string userid, int admin)
        {
            InitializeComponent();
            schedule_label.Text = "확인하고 싶은 날짜를 클릭하면\n 오른쪽에서 스케쥴을 확인할 수 있습니다.";
            user_id = userid;
            this.admin = admin;
        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void del_button_Click(object sender, EventArgs e)
        {

        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
            label1.Text = load_id;
        }
    }
}
