
namespace ERP_mobile_peristalsis
{
    partial class typing_pannel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Insert_button = new System.Windows.Forms.Button();
            this.chatting_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Insert_button
            // 
            this.Insert_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Insert_button.Location = new System.Drawing.Point(481, 0);
            this.Insert_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(73, 123);
            this.Insert_button.TabIndex = 0;
            this.Insert_button.Text = "입력";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.enter_button1_Click);
            // 
            // chatting_textBox1
            // 
            this.chatting_textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatting_textBox1.Location = new System.Drawing.Point(0, 0);
            this.chatting_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chatting_textBox1.Multiline = true;
            this.chatting_textBox1.Name = "chatting_textBox1";
            this.chatting_textBox1.Size = new System.Drawing.Size(481, 123);
            this.chatting_textBox1.TabIndex = 1;
            this.chatting_textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chatting_textBox1_KeyUp);
            // 
            // typing_pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatting_textBox1);
            this.Controls.Add(this.Insert_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "typing_pannel";
            this.Size = new System.Drawing.Size(554, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.TextBox chatting_textBox1;
    }
}
