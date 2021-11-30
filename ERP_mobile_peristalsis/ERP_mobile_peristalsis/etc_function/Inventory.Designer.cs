
namespace ERP_mobile_peristalsis
{
    partial class Inventory
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
            this.Inventory_dataGridView = new System.Windows.Forms.DataGridView();
            this.Road_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventory_dataGridView
            // 
            this.Inventory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory_dataGridView.Location = new System.Drawing.Point(43, 76);
            this.Inventory_dataGridView.Name = "Inventory_dataGridView";
            this.Inventory_dataGridView.RowTemplate.Height = 25;
            this.Inventory_dataGridView.Size = new System.Drawing.Size(569, 284);
            this.Inventory_dataGridView.TabIndex = 21;
            // 
            // Road_button
            // 
            this.Road_button.Location = new System.Drawing.Point(654, 36);
            this.Road_button.Name = "Road_button";
            this.Road_button.Size = new System.Drawing.Size(115, 32);
            this.Road_button.TabIndex = 22;
            this.Road_button.Text = "액셀 불러오기";
            this.Road_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(654, 74);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(115, 32);
            this.Save_button.TabIndex = 22;
            this.Save_button.Text = "액셀에 저장하기";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Road_button);
            this.Controls.Add(this.Inventory_dataGridView);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Inventory_dataGridView;
        private System.Windows.Forms.Button Road_button;
        private System.Windows.Forms.Button Save_button;
    }
}