using ERP_mobile_peristalsis.manager;
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
    public partial class Work_Add : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        DataTable Category_dt;
        string main_category_num = "";
        int work_number = -1;
        public Work_Add(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            Query query = new Query().Select("*").From("cpp_project.Work_Category");
            Category_dt = DB_Manager.getInstance().select(query.query);
            work_number = -1;
            main_category_num = "";
            Middle_category.Items.Clear();
            Main_category.Items.Clear();
            Sub_category.Items.Clear();
            string category = "";
            string classification = "";
            foreach (DataRow row in Category_dt.Rows)
            {
                category = string.Format("{0}", row["Category"]);
                classification = string.Format("{0}", row["Category_Classification"]);
                if (category != null && classification != null && classification == "1")
                {
                    Main_category.Items.Add(category);

                }
            }
            Work_add_gridview.Columns.Clear();
            Work_add_gridview.Refresh();
            query = new Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category").From("cpp_project.Work").Where("date_format(Work_Date, '%Y-%m-%d') = date_format(now(),'%Y-%m-%d') and ID = '"+user_id+"'");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Work_add_gridview.DataSource = dt;
            Work_add_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Work_Add_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            int log_number = -1;
            if (Main_category.Text == "" || Sub_category.Text == "" || Middle_category.Text == "")
            {
                MessageBox.Show("분류를 전부 정하였는지 확인하세요.");
            }
            else
            {
                manager.Query query = new manager.Query().Insert("cpp_project.Work(ID, Main_Category, Middle_Category, Sub_Category, Work_Date)").Values("'" + user_id + "','" + Main_category.Text + "','" + Middle_category.Text + "','"+Sub_category.Text+"', now()");
                manager.DB_Manager.getInstance().insert(query.query);
                MessageBox.Show("추가 되었습니다.");

                Work_add_gridview.Columns.Clear();
                Work_add_gridview.Refresh();
                query = new Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category").From("cpp_project.Work").Where("date_format(Work_Date, '%Y-%m-%d') = date_format(now(),'%Y-%m-%d') and ID = '" + user_id + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Work_add_gridview.DataSource = dt;
                Work_add_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                
                query = new Query().Select("NUMBER").From("cpp_project.Work").Where("Work_Date IN (SELECT MAX(Work_Date) FROM cpp_project.Work)");
                dt = manager.DB_Manager.getInstance().select(query.query);
                foreach (DataRow row in dt.Rows)
                {
                    log_number = Convert.ToInt32(string.Format("{0}", row["NUMBER"]));
                }
                query = new Query().Insert("cpp_project.Work_log(ID, Work_NUMBER,Work_type, Log_Date)").Values("'" + user_id + "','" + log_number + "','추가', now()");
                manager.DB_Manager.getInstance().insert(query.query);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            int log_number = -1;
            if (work_number == -1 || Main_category.Text == "" || Sub_category.Text == "" || Middle_category.Text == "")
            {
                string selected_num = Work_add_gridview.SelectedRows[0].Cells[0].Value.ToString();
                work_number = Convert.ToInt32(selected_num);
                manager.Query query = new manager.Query().Update("cpp_project.Work").Set("Main_Category='" + Main_category.Text + "', Middle_Category='" + Middle_category.Text + "', Sub_Category = '" + Sub_category.Text + "', Work_Date = now() where NUMBER='" + work_number + "'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("변경 되었습니다.");

                Work_add_gridview.Columns.Clear();
                Work_add_gridview.Refresh();
                query = new Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category").From("cpp_project.Work").Where("date_format(Work_Date, '%Y-%m-%d') = date_format(now(),'%Y-%m-%d') and ID = '" + user_id + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Work_add_gridview.DataSource = dt;
                Work_add_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;

                query = new Query().Select("NUMBER").From("cpp_project.Work").Where("Work_Date IN (SELECT MAX(Work_Date) FROM cpp_project.Work)");
                dt = manager.DB_Manager.getInstance().select(query.query);
                foreach (DataRow row in dt.Rows)
                {
                    log_number = Convert.ToInt32(string.Format("{0}", row["NUMBER"]));
                }
                query = new Query().Insert("cpp_project.Work_log(ID, Work_NUMBER,Work_type, Log_Date)").Values("'" + user_id + "','" + log_number + "','수정', now()");
                manager.DB_Manager.getInstance().insert(query.query);
                work_number = -1;
            }
            else
            {
                MessageBox.Show("변경할 업무를 선택하지 않았습니다.");
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            int log_number = -1;
            if(work_number == -1)
            {
                string selected_num = Work_add_gridview.SelectedRows[0].Cells[0].Value.ToString();
                work_number = Convert.ToInt32(selected_num);
                Query query = new manager.Query().Delete("cpp_project.Work").Where("ID='" + user_id + "' and NUMBER=" + work_number);
                manager.DB_Manager.getInstance().delete(query.query);
                MessageBox.Show("삭제 되었습니다.");
                
                Work_add_gridview.Columns.Clear();
                Work_add_gridview.Refresh();
                query = new Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category").From("cpp_project.Work").Where("date_format(Work_Date, '%Y-%m-%d') = date_format(now(),'%Y-%m-%d') and ID = '" + user_id + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                Work_add_gridview.DataSource = dt;
                Work_add_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;

                query = new Query().Select("NUMBER").From("cpp_project.Work").Where("Work_Date IN (SELECT MAX(Work_Date) FROM cpp_project.Work)");
                dt = manager.DB_Manager.getInstance().select(query.query);
                foreach (DataRow row in dt.Rows)
                {
                    log_number = Convert.ToInt32(string.Format("{0}", row["NUMBER"]));
                }
                query = new Query().Insert("cpp_project.Work_log(ID, Work_NUMBER,Work_type, Log_Date)").Values("'" + user_id + "','" + log_number + "','삭제', now()");
                manager.DB_Manager.getInstance().insert(query.query);
                work_number = -1;
            }
            else
            {
                MessageBox.Show("삭제할 업무를 선택하지 않았습니다.");
            }
        }

        private void Work_add_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void Main_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = "";
            string Belong = "";
            string classification = "";
            string number = "";
            Middle_category.Items.Clear();
            Sub_category.Items.Clear();
            Middle_category.Text = "";
            Sub_category.Text = "";
            foreach (DataRow row in Category_dt.Rows)
            {
                category = string.Format("{0}", row["Category"]);
                classification = string.Format("{0}", row["Category_Classification"]);
                Belong = string.Format("{0}", row["Belong"]);
                if (category != null && Belong != null && classification != null && category == Main_category.SelectedItem.ToString())
                {
                    number = string.Format("{0}", row["NUMBER"]);
                    main_category_num = number;
                }
                else if (Belong != null && category != null && number == Belong)
                {
                    Middle_category.Items.Add(category);
                }
            }
        }

        private void Middle_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = "";
            string Belong = "";
            string classification = "";
            string number = "";
            Sub_category.Items.Clear();
            Sub_category.Text = "";
            foreach (DataRow row in Category_dt.Rows)
            {
                category = string.Format("{0}", row["Category"]);
                classification = string.Format("{0}", row["Category_Classification"]);
                Belong = string.Format("{0}", row["Belong"]);
                if (category != null && Belong != null && classification != null && category == Middle_category.SelectedItem.ToString() && Belong == main_category_num)
                {
                    number = string.Format("{0}", row["NUMBER"]);
                }
                else if (Belong != null && category != null && number == Belong)
                {
                    Sub_category.Items.Add(category);
                }
            }
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            Work_add_gridview.Columns.Clear();
            Work_add_gridview.Refresh();
            Query query = new Query().Select("NUMBER, Main_Category, Middle_Category, Sub_Category").From("cpp_project.Work").Where("date_format(Work_Date, '%Y-%m-%d') = date_format(now(),'%Y-%m-%d') and ID = '" + user_id + "'");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Work_add_gridview.DataSource = dt;
            Work_add_gridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            MessageBox.Show("조회되었습니다.");
        }
    }
}
