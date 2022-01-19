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
    public partial class Work_list_check : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        string selected_date = "";
        public Work_list_check(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            selected_date = Work_list_check_datetimepicker.Value.ToString("yyyy-MM-dd");
            Work_list_gridview.Columns.Clear();
            Work_list_gridview.Refresh();
        }

        private void Work_list_check_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Search_textBox.Text == "검색어를 입력하세요.")
            {
                MessageBox.Show("검색어를 입력하세요.");
            }
            else if(Search_textBox.Text == "")
            {
                manager.Query query = new manager.Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category, Work_Date").From("cpp_project.Work").Where("ID='" + user_id + "' and date_format(Work_Date, '%Y-%m-%d') = '" + selected_date + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Work_list_gridview.Columns.Clear();
                Work_list_gridview.Refresh();
                Work_list_gridview.DataSource = dt;
                Work_list_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
            else
            {
                manager.Query query = new manager.Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category, Work_Date").From("cpp_project.Work").Where("ID='" + user_id + "' and date_format(Work_Date, '%Y-%m-%d') = '" + selected_date + "'and (Main_category ='"+Search_textBox.Text+ "'or Middle_category ='" + Search_textBox.Text + "'or Sub_category ='" + Search_textBox.Text + "')");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Work_list_gridview.Columns.Clear();
                Work_list_gridview.Refresh();
                Work_list_gridview.DataSource = dt;
                Work_list_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
        }

        private void Work_list_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void Search_textBox_Click(object sender, EventArgs e)
        {
            Search_textBox.Text = "";
        }
    }
}
