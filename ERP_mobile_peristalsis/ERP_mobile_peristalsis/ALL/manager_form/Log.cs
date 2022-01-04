using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis.ALL.manager_form
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            log_dataGridView.Columns.Clear();
            log_dataGridView.Refresh();
        }

        private void login_log_button_Click(object sender, EventArgs e)
        {
            manager.Query query = new manager.Query().Select("ID, Log_time, Log_type").From("Login_log");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            log_dataGridView.DataSource = dt;
            log_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            log_dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            log_dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.form_switch[10] = false;
        }
    }
}
