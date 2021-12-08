
namespace ERP_mobile_peristalsis
{
    partial class Money
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
            this.Money_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Money_dataGridView = new System.Windows.Forms.DataGridView();
            this.Money_cal_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Money_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Money_dateTimePicker
            // 
            this.Money_dateTimePicker.CustomFormat = "yyyy/MM";
            this.Money_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Money_dateTimePicker.Location = new System.Drawing.Point(233, 91);
            this.Money_dateTimePicker.Name = "Money_dateTimePicker";
            this.Money_dateTimePicker.ShowUpDown = true;
            this.Money_dateTimePicker.Size = new System.Drawing.Size(70, 23);
            this.Money_dateTimePicker.TabIndex = 19;
            // 
            // Money_dataGridView
            // 
            this.Money_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Money_dataGridView.Location = new System.Drawing.Point(233, 135);
            this.Money_dataGridView.Name = "Money_dataGridView";
            this.Money_dataGridView.RowTemplate.Height = 25;
            this.Money_dataGridView.Size = new System.Drawing.Size(458, 158);
            this.Money_dataGridView.TabIndex = 21;
            // 
            // Money_cal_label
            // 
            this.Money_cal_label.AutoSize = true;
            this.Money_cal_label.Location = new System.Drawing.Point(247, 321);
            this.Money_cal_label.Name = "Money_cal_label";
            this.Money_cal_label.Size = new System.Drawing.Size(431, 15);
            this.Money_cal_label.TabIndex = 22;
            this.Money_cal_label.Text = "위의 근무 내역 및 보험공제 가격을 포함시켜 0000000원의 월급이 책정됩니다.";
            // 
            // Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.Money_cal_label);
            this.Controls.Add(this.Money_dataGridView);
            this.Controls.Add(this.Money_dateTimePicker);
            this.Name = "Money";
            this.Text = "Money";
            ((System.ComponentModel.ISupportInitialize)(this.Money_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Money_dateTimePicker;
        private System.Windows.Forms.DataGridView Money_dataGridView;
        private System.Windows.Forms.Label Money_cal_label;
    }
}