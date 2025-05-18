namespace Design
{
    partial class employee_dash_board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_dash_board));
            panel1 = new Panel();
            paycheck = new Label();
            tips = new Label();
            address = new Label();
            contact = new Label();
            cnic = new Label();
            ID = new Label();
            emp_Name = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            employee_logout = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            attendence_dataGridView = new DataGridView();
            ADD_BUTTON = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(paycheck);
            panel1.Controls.Add(tips);
            panel1.Controls.Add(address);
            panel1.Controls.Add(contact);
            panel1.Controls.Add(cnic);
            panel1.Controls.Add(ID);
            panel1.Controls.Add(emp_Name);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(attendence_dataGridView);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1542, 839);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // paycheck
            // 
            paycheck.AutoSize = true;
            paycheck.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paycheck.Location = new Point(870, 218);
            paycheck.Name = "paycheck";
            paycheck.Size = new Size(0, 31);
            paycheck.TabIndex = 35;
            // 
            // tips
            // 
            tips.AutoSize = true;
            tips.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tips.Location = new Point(262, 218);
            tips.Name = "tips";
            tips.Size = new Size(0, 31);
            tips.TabIndex = 34;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(715, 149);
            address.Name = "address";
            address.Size = new Size(0, 31);
            address.TabIndex = 33;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contact.Location = new Point(280, 149);
            contact.Name = "contact";
            contact.Size = new Size(0, 31);
            contact.TabIndex = 32;
            // 
            // cnic
            // 
            cnic.AutoSize = true;
            cnic.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cnic.Location = new Point(1207, 54);
            cnic.Name = "cnic";
            cnic.Size = new Size(0, 31);
            cnic.TabIndex = 31;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.Location = new Point(633, 54);
            ID.Name = "ID";
            ID.Size = new Size(0, 31);
            ID.TabIndex = 30;
            // 
            // emp_Name
            // 
            emp_Name.AutoSize = true;
            emp_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_Name.Location = new Point(124, 54);
            emp_Name.Name = "emp_Name";
            emp_Name.Size = new Size(0, 31);
            emp_Name.TabIndex = 29;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(253, 210, 227);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(employee_logout);
            panel13.Location = new Point(1247, 763);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(281, 57);
            panel13.TabIndex = 28;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Transparent;
            panel14.BackgroundImage = (Image)resources.GetObject("panel14.BackgroundImage");
            panel14.BackgroundImageLayout = ImageLayout.Zoom;
            panel14.Location = new Point(10, 12);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(37, 40);
            panel14.TabIndex = 2;
            // 
            // employee_logout
            // 
            employee_logout.BackColor = Color.Transparent;
            employee_logout.FlatAppearance.BorderSize = 0;
            employee_logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            employee_logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            employee_logout.FlatStyle = FlatStyle.Flat;
            employee_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_logout.ForeColor = Color.Black;
            employee_logout.Location = new Point(54, 4);
            employee_logout.Margin = new Padding(3, 4, 3, 4);
            employee_logout.Name = "employee_logout";
            employee_logout.Size = new Size(210, 49);
            employee_logout.TabIndex = 2;
            employee_logout.Text = "LOGOUT";
            employee_logout.UseVisualStyleBackColor = false;
            employee_logout.Click += employee_logout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 136, 183);
            label9.Location = new Point(571, 220);
            label9.Name = "label9";
            label9.Size = new Size(293, 29);
            label9.TabIndex = 26;
            label9.Text = "PAYCHECK PER-MONTH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 136, 183);
            label8.Location = new Point(23, 220);
            label8.Name = "label8";
            label8.Size = new Size(211, 29);
            label8.TabIndex = 24;
            label8.Text = "TIPS PERMONTH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 136, 183);
            label7.Location = new Point(1130, 56);
            label7.Name = "label7";
            label7.Size = new Size(71, 29);
            label7.TabIndex = 20;
            label7.Text = "CNIC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(617, 325);
            label6.Name = "label6";
            label6.Size = new Size(325, 32);
            label6.TabIndex = 19;
            label6.Text = "ATTENDANCE REPORT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(150, 381);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(23, 379);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 17;
            label3.Text = "MONTH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(571, 151);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 16;
            label1.Text = "ADDRESS";
            // 
            // attendence_dataGridView
            // 
            attendence_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            attendence_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendence_dataGridView.Location = new Point(13, 433);
            attendence_dataGridView.Margin = new Padding(3, 4, 3, 4);
            attendence_dataGridView.Name = "attendence_dataGridView";
            attendence_dataGridView.RowHeadersWidth = 51;
            attendence_dataGridView.Size = new Size(1515, 284);
            attendence_dataGridView.TabIndex = 14;
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
            ADD_BUTTON.Location = new Point(1322, 361);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(171, 60);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(23, 151);
            label5.Name = "label5";
            label5.Size = new Size(239, 29);
            label5.TabIndex = 9;
            label5.Text = "CONTACT NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(571, 56);
            label4.Name = "label4";
            label4.Size = new Size(37, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // employee_dash_board
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1590, 888);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "employee_dash_board";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee_dash_board";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label1;
        private DataGridView attendence_dataGridView;
        private Button ADD_BUTTON;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Panel panel13;
        private Panel panel14;
        private Button employee_logout;
        private Label cnic;
        private Label ID;
        private Label emp_Name;
        private Label contact;
        private Label paycheck;
        private Label tips;
        private Label address;
    }
}