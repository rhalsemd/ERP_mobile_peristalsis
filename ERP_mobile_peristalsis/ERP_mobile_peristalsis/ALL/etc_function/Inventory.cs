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
    public partial class Inventory : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        public Inventory(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            
            Inventory_dataGridView.Columns.Clear();
            Inventory_dataGridView.Refresh();
        }

        private void count_button_Click(object sender, EventArgs e)
        {
            if (count_textBox.Text == "")
            {
                MessageBox.Show("변경할 숫자를 다시 입력하세요.");
            }
            else
            {
                string selected_num = Inventory_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int data = Convert.ToInt32(selected_num);
                manager.Query query = new manager.Query().Update("cpp_project.Inventory").Set("Quantity='" + Convert.ToInt32(count_textBox.Text) + "'where NUMBER='"+data+"'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("변경 되었습니다.");
            }
        }

        private void object_add_button_Click(object sender, EventArgs e)
        {
            if(inventory_ID_textbox.Text == "" || inventory_name_textBox.Text == "" || Quantity_textBox.Text == "")
            {
                MessageBox.Show("제품 이름 혹은 ID 혹은 숫자가 잘못 입력되었거나 공백인지 확인하세요.");
            }
            else
            {
                manager.Query query = new manager.Query().Insert("cpp_project.Inventory(Inventory_ID, Inventory_NAME, Quantity)").Values("('"+inventory_ID_textbox.Text+"','"+inventory_name_textBox.Text+"','"+Convert.ToInt32(Quantity_textBox.Text)+"')");
                manager.DB_Manager.getInstance().insert(query.query);
                MessageBox.Show("추가 되었습니다.");
            }
        }

        private void Lookup_button_Click(object sender, EventArgs e)
        {
            manager.Query query = new manager.Query().Select("*").From("cpp_project.Inventory");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Inventory_dataGridView.DataSource = dt;
            Inventory_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            MessageBox.Show("조회 되었습니다.");
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Inventory_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
