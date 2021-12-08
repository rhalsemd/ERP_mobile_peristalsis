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
        public Inventory()
        {
            InitializeComponent();
            Inventory_dataGridView.Columns.Clear();
            Inventory_dataGridView.Refresh();
        }

        private void count_button_Click(object sender, EventArgs e)
        {

        }

        private void object_add_button_Click(object sender, EventArgs e)
        {

        }

        private void Lookup_button_Click(object sender, EventArgs e)
        {
            manager.Query query = new manager.Query().Select("*").From("Inventory");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            Inventory_dataGridView.DataSource = dt;
            Inventory_dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
