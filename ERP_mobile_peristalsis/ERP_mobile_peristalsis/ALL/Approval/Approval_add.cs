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
    public partial class Approval_add : Form
    {
        string user_id = "";
        string load_id = "";
        string user_name = "";
        int admin = -1;
        int load_ad = -1;
        int approval_number = -1;
        DataTable Category_dt;
        public Approval_add(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            Approval_add_dataGridView.Columns.Clear();
            Approval_add_dataGridView.Refresh();
            Main_category.Items.Clear();
            Middle_category.Items.Clear();
            Sub_category.Items.Clear();
            Upload_label.Text = "첨부파일이 없습니다.";
            
            Query query = new Query().Select("*").From("cpp_project.User");
            Category_dt = DB_Manager.getInstance().select(query.query);
            foreach (DataRow row in Category_dt.Rows)
            {
                if (Convert.ToInt32(string.Format("{0}", row["admin"])) == 1)
                {
                    Middle_category.Items.Add(string.Format("{0}", row["Name"]));
                }
                else if (Convert.ToInt32(string.Format("{0}", row["admin"])) == 2)
                {
                    Sub_category.Items.Add(string.Format("{0}", row["Name"]));
                }
                if (string.Format("{0}", row["ID"]) == user_id) {
                    Main_category.Items.Add(string.Format("{0}", row["Name"]));
                    user_name = string.Format("{0}", row["Name"]);
                }
            }
            datagrid_update();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Main_category.Text == "" || Sub_category.Text == "" || Middle_category.Text == "")
            {
                MessageBox.Show("분류를 전부 정하였는지 확인하세요.");
            }
            else
            {
                Query query = new Query().Insert("cpp_project.Approval(Drafter, Department_head, Top_Approver, Contents, Add_date, progress)").Values("'" + Main_category.Text + "','" + Middle_category.Text + "','"+ Sub_category.Text + "','"+Approval_textbox.Text+"', now(), 0");
                manager.DB_Manager.getInstance().insert(query.query);
                MemoryStream ms = new MemoryStream();
                Approval_add_pictureBox.Image.Save(ms, Approval_add_pictureBox.Image.RawFormat);
                query = new Query().Update("cpp_project.Approval").Set("file=@img where Drafter = '"+Main_category.Text+ "' and Department_head = '" + Middle_category.Text + "'and Top_Approver = '" + Sub_category.Text + "'and Contents = '" + Approval_textbox.Text + "'");
                manager.DB_Manager.getInstance().insert_photo(query.query, ms);

                datagrid_update();
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (approval_number == -1 || Main_category.Text == "" || Sub_category.Text == "" || Middle_category.Text == "")
            {
                string selected_num = Approval_add_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                approval_number = Convert.ToInt32(selected_num);
                Query query = new manager.Query().Delete("cpp_project.Approval").Where("Drafter='" + user_name + "' and NUMBER=" + approval_number);
                manager.DB_Manager.getInstance().delete(query.query);
                MessageBox.Show("삭제 되었습니다.");

                approval_number = -1;
                datagrid_update();
            }
            else
            {
                MessageBox.Show("변경할 업무를 선택하지 않았습니다.");
            }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
                Upload_label.Text = "첨부파일이 오른쪽에 표시됩니다.";
                Approval_add_pictureBox.Image = Bitmap.FromFile(image_file);
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {

            }
        }
        private void Approval_add_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Approval_open_button_Click(object sender, EventArgs e)
        {
            string selected_num = Approval_add_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            approval_number = Convert.ToInt32(selected_num);
            if (Main.form_switch[10] == false && approval_number != -1)
            {
                Main.approval = new Approval(user_id, admin ,approval_number);
                Main.approval.Show();
                Main.form_switch[10] = true;
                approval_number = -1;
            }
            else if (Main.form_switch[10] == true)
            {
                approval_number = -1;
            }
        }
        public void datagrid_update()
        {
            Approval_add_dataGridView.Columns.Clear();
            Approval_add_dataGridView.Refresh();
            Query query = new manager.Query().Select("*").From("cpp_project.Approval").Where("Department_head = '"+ user_name + "' or Top_Approver = '" + user_name + "' or Drafter = '" + user_name + "'");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Approval_add_dataGridView.DataSource = dt;
            Approval_add_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Approval_add_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
