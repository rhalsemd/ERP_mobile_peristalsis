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
        public Work_Add(string userid, int admin)
        {
            InitializeComponent();
            user_id = userid;
            this.admin = admin;
            Query query = new Query().Select("*").From("cpp_project.Work_Category");
            Category_dt = DB_Manager.getInstance().select(query.query);
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
        }

        private void Work_Add_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Work_add_gridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Main.form_switch[8] == false)
            {
                Main.Work_list_check_form = new Work_list_check(user_id, admin);
                Main.Work_list_check_form.Show();
                Main.form_switch[8] = true;
            }
            else if (Main.form_switch[8] == true)
            {
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {

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
            foreach (DataRow row in Category_dt.Rows)
            {
                category = string.Format("{0}", row["Category"]);
                classification = string.Format("{0}", row["Category_Classification"]);
                Belong = string.Format("{0}", row["Belong"]);
                if (category != null && Belong != null && classification != null && category == Main_category.SelectedItem.ToString())
                {
                    number = string.Format("{0}", row["NUMBER"]);
                }
                else if (Belong != null && category != null && number == Belong)
                {
                    Middle_category.Items.Add(category);
                }
            }
        }

        private void Middle_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sub_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
