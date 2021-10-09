﻿
namespace ERP_mobile_peristalsis
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mainmenu = new System.Windows.Forms.MenuStrip();
            this.Menu_schedule = new System.Windows.Forms.ToolStripMenuItem();
            this.본인일정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_work = new System.Windows.Forms.ToolStripMenuItem();
            this.출근현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_task = new System.Windows.Forms.ToolStripMenuItem();
            this.업무ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업무등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업무확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결재ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결재등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결재내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.월급ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_organization = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_manager = new System.Windows.Forms.ToolStripMenuItem();
            this.업무관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결재관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조직도관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출퇴근관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.권한관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.채팅관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Chatting = new System.Windows.Forms.Button();
            this.Inventory_dataGridView = new System.Windows.Forms.DataGridView();
            this.Road_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainmenu
            // 
            this.Mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_schedule,
            this.Menu_work,
            this.Menu_task,
            this.Menu_organization,
            this.Menu_manager});
            this.Mainmenu.Location = new System.Drawing.Point(0, 0);
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(800, 24);
            this.Mainmenu.TabIndex = 20;
            this.Mainmenu.Text = "menuStrip1";
            // 
            // Menu_schedule
            // 
            this.Menu_schedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.본인일정ToolStripMenuItem});
            this.Menu_schedule.Name = "Menu_schedule";
            this.Menu_schedule.Size = new System.Drawing.Size(43, 20);
            this.Menu_schedule.Text = "일정";
            // 
            // 본인일정ToolStripMenuItem
            // 
            this.본인일정ToolStripMenuItem.Name = "본인일정ToolStripMenuItem";
            this.본인일정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.본인일정ToolStripMenuItem.Text = "일정표";
            this.본인일정ToolStripMenuItem.Click += new System.EventHandler(this.본인일정ToolStripMenuItem_Click);
            // 
            // Menu_work
            // 
            this.Menu_work.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.출근현황ToolStripMenuItem});
            this.Menu_work.Name = "Menu_work";
            this.Menu_work.Size = new System.Drawing.Size(55, 20);
            this.Menu_work.Text = "출퇴근";
            // 
            // 출근현황ToolStripMenuItem
            // 
            this.출근현황ToolStripMenuItem.Name = "출근현황ToolStripMenuItem";
            this.출근현황ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.출근현황ToolStripMenuItem.Text = "출퇴근 현황";
            this.출근현황ToolStripMenuItem.Click += new System.EventHandler(this.출근현황ToolStripMenuItem_Click);
            // 
            // Menu_task
            // 
            this.Menu_task.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업무ToolStripMenuItem,
            this.결재ToolStripMenuItem,
            this.월급ToolStripMenuItem,
            this.재고ToolStripMenuItem});
            this.Menu_task.Name = "Menu_task";
            this.Menu_task.Size = new System.Drawing.Size(43, 20);
            this.Menu_task.Text = "업무";
            // 
            // 업무ToolStripMenuItem
            // 
            this.업무ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업무등록ToolStripMenuItem,
            this.업무확인ToolStripMenuItem});
            this.업무ToolStripMenuItem.Name = "업무ToolStripMenuItem";
            this.업무ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.업무ToolStripMenuItem.Text = "업무";
            // 
            // 업무등록ToolStripMenuItem
            // 
            this.업무등록ToolStripMenuItem.Name = "업무등록ToolStripMenuItem";
            this.업무등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.업무등록ToolStripMenuItem.Text = "업무 등록";
            this.업무등록ToolStripMenuItem.Click += new System.EventHandler(this.업무등록ToolStripMenuItem_Click);
            // 
            // 업무확인ToolStripMenuItem
            // 
            this.업무확인ToolStripMenuItem.Name = "업무확인ToolStripMenuItem";
            this.업무확인ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.업무확인ToolStripMenuItem.Text = "업무 내역";
            this.업무확인ToolStripMenuItem.Click += new System.EventHandler(this.업무확인ToolStripMenuItem_Click);
            // 
            // 결재ToolStripMenuItem
            // 
            this.결재ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.결재등록ToolStripMenuItem,
            this.결재내역ToolStripMenuItem});
            this.결재ToolStripMenuItem.Name = "결재ToolStripMenuItem";
            this.결재ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.결재ToolStripMenuItem.Text = "결재";
            // 
            // 결재등록ToolStripMenuItem
            // 
            this.결재등록ToolStripMenuItem.Name = "결재등록ToolStripMenuItem";
            this.결재등록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.결재등록ToolStripMenuItem.Text = "결재 등록";
            this.결재등록ToolStripMenuItem.Click += new System.EventHandler(this.결재등록ToolStripMenuItem_Click);
            // 
            // 결재내역ToolStripMenuItem
            // 
            this.결재내역ToolStripMenuItem.Name = "결재내역ToolStripMenuItem";
            this.결재내역ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.결재내역ToolStripMenuItem.Text = "결재 내역";
            this.결재내역ToolStripMenuItem.Click += new System.EventHandler(this.결재내역ToolStripMenuItem_Click);
            // 
            // 월급ToolStripMenuItem
            // 
            this.월급ToolStripMenuItem.Name = "월급ToolStripMenuItem";
            this.월급ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.월급ToolStripMenuItem.Text = "월급";
            this.월급ToolStripMenuItem.Click += new System.EventHandler(this.월급ToolStripMenuItem_Click);
            // 
            // 재고ToolStripMenuItem
            // 
            this.재고ToolStripMenuItem.Name = "재고ToolStripMenuItem";
            this.재고ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.재고ToolStripMenuItem.Text = "재고";
            this.재고ToolStripMenuItem.Click += new System.EventHandler(this.재고ToolStripMenuItem_Click);
            // 
            // Menu_organization
            // 
            this.Menu_organization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.조직도검색ToolStripMenuItem});
            this.Menu_organization.Name = "Menu_organization";
            this.Menu_organization.Size = new System.Drawing.Size(55, 20);
            this.Menu_organization.Text = "조직도";
            // 
            // 조직도검색ToolStripMenuItem
            // 
            this.조직도검색ToolStripMenuItem.Name = "조직도검색ToolStripMenuItem";
            this.조직도검색ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.조직도검색ToolStripMenuItem.Text = "조직도 검색";
            this.조직도검색ToolStripMenuItem.Click += new System.EventHandler(this.조직도검색ToolStripMenuItem_Click);
            // 
            // Menu_manager
            // 
            this.Menu_manager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업무관련ToolStripMenuItem,
            this.결재관련ToolStripMenuItem,
            this.조직도관련ToolStripMenuItem,
            this.출퇴근관련ToolStripMenuItem,
            this.로그관련ToolStripMenuItem,
            this.권한관리ToolStripMenuItem,
            this.사원관리ToolStripMenuItem,
            this.채팅관리ToolStripMenuItem});
            this.Menu_manager.Name = "Menu_manager";
            this.Menu_manager.Size = new System.Drawing.Size(83, 20);
            this.Menu_manager.Text = "관리자 권한";
            // 
            // 업무관련ToolStripMenuItem
            // 
            this.업무관련ToolStripMenuItem.Name = "업무관련ToolStripMenuItem";
            this.업무관련ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.업무관련ToolStripMenuItem.Text = "업무 관리";
            // 
            // 결재관련ToolStripMenuItem
            // 
            this.결재관련ToolStripMenuItem.Name = "결재관련ToolStripMenuItem";
            this.결재관련ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.결재관련ToolStripMenuItem.Text = "결재 관리";
            // 
            // 조직도관련ToolStripMenuItem
            // 
            this.조직도관련ToolStripMenuItem.Name = "조직도관련ToolStripMenuItem";
            this.조직도관련ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.조직도관련ToolStripMenuItem.Text = "조직도 관리";
            // 
            // 출퇴근관련ToolStripMenuItem
            // 
            this.출퇴근관련ToolStripMenuItem.Name = "출퇴근관련ToolStripMenuItem";
            this.출퇴근관련ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.출퇴근관련ToolStripMenuItem.Text = "출퇴근 관리";
            // 
            // 로그관련ToolStripMenuItem
            // 
            this.로그관련ToolStripMenuItem.Name = "로그관련ToolStripMenuItem";
            this.로그관련ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.로그관련ToolStripMenuItem.Text = "로그 관리";
            // 
            // 권한관리ToolStripMenuItem
            // 
            this.권한관리ToolStripMenuItem.Name = "권한관리ToolStripMenuItem";
            this.권한관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.권한관리ToolStripMenuItem.Text = "권한 관리";
            // 
            // 사원관리ToolStripMenuItem
            // 
            this.사원관리ToolStripMenuItem.Name = "사원관리ToolStripMenuItem";
            this.사원관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.사원관리ToolStripMenuItem.Text = "사원 관리";
            // 
            // 채팅관리ToolStripMenuItem
            // 
            this.채팅관리ToolStripMenuItem.Name = "채팅관리ToolStripMenuItem";
            this.채팅관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.채팅관리ToolStripMenuItem.Text = "채팅 관리";
            // 
            // Chatting
            // 
            this.Chatting.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chatting.Location = new System.Drawing.Point(702, 407);
            this.Chatting.Name = "Chatting";
            this.Chatting.Size = new System.Drawing.Size(99, 43);
            this.Chatting.TabIndex = 19;
            this.Chatting.Text = "채팅";
            this.Chatting.UseVisualStyleBackColor = true;
            this.Chatting.Click += new System.EventHandler(this.Chatting_Click);
            // 
            // Inventory_dataGridView
            // 
            this.Inventory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory_dataGridView.Location = new System.Drawing.Point(43, 76);
            this.Inventory_dataGridView.Name = "Inventory_dataGridView";
            this.Inventory_dataGridView.RowTemplate.Height = 25;
            this.Inventory_dataGridView.Size = new System.Drawing.Size(569, 284);
            this.Inventory_dataGridView.TabIndex = 21;
            // 
            // Road_button
            // 
            this.Road_button.Location = new System.Drawing.Point(654, 36);
            this.Road_button.Name = "Road_button";
            this.Road_button.Size = new System.Drawing.Size(115, 32);
            this.Road_button.TabIndex = 22;
            this.Road_button.Text = "액셀 불러오기";
            this.Road_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(654, 74);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(115, 32);
            this.Save_button.TabIndex = 22;
            this.Save_button.Text = "액셀에 저장하기";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Road_button);
            this.Controls.Add(this.Inventory_dataGridView);
            this.Controls.Add(this.Mainmenu);
            this.Controls.Add(this.Chatting);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventory_FormClosing);
            this.Mainmenu.ResumeLayout(false);
            this.Mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mainmenu;
        private System.Windows.Forms.ToolStripMenuItem Menu_schedule;
        private System.Windows.Forms.ToolStripMenuItem 본인일정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_work;
        private System.Windows.Forms.ToolStripMenuItem 출근현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_task;
        private System.Windows.Forms.ToolStripMenuItem 업무ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업무등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업무확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결재ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결재등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결재내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 월급ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_organization;
        private System.Windows.Forms.ToolStripMenuItem 조직도검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_manager;
        private System.Windows.Forms.ToolStripMenuItem 업무관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결재관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조직도관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출퇴근관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 권한관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 채팅관리ToolStripMenuItem;
        private System.Windows.Forms.Button Chatting;
        private System.Windows.Forms.DataGridView Inventory_dataGridView;
        private System.Windows.Forms.Button Road_button;
        private System.Windows.Forms.Button Save_button;
    }
}