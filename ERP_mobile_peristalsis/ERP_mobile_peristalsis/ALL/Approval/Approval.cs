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
    public partial class Approval : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        int load_number = -1;
        int approval_number = -1;
        int progress = -1;
        string user_name = "";
        string Department="";
        DataTable approval_dt;
        public Approval(string user_id, int admin, int approval_number)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.admin = admin;
            this.approval_number = approval_number;

            Approval_pictureBox.Image = null;
            Comment_textBox.Text = "";
            Approval_textBox.Text = "";
            
            Query query = new Query().Select("*").From("cpp_project.Approval").Where("NUMBER = '"+approval_number+"'");
            approval_dt = DB_Manager.getInstance().select(query.query);
            foreach (DataRow row in approval_dt.Rows)
            {
                progress= Convert.ToInt32(string.Format("{0}", row["Progress"]));
                Department = string.Format("{0}", row["Department_head"]);
                Approval_textBox.Text = string.Format("{0}", row["Contents"]);
                Comment_textBox.Text = string.Format("{0}", row["Reject"]);
            }
            query = new Query().Select("file").From("cpp_project.Approval").Where("NUMBER = '" + approval_number + "'");
            DataTable dt = DB_Manager.getInstance().select(query.query);
            try
            {
                if (!(dt.Rows[0][0].Equals(DBNull.Value)))
                {
                    byte[] img = (byte[])dt.Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    Approval_pictureBox.Image = Image.FromStream(ms);
                }
            }
            catch
            {

            }
            query = new Query().Select("*").From("cpp_project.User").Where("ID = '" + user_id + "'");
            approval_dt = DB_Manager.getInstance().select(query.query);
            foreach (DataRow row in approval_dt.Rows)
            {
                user_name = string.Format("{0}", row["Name"]);
            }
        }
        private void Approval_add_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
            load_number = approval_number;
        }
        private void Companion_button_Click(object sender, EventArgs e)
        {
            if (progress == 0 && admin == 1 && Department == user_name)
            {
                manager.Query query = new manager.Query().Update("cpp_project.Approval").Set("Progress = 2 '" + Comment_textBox.Text + "' where NUMBER='" + approval_number + "'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("반려가 완료되었습니다.");
            }
            else if (progress == 1 && admin == 2)
            {
                manager.Query query = new manager.Query().Update("cpp_project.Approval").Set("Progress = 4, Reject = '"+Comment_textBox.Text+"' where NUMBER='" + approval_number + "'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("반려가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("해당 결재자가 아닙니다.");
            }
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (progress == 0 && admin == 1 && Department == user_name)
            {
                manager.Query query = new manager.Query().Update("cpp_project.Approval").Set("Progress = 1 where NUMBER='" + approval_number + "'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("결재가 완료되었습니다.");
            }
            else if(progress == 1 && admin == 2){
                manager.Query query = new manager.Query().Update("cpp_project.Approval").Set("Progress = 3 where NUMBER='" + approval_number + "'");
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("결재가 완료되었습니다.");
            }
            else
            {
                MessageBox.Show("해당 결재자가 아닙니다.");
            }
        }
    }
}
