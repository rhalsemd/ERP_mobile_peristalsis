using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_mobile_peristalsis.manager;

namespace ERP_mobile_peristalsis
{
    public partial class Schedule : Form
    {
        string user_id = "";
        string load_id = "";
        int admin = -1;
        int load_ad = -1;
        string selected_day = "";
        int selected_number = -1;
        public Schedule(string userid, int admin)
        {
            InitializeComponent();
            schedule_label.Text = "확인하고 싶은 날짜를 클릭하면\n 오른쪽에서 스케쥴을 확인할 수 있습니다.";
            user_id = userid;
            this.admin = admin;

            Schedule_calendar.SelectionStart = DateTime.Now;
            schdule_listbox.Items.Clear();
            selected_day = Schedule_calendar.SelectionStart.ToShortDateString();
            select_schedule();
            selected_number = -1;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (add_textBox.Text== "추가할 스케쥴을 입력하세요.")
            {
                MessageBox.Show("추가할 스케쥴을 입력하세요.");
            }
            else if (add_textBox.Text.Length > 20)
            {
                MessageBox.Show("20자 이내로 입력하세요.");
            }
            else
            {
                manager.Query query = new manager.Query().Insert("cpp_project.Schedule(ID, Content, Schedule_date)").Values("'" + user_id + "','" +add_textBox.Text+"','" + selected_day + "'");
                manager.DB_Manager.getInstance().insert(query.query);
                select_schedule();
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (selected_number == -1)
            {
                MessageBox.Show("스케줄이 없거나 스케줄을 선택하지 않았습니다.");
            }
            else
            {
                manager.Query query = new manager.Query().Select("NUMBER, Content").From("cpp_project.Schedule").Where("ID='" + user_id + "' and date_format(Schedule_Date, '%Y-%m-%d') = '" + selected_day + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                int number = Convert.ToInt32(dt.Rows[selected_number]["NUMBER"]);
                query = new manager.Query().Delete("cpp_project.Schedule").Where("ID='" + user_id + "' and NUMBER=" + number);
                manager.DB_Manager.getInstance().delete(query.query);
                MessageBox.Show("삭제 되었습니다.");
                select_schedule();
            }
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            load_id = user_id;
            load_ad = admin;
        }

        private void Schedule_calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            schdule_listbox.Items.Clear();
            selected_day =Schedule_calendar.SelectionStart.ToShortDateString();
            select_schedule();
        }
        public void select_schedule() //스케줄 명단을 가져오는 메소드
        {
            schdule_listbox.Items.Clear();
            manager.Query query = new manager.Query().Select("NUMBER, Content").From("cpp_project.Schedule").Where("ID='" + user_id + "' and date_format(Schedule_Date, '%Y-%m-%d') = '" + selected_day + "'");
            DataTable dt = manager.DB_Manager.getInstance().select(query.query);
            foreach (DataRow row in dt.Rows)
            {
                schdule_listbox.Items.Add(row["Content"].ToString());
            }
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (selected_number == -1)
            {
                MessageBox.Show("스케줄이 없거나 스케줄을 선택하지 않았습니다.");
            }
            else if (Change_textBox.Text == "변경할 스케쥴을 선택 후 내용을 입력하세요.")
            {
                MessageBox.Show("스케쥴 변경 시 내용을 입력하세요.");
            }
            else if (Change_textBox.Text.Length > 20)
            {
                MessageBox.Show("20자 이내로 입력하세요.");
            }
            else
            {
                manager.Query query = new manager.Query().Select("NUMBER, Content").From("cpp_project.Schedule").Where("ID='" + user_id + "' and date_format(Schedule_Date, '%Y-%m-%d') = '" + selected_day + "'");
                DataTable dt = manager.DB_Manager.getInstance().select(query.query);
                int number = Convert.ToInt32(dt.Rows[selected_number]["NUMBER"]);
                query = new manager.Query().Update("cpp_project.Schedule").Set("Content='"+Change_textBox.Text+"'").Where("ID='" + user_id + "' and NUMBER="+number);
                manager.DB_Manager.getInstance().update(query.query);
                MessageBox.Show("변경 되었습니다.");
                select_schedule();
            }
        }

        private void schdule_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_number = schdule_listbox.SelectedIndex;
        }

        private void Change_textBox_Click(object sender, EventArgs e)
        {
            Change_textBox.Text = "";
        }

        private void add_textBox_Click(object sender, EventArgs e)
        {
            add_textBox.Text = "";
        }
    }
}
