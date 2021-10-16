
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
            this.SuspendLayout();
            // 
            // Schedule_calendar
            // 
            this.Schedule_calendar.Location = new System.Drawing.Point(57, 33);
            this.Schedule_calendar.Name = "Schedule_calendar";
            this.Schedule_calendar.TabIndex = 9;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Schedule_calendar);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar Schedule_calendar;
    }
}