
namespace ERP_mobile_peristalsis.ALL.manager_form
{
    partial class Log
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
            this.log_dataGridView = new System.Windows.Forms.DataGridView();
            this.login_log_button = new System.Windows.Forms.Button();
            this.Work_Add_log_button = new System.Windows.Forms.Button();
            this.Approval_add_log_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.log_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // log_dataGridView
            // 
            this.log_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.log_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log_dataGridView.Location = new System.Drawing.Point(71, 139);
            this.log_dataGridView.Name = "log_dataGridView";
            this.log_dataGridView.RowTemplate.Height = 25;
            this.log_dataGridView.Size = new System.Drawing.Size(625, 235);
            this.log_dataGridView.TabIndex = 0;
            // 
            // login_log_button
            // 
            this.login_log_button.Location = new System.Drawing.Point(71, 64);
            this.login_log_button.Name = "login_log_button";
            this.login_log_button.Size = new System.Drawing.Size(120, 40);
            this.login_log_button.TabIndex = 1;
            this.login_log_button.Text = "로그인 로그 확인";
            this.login_log_button.UseVisualStyleBackColor = true;
            this.login_log_button.Click += new System.EventHandler(this.login_log_button_Click);
            // 
            // Work_Add_log_button
            // 
            this.Work_Add_log_button.Location = new System.Drawing.Point(333, 64);
            this.Work_Add_log_button.Name = "Work_Add_log_button";
            this.Work_Add_log_button.Size = new System.Drawing.Size(120, 40);
            this.Work_Add_log_button.TabIndex = 1;
            this.Work_Add_log_button.Text = "업무 로그 확인";
            this.Work_Add_log_button.UseVisualStyleBackColor = true;
            this.Work_Add_log_button.Click += new System.EventHandler(this.Work_Add_log_button_Click);
            // 
            // Approval_add_log_button
            // 
            this.Approval_add_log_button.Location = new System.Drawing.Point(576, 64);
            this.Approval_add_log_button.Name = "Approval_add_log_button";
            this.Approval_add_log_button.Size = new System.Drawing.Size(120, 40);
            this.Approval_add_log_button.TabIndex = 1;
            this.Approval_add_log_button.Text = "결재 로그 확인";
            this.Approval_add_log_button.UseVisualStyleBackColor = true;
            this.Approval_add_log_button.Click += new System.EventHandler(this.Approval_add_log_button_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Approval_add_log_button);
            this.Controls.Add(this.Work_Add_log_button);
            this.Controls.Add(this.login_log_button);
            this.Controls.Add(this.log_dataGridView);
            this.Name = "Log";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.log_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView log_dataGridView;
        private System.Windows.Forms.Button login_log_button;
        private System.Windows.Forms.Button Work_Add_log_button;
        private System.Windows.Forms.Button Approval_add_log_button;
    }
}