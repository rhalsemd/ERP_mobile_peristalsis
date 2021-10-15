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
    public partial class Main : Form
    {
        public static readonly Main Main_form = new Main();
        public static readonly Approval Approval_form = new Approval();
        public static readonly Approval_list Approval_list_form = new Approval_list();
        public static readonly Chatting Chatting_form = new Chatting();
        public static readonly Go_to_work Go_to_work_form = new Go_to_work();
        public static readonly Inventory Inventory_form = new Inventory();
        public static readonly Login Login_form = new Login();
        public static readonly Money Money_form = new Money();
        public static readonly organization_chart organization_chart_form = new organization_chart();
        public static readonly Schedule Schedule_form = new Schedule();
        public static readonly Work_Add Work_Add_form = new Work_Add();
        public static readonly Work_list_check Work_list_check_form = new Work_list_check();
        public static bool chatting_switch = false; //채팅창 무한으로 안켜지게 스위치 역할
        public static bool manager_switch = true; //매니저 메뉴 보이는 스위치 역할

        public Main()
        {
            InitializeComponent();
            if (Main.manager_switch == true)
            {
                Menu_manager.Visible = false;
            }
            else if(Main.manager_switch == false)
            {
                Menu_manager.Visible = true;
            }
        }

        private void 본인일정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Schedule_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 출근현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Go_to_work_form.ShowDialog();
            Close();
            Dispose();
        }

        private void Chatting_Click(object sender, EventArgs e)
        {
            if(chatting_switch == false)
            {
                Main.Chatting_form.Show();
                chatting_switch = true;
            }
            else if(chatting_switch == true)
            {
            }
        }

        private void 업무등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Work_Add_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 업무확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Work_list_check_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 결재등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Approval_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 결재내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Approval_list_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 조직도검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.organization_chart_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 월급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Money_form.ShowDialog();
            Close();
            Dispose();
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Inventory_form.ShowDialog();
            Close();
            Dispose();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Chatting_form.Close();
        }
    }
}
