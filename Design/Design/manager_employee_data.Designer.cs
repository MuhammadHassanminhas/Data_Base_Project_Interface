namespace Design
{
    partial class manager_employee_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_employee_data));
            panel1 = new Panel();
            SEARCH_BUTTON = new Button();
            EMPLOYEE_dataGridView = new DataGridView();
            emp_id = new TextBox();
            label4 = new Label();
            emp_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EMPLOYEE_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SEARCH_BUTTON);
            panel1.Controls.Add(EMPLOYEE_dataGridView);
            panel1.Controls.Add(emp_id);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(emp_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 5;
            // 
            // SEARCH_BUTTON
            // 
            SEARCH_BUTTON.AutoSize = true;
            SEARCH_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            SEARCH_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            SEARCH_BUTTON.FlatAppearance.BorderSize = 0;
            SEARCH_BUTTON.FlatStyle = FlatStyle.Flat;
            SEARCH_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SEARCH_BUTTON.ForeColor = Color.White;
            SEARCH_BUTTON.Location = new Point(1006, 57);
            SEARCH_BUTTON.Margin = new Padding(3, 4, 3, 4);
            SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            SEARCH_BUTTON.Size = new Size(171, 60);
            SEARCH_BUTTON.TabIndex = 15;
            SEARCH_BUTTON.Text = "SEARCH";
            SEARCH_BUTTON.UseVisualStyleBackColor = false;
            SEARCH_BUTTON.Click += SEARCH_BUTTON_Click;
            // 
            // EMPLOYEE_dataGridView
            // 
            EMPLOYEE_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            EMPLOYEE_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EMPLOYEE_dataGridView.Location = new Point(17, 208);
            EMPLOYEE_dataGridView.Margin = new Padding(3, 4, 3, 4);
            EMPLOYEE_dataGridView.Name = "EMPLOYEE_dataGridView";
            EMPLOYEE_dataGridView.RowHeadersWidth = 51;
            EMPLOYEE_dataGridView.Size = new Size(1160, 513);
            EMPLOYEE_dataGridView.TabIndex = 14;
            // 
            // emp_id
            // 
            emp_id.Location = new Point(497, 56);
            emp_id.Margin = new Padding(3, 4, 3, 4);
            emp_id.Name = "emp_id";
            emp_id.Size = new Size(235, 27);
            emp_id.TabIndex = 8;
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
            // emp_name
            // 
            emp_name.Location = new Point(158, 56);
            emp_name.Margin = new Padding(3, 4, 3, 4);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(235, 27);
            emp_name.TabIndex = 3;
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
            // manager_employee_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "manager_employee_data";
            Text = "manager_employee_data";
            Load += manager_employee_data_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EMPLOYEE_dataGridView).EndInit();
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
        private Button SEARCH_BUTTON;
        private DataGridView EMPLOYEE_dataGridView;
        private TextBox emp_id;
        private TextBox emp_name;
    }
}