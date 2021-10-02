
namespace ERP_mobile_peristalsis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.PW_label = new System.Windows.Forms.Label();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.PW_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_button.Location = new System.Drawing.Point(289, 265);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(154, 53);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "로그인";
            this.Login_button.UseVisualStyleBackColor = true;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_label.Location = new System.Drawing.Point(314, 43);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(75, 45);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "ERP";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_label.Location = new System.Drawing.Point(186, 137);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(25, 21);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "ID";
            // 
            // PW_label
            // 
            this.PW_label.AutoSize = true;
            this.PW_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PW_label.Location = new System.Drawing.Point(186, 196);
            this.PW_label.Name = "PW_label";
            this.PW_label.Size = new System.Drawing.Size(79, 21);
            this.PW_label.TabIndex = 2;
            this.PW_label.Text = "Password";
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(289, 135);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(153, 23);
            this.ID_textbox.TabIndex = 3;
            // 
            // PW_textbox
            // 
            this.PW_textbox.Location = new System.Drawing.Point(289, 198);
            this.PW_textbox.Name = "PW_textbox";
            this.PW_textbox.Size = new System.Drawing.Size(153, 23);
            this.PW_textbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PW_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.PW_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Login_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label PW_label;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox PW_textbox;
    }
}

