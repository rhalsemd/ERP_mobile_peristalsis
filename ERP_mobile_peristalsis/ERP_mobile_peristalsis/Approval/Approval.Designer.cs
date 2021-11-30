
namespace ERP_mobile_peristalsis
{
    partial class Approval
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
            this.Approval_pictureBox = new System.Windows.Forms.PictureBox();
            this.Approval_textBox = new System.Windows.Forms.TextBox();
            this.Comment_textBox = new System.Windows.Forms.TextBox();
            this.approve_button = new System.Windows.Forms.Button();
            this.Companion_button = new System.Windows.Forms.Button();
            this.fileopen_button = new System.Windows.Forms.Button();
            this.Companion_label = new System.Windows.Forms.Label();
            this.file_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Approval_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Approval_pictureBox
            // 
            this.Approval_pictureBox.Location = new System.Drawing.Point(30, 12);
            this.Approval_pictureBox.Name = "Approval_pictureBox";
            this.Approval_pictureBox.Size = new System.Drawing.Size(738, 471);
            this.Approval_pictureBox.TabIndex = 0;
            this.Approval_pictureBox.TabStop = false;
            // 
            // Approval_textBox
            // 
            this.Approval_textBox.Location = new System.Drawing.Point(30, 500);
            this.Approval_textBox.Multiline = true;
            this.Approval_textBox.Name = "Approval_textBox";
            this.Approval_textBox.Size = new System.Drawing.Size(738, 90);
            this.Approval_textBox.TabIndex = 1;
            // 
            // Comment_textBox
            // 
            this.Comment_textBox.Location = new System.Drawing.Point(192, 618);
            this.Comment_textBox.Multiline = true;
            this.Comment_textBox.Name = "Comment_textBox";
            this.Comment_textBox.Size = new System.Drawing.Size(479, 57);
            this.Comment_textBox.TabIndex = 1;
            // 
            // approve_button
            // 
            this.approve_button.Location = new System.Drawing.Point(30, 618);
            this.approve_button.Name = "approve_button";
            this.approve_button.Size = new System.Drawing.Size(75, 38);
            this.approve_button.TabIndex = 2;
            this.approve_button.Text = "승인";
            this.approve_button.UseVisualStyleBackColor = true;
            this.approve_button.Click += new System.EventHandler(this.approve_button_Click);
            // 
            // Companion_button
            // 
            this.Companion_button.Location = new System.Drawing.Point(111, 618);
            this.Companion_button.Name = "Companion_button";
            this.Companion_button.Size = new System.Drawing.Size(75, 38);
            this.Companion_button.TabIndex = 2;
            this.Companion_button.Text = "반려";
            this.Companion_button.UseVisualStyleBackColor = true;
            this.Companion_button.Click += new System.EventHandler(this.Companion_button_Click);
            // 
            // fileopen_button
            // 
            this.fileopen_button.Location = new System.Drawing.Point(677, 596);
            this.fileopen_button.Name = "fileopen_button";
            this.fileopen_button.Size = new System.Drawing.Size(91, 23);
            this.fileopen_button.TabIndex = 2;
            this.fileopen_button.Text = "첨부파일 열기";
            this.fileopen_button.UseVisualStyleBackColor = true;
            this.fileopen_button.Click += new System.EventHandler(this.fileopen_button_Click);
            // 
            // Companion_label
            // 
            this.Companion_label.AutoSize = true;
            this.Companion_label.Location = new System.Drawing.Point(192, 600);
            this.Companion_label.Name = "Companion_label";
            this.Companion_label.Size = new System.Drawing.Size(59, 15);
            this.Companion_label.TabIndex = 3;
            this.Companion_label.Text = "반려 사유";
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(549, 600);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(122, 15);
            this.file_label.TabIndex = 3;
            this.file_label.Text = "첨부파일이 없습니다.";
            // 
            // Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.Companion_label);
            this.Controls.Add(this.fileopen_button);
            this.Controls.Add(this.Companion_button);
            this.Controls.Add(this.approve_button);
            this.Controls.Add(this.Comment_textBox);
            this.Controls.Add(this.Approval_textBox);
            this.Controls.Add(this.Approval_pictureBox);
            this.Name = "Approval";
            this.Text = "Approval";
            ((System.ComponentModel.ISupportInitialize)(this.Approval_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Approval_pictureBox;
        private System.Windows.Forms.TextBox Approval_textBox;
        private System.Windows.Forms.TextBox Comment_textBox;
        private System.Windows.Forms.Button approve_button;
        private System.Windows.Forms.Button Companion_button;
        private System.Windows.Forms.Button fileopen_button;
        private System.Windows.Forms.Label Companion_label;
        private System.Windows.Forms.Label file_label;
    }
}