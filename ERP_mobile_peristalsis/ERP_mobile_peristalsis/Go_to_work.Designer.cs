
namespace ERP_mobile_peristalsis
{
    partial class Go_to_work
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
            this.Go_to_work_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Go_to_work_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Go_to_work_gridview
            // 
            this.Go_to_work_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Go_to_work_gridview.Location = new System.Drawing.Point(107, 68);
            this.Go_to_work_gridview.Name = "Go_to_work_gridview";
            this.Go_to_work_gridview.RowTemplate.Height = 25;
            this.Go_to_work_gridview.Size = new System.Drawing.Size(586, 291);
            this.Go_to_work_gridview.TabIndex = 6;
            // 
            // Go_to_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Go_to_work_gridview);
            this.Name = "Go_to_work";
            this.Text = "Go_to_work";
            ((System.ComponentModel.ISupportInitialize)(this.Go_to_work_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Go_to_work_gridview;
    }
}