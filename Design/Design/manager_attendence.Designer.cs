namespace Design
{
    partial class manager_attendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_attendence));
            panel1 = new Panel();
            ADD_BUTTON = new Button();
            attendence_dataGridView = new DataGridView();
            service_price = new TextBox();
            label4 = new Label();
            service_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(attendence_dataGridView);
            panel1.Controls.Add(service_price);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 4;
            // 
            // ADD_BUTTON
            // 
            ADD_BUTTON.AutoSize = true;
            ADD_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            ADD_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            ADD_BUTTON.FlatAppearance.BorderSize = 0;
            ADD_BUTTON.FlatStyle = FlatStyle.Flat;
            ADD_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ADD_BUTTON.ForeColor = Color.White;
            ADD_BUTTON.Location = new Point(1006, 56);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(171, 60);
            ADD_BUTTON.TabIndex = 15;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // attendence_dataGridView
            // 
            attendence_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            attendence_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendence_dataGridView.Location = new Point(17, 208);
            attendence_dataGridView.Margin = new Padding(3, 4, 3, 4);
            attendence_dataGridView.Name = "attendence_dataGridView";
            attendence_dataGridView.RowHeadersWidth = 51;
            attendence_dataGridView.Size = new Size(1160, 513);
            attendence_dataGridView.TabIndex = 14;
            // 
            // service_price
            // 
            service_price.Location = new Point(497, 56);
            service_price.Margin = new Padding(3, 4, 3, 4);
            service_price.Name = "service_price";
            service_price.Size = new Size(235, 27);
            service_price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(457, 57);
            label4.Name = "label4";
            label4.Size = new Size(37, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // service_name
            // 
            service_name.Location = new Point(158, 56);
            service_name.Margin = new Padding(3, 4, 3, 4);
            service_name.Name = "service_name";
            service_name.Size = new Size(235, 27);
            service_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(75, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // manager_attendence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "manager_attendence";
            Text = "manager_attendence";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView attendence_dataGridView;
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
        private Button ADD_BUTTON;
    }
}