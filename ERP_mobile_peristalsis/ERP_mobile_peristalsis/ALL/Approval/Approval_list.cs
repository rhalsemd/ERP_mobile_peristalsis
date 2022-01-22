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
        string selected_date = "";
        public Approval_list(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            Approval_list_gridview.Columns.Clear();
            Approval_list_gridview.Refresh();
        }

        private void Approval_list_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            Approval_list_gridview.Columns.Clear();
            Approval_list_gridview.Refresh();
            if (Search.Text == "검색어를 입력하세요.")
            {
                MessageBox.Show("검색어를 입력하세요.");
            }
            else if (Search.Text == "")
            {
                manager.Query query = new manager.Query().Select("Drafter, Department_head, Top_Approver, Contents, Add_date, Progress, Reject").From("cpp_project.Approval").Where("date_format(Add_date, '%Y-%m-%d') = '" + selected_date + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Approval_list_gridview.DataSource = dt;
                Approval_list_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
            else
            {
                manager.Query query = new manager.Query().Select("Drafter, Department_head, Top_Approver, Contents, Add_date, Progress, Reject").From("cpp_project.Approval").Where("date_format(Add_date, '%Y-%m-%d') = '" + selected_date + "'and (Drafter ='" + Search.Text + "'or Department_head ='" + Search.Text + "'or Top_Approver ='" + Search.Text + "'or LOCATE('"+ Search.Text + "', Contents) > 0)");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Approval_list_gridview.DataSource = dt;
                Approval_list_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
        }

        private void Approval_list_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception)
            {
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search.Text = "";
        }

        private void Approval_list_check_datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            selected_date = Approval_list_check_datetimepicker.Value.ToString("yyyy-MM-dd");
        }
    }
}
