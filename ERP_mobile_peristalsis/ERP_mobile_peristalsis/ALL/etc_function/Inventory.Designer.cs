
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
            this.count_button = new System.Windows.Forms.Button();
            this.object_add_button = new System.Windows.Forms.Button();
            this.count_textBox = new System.Windows.Forms.TextBox();
            this.inventory_ID_textbox = new System.Windows.Forms.TextBox();
            this.inventory_name_textBox = new System.Windows.Forms.TextBox();
            this.count_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.Lookup_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventory_dataGridView
            // 
            this.Inventory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory_dataGridView.Location = new System.Drawing.Point(12, 65);
            this.Inventory_dataGridView.Name = "Inventory_dataGridView";
            this.Inventory_dataGridView.RowTemplate.Height = 25;
            this.Inventory_dataGridView.Size = new System.Drawing.Size(610, 284);
            this.Inventory_dataGridView.TabIndex = 21;
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(838, 129);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(77, 23);
            this.count_button.TabIndex = 22;
            this.count_button.Text = "수량 변경";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // object_add_button
            // 
            this.object_add_button.Location = new System.Drawing.Point(703, 277);
            this.object_add_button.Name = "object_add_button";
            this.object_add_button.Size = new System.Drawing.Size(102, 25);
            this.object_add_button.TabIndex = 22;
            this.object_add_button.Text = "물건 추가";
            this.object_add_button.UseVisualStyleBackColor = true;
            this.object_add_button.Click += new System.EventHandler(this.object_add_button_Click);
            // 
            // count_textBox
            // 
            this.count_textBox.Location = new System.Drawing.Point(696, 129);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.Size = new System.Drawing.Size(122, 23);
            this.count_textBox.TabIndex = 23;
            // 
            // inventory_ID_textbox
            // 
            this.inventory_ID_textbox.Location = new System.Drawing.Point(693, 194);
            this.inventory_ID_textbox.Name = "inventory_ID_textbox";
            this.inventory_ID_textbox.Size = new System.Drawing.Size(122, 23);
            this.inventory_ID_textbox.TabIndex = 23;
            // 
            // inventory_name_textBox
            // 
            this.inventory_name_textBox.Location = new System.Drawing.Point(693, 248);
            this.inventory_name_textBox.Name = "inventory_name_textBox";
            this.inventory_name_textBox.Size = new System.Drawing.Size(122, 23);
            this.inventory_name_textBox.TabIndex = 23;
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(631, 132);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(59, 15);
            this.count_label.TabIndex = 24;
            this.count_label.Text = "수량 입력";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(706, 176);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(99, 15);
            this.id_label.TabIndex = 24;
            this.id_label.Text = "재고 아이디 입력";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(710, 230);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(87, 15);
            this.name_label.TabIndex = 24;
            this.name_label.Text = "재고 이름 입력";
            // 
            // Lookup_button
            // 
            this.Lookup_button.Location = new System.Drawing.Point(728, 81);
            this.Lookup_button.Name = "Lookup_button";
            this.Lookup_button.Size = new System.Drawing.Size(50, 23);
            this.Lookup_button.TabIndex = 22;
            this.Lookup_button.Text = "조회";
            this.Lookup_button.UseVisualStyleBackColor = true;
            this.Lookup_button.Click += new System.EventHandler(this.Lookup_button_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 424);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.inventory_name_textBox);
            this.Controls.Add(this.inventory_ID_textbox);
            this.Controls.Add(this.count_textBox);
            this.Controls.Add(this.object_add_button);
            this.Controls.Add(this.Lookup_button);
            this.Controls.Add(this.count_button);
            this.Controls.Add(this.Inventory_dataGridView);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Inventory_dataGridView;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.Button object_add_button;
        private System.Windows.Forms.TextBox count_textBox;
        private System.Windows.Forms.TextBox inventory_ID_textbox;
        private System.Windows.Forms.TextBox inventory_name_textBox;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button Lookup_button;
    }
}