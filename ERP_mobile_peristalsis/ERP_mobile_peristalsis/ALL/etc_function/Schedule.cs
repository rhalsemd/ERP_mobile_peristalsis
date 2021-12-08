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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            schedule_label.Text = "확인하고 싶은 날짜를 클릭하면\n 오른쪽에서 스케쥴을 확인할 수 있습니다.";
        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void del_button_Click(object sender, EventArgs e)
        {

        }
    }
}
