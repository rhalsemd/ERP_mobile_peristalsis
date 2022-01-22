
namespace ERP_mobile_peristalsis
{
    partial class Approval_list
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
            this.Approval_list_gridview = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.Approval_list_check_datetimepicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Approval_list_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Approval_list_gridview
            // 
            this.Approval_list_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Approval_list_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Approval_list_gridview.Location = new System.Drawing.Point(90, 137);
            this.Approval_list_gridview.Name = "Approval_list_gridview";
            this.Approval_list_gridview.RowTemplate.Height = 25;
            this.Approval_list_gridview.Size = new System.Drawing.Size(764, 205);
            this.Approval_list_gridview.TabIndex = 30;
            this.Approval_list_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Approval_list_gridview_CellClick);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(706, 72);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 29;
            this.Search_button.Text = "검색";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(423, 73);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(261, 23);
            this.Search.TabIndex = 28;
            this.Search.Text = "검색어를 입력하세요.";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Approval_list_check_datetimepicker
            // 
            this.Approval_list_check_datetimepicker.CustomFormat = "yyyy-MM-dd";
            this.Approval_list_check_datetimepicker.Location = new System.Drawing.Point(188, 73);
            this.Approval_list_check_datetimepicker.Name = "Approval_list_check_datetimepicker";
            this.Approval_list_check_datetimepicker.Size = new System.Drawing.Size(200, 23);
            this.Approval_list_check_datetimepicker.TabIndex = 27;
            this.Approval_list_check_datetimepicker.ValueChanged += new System.EventHandler(this.Approval_list_check_datetimepicker_ValueChanged);
            // 
            // Approval_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.Approval_list_gridview);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Approval_list_check_datetimepicker);
            this.Name = "Approval_list";
            this.Text = "Approval_list";
            this.Load += new System.EventHandler(this.Approval_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Approval_list_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Approval_list_gridview;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.DateTimePicker Approval_list_check_datetimepicker;
    }
}