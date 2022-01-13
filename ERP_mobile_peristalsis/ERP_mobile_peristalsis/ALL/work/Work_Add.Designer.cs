
namespace ERP_mobile_peristalsis
{
    partial class Work_Add
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
            this.Add_button = new System.Windows.Forms.Button();
            this.Work_add_gridview = new System.Windows.Forms.DataGridView();
            this.Main_category = new System.Windows.Forms.ComboBox();
            this.Middle_category = new System.Windows.Forms.ComboBox();
            this.Sub_category = new System.Windows.Forms.ComboBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.Main_category_label = new System.Windows.Forms.Label();
            this.Middle_category_label = new System.Windows.Forms.Label();
            this.Sub_category_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Work_add_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(733, 67);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "등록";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Work_add_gridview
            // 
            this.Work_add_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Work_add_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Work_add_gridview.Location = new System.Drawing.Point(157, 151);
            this.Work_add_gridview.Name = "Work_add_gridview";
            this.Work_add_gridview.RowTemplate.Height = 25;
            this.Work_add_gridview.Size = new System.Drawing.Size(651, 205);
            this.Work_add_gridview.TabIndex = 11;
            this.Work_add_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Work_add_gridview_CellClick);
            // 
            // Main_category
            // 
            this.Main_category.FormattingEnabled = true;
            this.Main_category.Location = new System.Drawing.Point(176, 68);
            this.Main_category.Name = "Main_category";
            this.Main_category.Size = new System.Drawing.Size(121, 23);
            this.Main_category.TabIndex = 12;
            this.Main_category.SelectedIndexChanged += new System.EventHandler(this.Main_category_SelectedIndexChanged);
            // 
            // Middle_category
            // 
            this.Middle_category.FormattingEnabled = true;
            this.Middle_category.Location = new System.Drawing.Point(323, 68);
            this.Middle_category.Name = "Middle_category";
            this.Middle_category.Size = new System.Drawing.Size(121, 23);
            this.Middle_category.TabIndex = 12;
            this.Middle_category.SelectedIndexChanged += new System.EventHandler(this.Middle_category_SelectedIndexChanged);
            // 
            // Sub_category
            // 
            this.Sub_category.FormattingEnabled = true;
            this.Sub_category.Location = new System.Drawing.Point(465, 68);
            this.Sub_category.Name = "Sub_category";
            this.Sub_category.Size = new System.Drawing.Size(121, 23);
            this.Sub_category.TabIndex = 12;
            this.Sub_category.SelectedIndexChanged += new System.EventHandler(this.Sub_category_SelectedIndexChanged);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(644, 109);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "수정";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(733, 109);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 23);
            this.remove_button.TabIndex = 10;
            this.remove_button.Text = "삭제";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // Main_category_label
            // 
            this.Main_category_label.AutoSize = true;
            this.Main_category_label.Location = new System.Drawing.Point(215, 50);
            this.Main_category_label.Name = "Main_category_label";
            this.Main_category_label.Size = new System.Drawing.Size(43, 15);
            this.Main_category_label.TabIndex = 13;
            this.Main_category_label.Text = "대분류";
            // 
            // Middle_category_label
            // 
            this.Middle_category_label.AutoSize = true;
            this.Middle_category_label.Location = new System.Drawing.Point(366, 50);
            this.Middle_category_label.Name = "Middle_category_label";
            this.Middle_category_label.Size = new System.Drawing.Size(43, 15);
            this.Middle_category_label.TabIndex = 13;
            this.Middle_category_label.Text = "중분류";
            // 
            // Sub_category_label
            // 
            this.Sub_category_label.AutoSize = true;
            this.Sub_category_label.Location = new System.Drawing.Point(506, 50);
            this.Sub_category_label.Name = "Sub_category_label";
            this.Sub_category_label.Size = new System.Drawing.Size(43, 15);
            this.Sub_category_label.TabIndex = 13;
            this.Sub_category_label.Text = "소분류";
            // 
            // Work_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 401);
            this.Controls.Add(this.Sub_category_label);
            this.Controls.Add(this.Middle_category_label);
            this.Controls.Add(this.Main_category_label);
            this.Controls.Add(this.Sub_category);
            this.Controls.Add(this.Middle_category);
            this.Controls.Add(this.Main_category);
            this.Controls.Add(this.Work_add_gridview);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.Add_button);
            this.Name = "Work_Add";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.Work_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Work_add_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView Work_add_gridview;
        private System.Windows.Forms.ComboBox Main_category;
        private System.Windows.Forms.ComboBox Middle_category;
        private System.Windows.Forms.ComboBox Sub_category;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label Main_category_label;
        private System.Windows.Forms.Label Middle_category_label;
        private System.Windows.Forms.Label Sub_category_label;
    }
}