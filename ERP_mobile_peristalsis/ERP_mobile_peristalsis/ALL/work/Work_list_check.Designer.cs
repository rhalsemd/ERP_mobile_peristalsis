
namespace ERP_mobile_peristalsis
{
    partial class Work_list_check
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
            this.Work_list_gridview = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Work_list_check_datetimepicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Work_list_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Work_list_gridview
            // 
            this.Work_list_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Work_list_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Work_list_gridview.Location = new System.Drawing.Point(160, 107);
            this.Work_list_gridview.Name = "Work_list_gridview";
            this.Work_list_gridview.RowTemplate.Height = 25;
            this.Work_list_gridview.Size = new System.Drawing.Size(657, 205);
            this.Work_list_gridview.TabIndex = 15;
            this.Work_list_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Work_list_gridview_CellClick);
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(742, 50);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 14;
            this.Search_button.Text = "검색";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(513, 50);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(181, 23);
            this.Search_textBox.TabIndex = 13;
            this.Search_textBox.Text = "검색어를 입력하세요.";
            this.Search_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_textBox.Click += new System.EventHandler(this.Search_textBox_Click);
            // 
            // Work_list_check_datetimepicker
            // 
            this.Work_list_check_datetimepicker.CustomFormat = "yyyy-MM-dd";
            this.Work_list_check_datetimepicker.Location = new System.Drawing.Point(270, 50);
            this.Work_list_check_datetimepicker.Name = "Work_list_check_datetimepicker";
            this.Work_list_check_datetimepicker.Size = new System.Drawing.Size(200, 23);
            this.Work_list_check_datetimepicker.TabIndex = 12;
            // 
            // Work_list_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 401);
            this.Controls.Add(this.Work_list_gridview);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Work_list_check_datetimepicker);
            this.Name = "Work_list_check";
            this.Text = "Work_list_check";
            this.Load += new System.EventHandler(this.Work_list_check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Work_list_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Work_list_gridview;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.DateTimePicker Work_list_check_datetimepicker;
    }
}