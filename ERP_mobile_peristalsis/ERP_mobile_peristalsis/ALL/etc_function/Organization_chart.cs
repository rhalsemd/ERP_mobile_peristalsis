using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Organization_chart_dataGridView.Columns.Clear();
            Organization_chart_dataGridView.Refresh();
            Organization_chart_pictureBox.Image = null;
            list_view_label.Text = "";
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

        private void Organization_chart_search_button_Click(object sender, EventArgs e)
        {
            if (Organization_chart_search_textbox.Text== "검색어를 입력하세요."|| Organization_chart_search_textbox.Text == "")
            {
                manager.Query query = new manager.Query().Select("ID, PhoneNumber, Department, Name").From("cpp_project.User");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Organization_chart_dataGridView.DataSource = dt;
                Organization_chart_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
            else
            {
                manager.Query query = new manager.Query().Select("ID, PhoneNumber, Department, Name").From("cpp_project.User").Where("ID='"+Organization_chart_search_textbox.Text+ "'or PhoneNumber='" + Organization_chart_search_textbox.Text + "'or Department='" + Organization_chart_search_textbox.Text + "'or Name='" + Organization_chart_search_textbox.Text + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Organization_chart_dataGridView.DataSource = dt;
                Organization_chart_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                MessageBox.Show("조회 되었습니다.");
            }
        }

        private void Organization_chart_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                list_view_label.Text = "";
                Organization_chart_pictureBox.Image = null;
                DataGridViewRow row = Organization_chart_dataGridView.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                string phonenumber = row.Cells[1].Value.ToString();
                string department = row.Cells[2].Value.ToString();
                string name = row.Cells[3].Value.ToString();
                string list_data = "이름 : " + name + "\n" + "아이디 : " + id + "\n" + "전화번호 : " + phonenumber + "\n" + "소속부서 : " + department;
                list_view_label.Text = list_data;
                Query query = new Query().Select("Picture").From("cpp_project.User").Where("ID = '" + id + "'");
                DataTable dt = DB_Manager.getInstance().select(query.query);

            }
            catch(NullReferenceException) {
            
            
            }
            catch (Exception)
            {

            }
        }
    }
}
