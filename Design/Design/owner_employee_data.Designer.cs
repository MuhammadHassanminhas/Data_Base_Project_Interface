namespace Design
{
    partial class owner_employee_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_employee_data));
            panel1 = new Panel();
            emp_address = new TextBox();
            label6 = new Label();
            emp_contact = new TextBox();
            emp_cnic = new TextBox();
            label3 = new Label();
            label1 = new Label();
            employee_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            label5 = new Label();
            emp_id = new TextBox();
            label4 = new Label();
            position_dropdown = new ComboBox();
            emp_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employee_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(emp_address);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(emp_contact);
            panel1.Controls.Add(emp_cnic);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(employee_dataGridView);
            panel1.Controls.Add(DELETE_BUTTON);
            panel1.Controls.Add(EDIT_BUTTON);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emp_id);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(position_dropdown);
            panel1.Controls.Add(emp_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 3;
            // 
            // emp_address
            // 
            emp_address.Location = new Point(703, 212);
            emp_address.Margin = new Padding(3, 4, 3, 4);
            emp_address.Name = "emp_address";
            emp_address.Size = new Size(235, 27);
            emp_address.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(570, 210);
            label6.Name = "label6";
            label6.Size = new Size(129, 29);
            label6.TabIndex = 20;
            label6.Text = "ADDRESS";
            // 
            // emp_contact
            // 
            emp_contact.Location = new Point(703, 144);
            emp_contact.Margin = new Padding(3, 4, 3, 4);
            emp_contact.Name = "emp_contact";
            emp_contact.Size = new Size(235, 27);
            emp_contact.TabIndex = 19;
            // 
            // emp_cnic
            // 
            emp_cnic.Location = new Point(158, 212);
            emp_cnic.Margin = new Padding(3, 4, 3, 4);
            emp_cnic.Name = "emp_cnic";
            emp_cnic.Size = new Size(235, 27);
            emp_cnic.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(17, 212);
            label3.Name = "label3";
            label3.Size = new Size(71, 29);
            label3.TabIndex = 17;
            label3.Text = "CNIC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(570, 142);
            label1.Name = "label1";
            label1.Size = new Size(127, 29);
            label1.TabIndex = 16;
            label1.Text = "CONTACT";
            // 
            // employee_dataGridView
            // 
            employee_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            employee_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employee_dataGridView.Location = new Point(23, 433);
            employee_dataGridView.Margin = new Padding(3, 4, 3, 4);
            employee_dataGridView.Name = "employee_dataGridView";
            employee_dataGridView.RowHeadersWidth = 51;
            employee_dataGridView.Size = new Size(1160, 284);
            employee_dataGridView.TabIndex = 14;
            // 
            // DELETE_BUTTON
            // 
            DELETE_BUTTON.AutoSize = true;
            DELETE_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            DELETE_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            DELETE_BUTTON.FlatAppearance.BorderSize = 0;
            DELETE_BUTTON.FlatStyle = FlatStyle.Flat;
            DELETE_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DELETE_BUTTON.ForeColor = Color.White;
            DELETE_BUTTON.Location = new Point(614, 336);
            DELETE_BUTTON.Margin = new Padding(3, 4, 3, 4);
            DELETE_BUTTON.Name = "DELETE_BUTTON";
            DELETE_BUTTON.Size = new Size(163, 60);
            DELETE_BUTTON.TabIndex = 12;
            DELETE_BUTTON.Text = "DELETE";
            DELETE_BUTTON.UseVisualStyleBackColor = false;
            DELETE_BUTTON.Click += DELETE_BUTTON_Click;
            // 
            // EDIT_BUTTON
            // 
            EDIT_BUTTON.AutoSize = true;
            EDIT_BUTTON.BackColor = Color.FromArgb(255, 136, 183);
            EDIT_BUTTON.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            EDIT_BUTTON.FlatAppearance.BorderSize = 0;
            EDIT_BUTTON.FlatStyle = FlatStyle.Flat;
            EDIT_BUTTON.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EDIT_BUTTON.ForeColor = Color.White;
            EDIT_BUTTON.Location = new Point(490, 336);
            EDIT_BUTTON.Margin = new Padding(3, 4, 3, 4);
            EDIT_BUTTON.Name = "EDIT_BUTTON";
            EDIT_BUTTON.Size = new Size(117, 60);
            EDIT_BUTTON.TabIndex = 11;
            EDIT_BUTTON.Text = "SAVE";
            EDIT_BUTTON.UseVisualStyleBackColor = false;
            EDIT_BUTTON.Click += EDIT_BUTTON_Click;
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
            ADD_BUTTON.Location = new Point(367, 336);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(117, 60);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(17, 142);
            label5.Name = "label5";
            label5.Size = new Size(127, 29);
            label5.TabIndex = 9;
            label5.Text = "POSITION";
            // 
            // emp_id
            // 
            emp_id.Location = new Point(703, 58);
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
            label4.Location = new Point(570, 56);
            label4.Name = "label4";
            label4.Size = new Size(37, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // position_dropdown
            // 
            position_dropdown.FormattingEnabled = true;
            position_dropdown.Location = new Point(158, 142);
            position_dropdown.Margin = new Padding(3, 4, 3, 4);
            position_dropdown.Name = "position_dropdown";
            position_dropdown.Size = new Size(235, 28);
            position_dropdown.TabIndex = 6;
            position_dropdown.Text = "SELECT";
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
            label2.Location = new Point(17, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // owner_employee_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "owner_employee_data";
            Text = "owner_employee_data";
            Load += owner_employee_data_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employee_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView employee_dataGridView;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private Button ADD_BUTTON;
        private Label label5;
        private TextBox emp_id;
        private Label label4;
        private ComboBox position_dropdown;
        private TextBox emp_name;
        private Label label2;
        private TextBox emp_cnic;
        private Label label3;
        private TextBox emp_contact;
        private Label label6;
        private TextBox emp_address;
    }
}