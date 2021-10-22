using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public static readonly Money Money_form = new Money();
        public static readonly organization_chart organization_chart_form = new organization_chart();
        public static readonly Schedule Schedule_form = new Schedule();
        public static readonly Work_Add Work_Add_form = new Work_Add();
        public static readonly Work_list_check Work_list_check_form = new Work_list_check();
        public static bool chatting_switch = false; //채팅창 무한으로 안켜지게 스위치 역할
        public static bool manager_switch = true; //매니저 메뉴 보이는 스위치 역할
        public int hide_switch = 0;
        public static bool login_switch = false; 

        public Main()
        {
            InitializeComponent();
            if (manager_switch == true)
            {
                Menu_manager.Visible = false;
            }
            else if(manager_switch == false)
            {
                Menu_manager.Visible = true;
            }
            Mainmenu.Visible = false;
            Chatting.Visible = false;
        }

        private void 본인일정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Schedule_form.TopLevel = false;
            this.Controls.Add(Schedule_form);
            Schedule_form.Show();
            Schedule_form.Parent = this.Action_panel;
            Schedule_form.Text = "";
            Schedule_form.ControlBox = false;
        }

        private void 출근현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Go_to_work_form.TopLevel = false; 
            this.Controls.Add(Go_to_work_form);
            Go_to_work_form.Show();
            Go_to_work_form.Parent = this.Action_panel;
            Go_to_work_form.Text = "";
            Go_to_work_form.ControlBox = false;
        }

        private void Chatting_Click(object sender, EventArgs e)
        {
            if(chatting_switch == false)
            {
                Chatting_form.Show();
                chatting_switch = true;
            }
            else if(chatting_switch == true)
            {
            }
        }

        private void 업무등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Work_Add_form.TopLevel = false; 
            this.Controls.Add(Work_Add_form);
            Work_Add_form.Show();
            Work_Add_form.Parent = this.Action_panel;
            Work_Add_form.Text = "";
            Work_Add_form.ControlBox = false;
        }

        private void 업무확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Work_list_check_form.TopLevel = false;
            this.Controls.Add(Work_list_check_form);
            Work_list_check_form.Show();
            Work_list_check_form.Parent = this.Action_panel;
            Work_list_check_form.Text = "";
            Work_list_check_form.ControlBox = false;
        }

        private void 결재등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Approval_form.TopLevel = false;
            this.Controls.Add(Approval_form);
            Approval_form.Show();
            Approval_form.Parent = this.Action_panel;
            Approval_form.Text = "";
            Approval_form.ControlBox = false;
        }

        private void 결재내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Approval_list_form.TopLevel = false;
            this.Controls.Add(Approval_list_form);
            Approval_list_form.Show();
            Approval_list_form.Parent = this.Action_panel;
            Approval_list_form.Text = "";
            Approval_list_form.ControlBox = false;
        }

        private void 조직도검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            organization_chart_form.TopLevel = false;
            this.Controls.Add(organization_chart_form);
            organization_chart_form.Show();
            organization_chart_form.Parent = this.Action_panel;
            organization_chart_form.Text = "";
            organization_chart_form.ControlBox = false;
        }

        private void 월급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Money_form.TopLevel = false;
            this.Controls.Add(Money_form);
            Money_form.Show();
            Money_form.Parent = this.Action_panel;
            Money_form.Text = "";
            Money_form.ControlBox = false;
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            Inventory_form.TopLevel = false;
            this.Controls.Add(Inventory_form);
            Inventory_form.Show();
            Inventory_form.Parent = this.Action_panel;
            Inventory_form.Text = "";
            Inventory_form.ControlBox = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Chatting_form.Close();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            if (login_switch == true)
            {
                if (MessageBox.Show("로그아웃 하시겠습니까?\n(로그아웃 시 현재 작업하고 있는 모든 것들이 저장되지 않습니다!)", "YesORNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    login_switch = false;
                    logout_Action();
                }  
            }
            else if (login_switch == false)
            {
                login_switch = true;
                login_Action();
            }
        }
        private void login_Action()
        {
            Mainmenu.Visible = true;
            Chatting.Visible = true;
            ID_label.Visible = false;
            ID_textbox.Visible = false;
            PW_label.Visible = false;
            PW_textbox.Visible = false;
            Action_panel.Visible = true;
            Login_out_button.Text = "로그아웃";
        }
        private void logout_Action()
        {
            Mainmenu.Visible = false;
            Chatting.Visible = false;
            ID_label.Visible = true;
            ID_textbox.Visible = true;
            PW_label.Visible = true;
            PW_textbox.Visible = true;
            Action_panel.Visible = false;
            Action_panel.Controls.Clear();
            Login_out_button.Text = "로그인";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
