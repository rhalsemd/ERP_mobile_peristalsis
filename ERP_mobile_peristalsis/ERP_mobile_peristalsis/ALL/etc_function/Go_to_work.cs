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
    public partial class Go_to_work : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public Go_to_work(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            Go_to_work_gridview.Columns.Clear();
            Go_to_work_gridview.Refresh();
            Go_to_work_dateTimePicker.Value = DateTime.Now;
        }

        private void Go_to_work_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DateTime date = Go_to_work_dateTimePicker.Value;
            string s_date = date.Year.ToString()+'-';
            s_date += date.Month.ToString();
            manager.Query query = new manager.Query().Select("Work_Time as '출근시간'").From("Go_to_work").Where("id='" + user_id + "'and date_format(Work_Time, '%Y-%m') = DATE_FORMAT(now(),'"+s_date+"')");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Go_to_work_gridview.DataSource = dt;
            Go_to_work_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            Go_to_work_gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Go_to_work_gridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MessageBox.Show("조회 되었습니다.");
        }
    }
}
