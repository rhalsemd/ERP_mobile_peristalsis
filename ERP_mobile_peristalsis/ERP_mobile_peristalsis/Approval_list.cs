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
    public partial class Approval_list : Form
    {
        public Approval_list()
        {
            InitializeComponent();
            if (Main.manager_switch == true)
            {
                Menu_manager.Visible = false;
            }
            else if (Main.manager_switch == false)
            {
                Menu_manager.Visible = true;
            }
        }

        private void 본인일정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Schedule_form.ShowDialog();
            Close();
        }

        private void 출근현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Go_to_work_form.ShowDialog();
            Close();
        }

        private void Chatting_Click(object sender, EventArgs e)
        {
            if (Main.chatting_switch == false)
            {
                Main.Chatting_form.Show();
                Main.chatting_switch = true;
            }
            else if (Main.chatting_switch == true)
            {
            }
        }

        private void 업무등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Work_Add_form.ShowDialog();
            Close();
        }

        private void 업무확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Work_list_check_form.ShowDialog();
            Close();
        }

        private void 결재등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Approval_form.ShowDialog();
            Close();
        }

        private void 결재내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void 조직도검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.organization_chart_form.ShowDialog();
            Close();
        }

        private void 월급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Money_form.ShowDialog();
            Close();
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Inventory_form.ShowDialog();
            Close();
        }

        private void Approval_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Chatting_form.Close();
        }
    }
}
