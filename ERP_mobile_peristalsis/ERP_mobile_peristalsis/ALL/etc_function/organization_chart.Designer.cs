
namespace ERP_mobile_peristalsis
{
    partial class organization_chart
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
            this.Organization_chart_dataGridView = new System.Windows.Forms.DataGridView();
            this.Organization_chart_pictureBox = new System.Windows.Forms.PictureBox();
            this.Organization_chart_listView = new System.Windows.Forms.ListView();
            this.Organization_chart_search_textbox = new System.Windows.Forms.TextBox();
            this.Organization_chart_search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Organization_chart_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Organization_chart_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Organization_chart_dataGridView
            // 
            this.Organization_chart_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Organization_chart_dataGridView.Location = new System.Drawing.Point(134, 81);
            this.Organization_chart_dataGridView.Name = "Organization_chart_dataGridView";
            this.Organization_chart_dataGridView.RowTemplate.Height = 25;
            this.Organization_chart_dataGridView.Size = new System.Drawing.Size(505, 302);
            this.Organization_chart_dataGridView.TabIndex = 0;
            // 
            // Organization_chart_pictureBox
            // 
            this.Organization_chart_pictureBox.Location = new System.Drawing.Point(677, 81);
            this.Organization_chart_pictureBox.Name = "Organization_chart_pictureBox";
            this.Organization_chart_pictureBox.Size = new System.Drawing.Size(129, 109);
            this.Organization_chart_pictureBox.TabIndex = 23;
            this.Organization_chart_pictureBox.TabStop = false;
            // 
            // Organization_chart_listView
            // 
            this.Organization_chart_listView.HideSelection = false;
            this.Organization_chart_listView.Location = new System.Drawing.Point(677, 196);
            this.Organization_chart_listView.Name = "Organization_chart_listView";
            this.Organization_chart_listView.Size = new System.Drawing.Size(129, 187);
            this.Organization_chart_listView.TabIndex = 24;
            this.Organization_chart_listView.UseCompatibleStateImageBehavior = false;
            // 
            // Organization_chart_search_textbox
            // 
            this.Organization_chart_search_textbox.Location = new System.Drawing.Point(380, 42);
            this.Organization_chart_search_textbox.Name = "Organization_chart_search_textbox";
            this.Organization_chart_search_textbox.Size = new System.Drawing.Size(162, 23);
            this.Organization_chart_search_textbox.TabIndex = 25;
            this.Organization_chart_search_textbox.Text = "검색어를 입력하세요.";
            this.Organization_chart_search_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Organization_chart_search_textbox.Click += new System.EventHandler(this.Organization_chart_search_textbox_Click);
            // 
            // Organization_chart_search_button
            // 
            this.Organization_chart_search_button.Location = new System.Drawing.Point(564, 41);
            this.Organization_chart_search_button.Name = "Organization_chart_search_button";
            this.Organization_chart_search_button.Size = new System.Drawing.Size(75, 23);
            this.Organization_chart_search_button.TabIndex = 26;
            this.Organization_chart_search_button.Text = "검색";
            this.Organization_chart_search_button.UseVisualStyleBackColor = true;
            // 
            // organization_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.Organization_chart_search_button);
            this.Controls.Add(this.Organization_chart_search_textbox);
            this.Controls.Add(this.Organization_chart_listView);
            this.Controls.Add(this.Organization_chart_pictureBox);
            this.Controls.Add(this.Organization_chart_dataGridView);
            this.Name = "organization_chart";
            this.Text = "organization_chart";
            this.Load += new System.EventHandler(this.organization_chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Organization_chart_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Organization_chart_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Organization_chart_dataGridView;
        private System.Windows.Forms.PictureBox Organization_chart_pictureBox;
        private System.Windows.Forms.ListView Organization_chart_listView;
        private System.Windows.Forms.TextBox Organization_chart_search_textbox;
        private System.Windows.Forms.Button Organization_chart_search_button;
    }
}