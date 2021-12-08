
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
            this.button1 = new System.Windows.Forms.Button();
            this.chatting_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(618, 0);
            this.button1.Name = "button_enter";
            this.button1.Size = new System.Drawing.Size(94, 164);
            this.button1.TabIndex = 0;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.enter_button1_Click);
            // 
            // chatting_textBox1
            // 
            this.chatting_textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatting_textBox1.Location = new System.Drawing.Point(0, 0);
            this.chatting_textBox1.Multiline = true;
            this.chatting_textBox1.Name = "chatting_textBox1";
            this.chatting_textBox1.Size = new System.Drawing.Size(618, 164);
            this.chatting_textBox1.TabIndex = 1;
            this.chatting_textBox1.TextChanged += new System.EventHandler(this.chatting_textBox1_TextChanged);
            this.chatting_textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chatting_textBox1_KeyUp);
            // 
            // typing_pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chatting_textBox1);
            this.Controls.Add(this.button1);
            this.Name = "typing_pannel";
            this.Size = new System.Drawing.Size(712, 164);
            this.Load += new System.EventHandler(this.typing_pannel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chatting_textBox1;
    }
}
