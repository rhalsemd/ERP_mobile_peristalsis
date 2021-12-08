
namespace ERP_mobile_peristalsis
{
    partial class Schedule
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
            this.Schedule_calendar = new System.Windows.Forms.MonthCalendar();
            this.add_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.schdule_listbox = new System.Windows.Forms.ListBox();
            this.add_textBox = new System.Windows.Forms.TextBox();
            this.schedule_box = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.schedule_label = new System.Windows.Forms.Label();
            this.schedule_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Schedule_calendar
            // 
            this.Schedule_calendar.Location = new System.Drawing.Point(418, 167);
            this.Schedule_calendar.Name = "Schedule_calendar";
            this.Schedule_calendar.TabIndex = 9;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(288, 78);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "추가";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(104, 331);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 10;
            this.del_button.Text = "삭제";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // schdule_listbox
            // 
            this.schdule_listbox.FormattingEnabled = true;
            this.schdule_listbox.ItemHeight = 15;
            this.schdule_listbox.Location = new System.Drawing.Point(663, 69);
            this.schdule_listbox.Name = "schdule_listbox";
            this.schdule_listbox.Size = new System.Drawing.Size(237, 304);
            this.schdule_listbox.TabIndex = 12;
            // 
            // add_textBox
            // 
            this.add_textBox.Location = new System.Drawing.Point(82, 78);
            this.add_textBox.Name = "add_textBox";
            this.add_textBox.Size = new System.Drawing.Size(200, 23);
            this.add_textBox.TabIndex = 13;
            this.add_textBox.Text = "추가할 스케쥴을 입력하세요.";
            this.add_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // schedule_box
            // 
            this.schedule_box.Controls.Add(this.del_button);
            this.schedule_box.Location = new System.Drawing.Point(650, 48);
            this.schedule_box.Name = "schedule_box";
            this.schedule_box.Size = new System.Drawing.Size(262, 364);
            this.schedule_box.TabIndex = 14;
            this.schedule_box.TabStop = false;
            this.schedule_box.Text = "스케쥴 확인 및 삭제";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "변경할 스케쥴을 선택 후 내용을 입력하세요.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // schedule_label
            // 
            this.schedule_label.AutoSize = true;
            this.schedule_label.Location = new System.Drawing.Point(418, 129);
            this.schedule_label.Name = "schedule_label";
            this.schedule_label.Size = new System.Drawing.Size(390, 15);
            this.schedule_label.TabIndex = 15;
            this.schedule_label.Text = "확인하고 싶은 날짜를 클릭하면 오른쪽에 스케쥴을 확인할 수 있습니다.";
            this.schedule_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.schedule_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_textBox);
            this.Controls.Add(this.schdule_listbox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Schedule_calendar);
            this.Controls.Add(this.schedule_box);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.schedule_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar Schedule_calendar;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.ListBox schdule_listbox;
        private System.Windows.Forms.TextBox add_textBox;
        private System.Windows.Forms.GroupBox schedule_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label schedule_label;
    }
}