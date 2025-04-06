namespace Design
{
    partial class manager_salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_salary));
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
            panel1.Location = new Point(21, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 541);
            panel1.TabIndex = 5;
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
            ADD_BUTTON.Location = new Point(900, 45);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(120, 37);
            ADD_BUTTON.TabIndex = 15;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // attendence_dataGridView
            // 
            attendence_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            attendence_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendence_dataGridView.Location = new Point(15, 156);
            attendence_dataGridView.Name = "attendence_dataGridView";
            attendence_dataGridView.Size = new Size(1015, 385);
            attendence_dataGridView.TabIndex = 14;
            // 
            // service_price
            // 
            service_price.Location = new Point(435, 42);
            service_price.Name = "service_price";
            service_price.Size = new Size(206, 23);
            service_price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(400, 43);
            label4.Name = "label4";
            label4.Size = new Size(29, 22);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // service_name
            // 
            service_name.Location = new Point(138, 42);
            service_name.Name = "service_name";
            service_name.Size = new Size(206, 23);
            service_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(66, 42);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // manager_salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1096, 588);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manager_salary";
            Text = "manager_salary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ADD_BUTTON;
        private DataGridView attendence_dataGridView;
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
    }
}