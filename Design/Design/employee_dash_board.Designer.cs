﻿namespace Design
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
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            attendence_dataGridView = new DataGridView();
            ADD_BUTTON = new Button();
            label5 = new Label();
            service_price = new TextBox();
            label4 = new Label();
            service_name = new TextBox();
            label2 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendence_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(attendence_dataGridView);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(service_price);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 629);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(20, 286);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 17;
            label3.Text = "MONTH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(502, 122);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 16;
            label1.Text = "ADDRESS";
            // 
            // attendence_dataGridView
            // 
            attendence_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            attendence_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendence_dataGridView.Location = new Point(11, 325);
            attendence_dataGridView.Name = "attendence_dataGridView";
            attendence_dataGridView.Size = new Size(1326, 213);
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
            ADD_BUTTON.Location = new Point(1157, 278);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(120, 37);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(15, 113);
            label5.Name = "label5";
            label5.Size = new Size(192, 22);
            label5.TabIndex = 9;
            label5.Text = "CONTACT NUMBER";
            // 
            // service_price
            // 
            service_price.Location = new Point(537, 42);
            service_price.Name = "service_price";
            service_price.Size = new Size(206, 23);
            service_price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(502, 45);
            label4.Name = "label4";
            label4.Size = new Size(29, 22);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // service_name
            // 
            service_name.Location = new Point(87, 41);
            service_name.Name = "service_name";
            service_name.Size = new Size(206, 23);
            service_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(554, 244);
            label6.Name = "label6";
            label6.Size = new Size(257, 24);
            label6.TabIndex = 19;
            label6.Text = "ATTENDENCDE REPORT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1051, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 136, 183);
            label7.Location = new Point(989, 46);
            label7.Name = "label7";
            label7.Size = new Size(56, 22);
            label7.TabIndex = 20;
            label7.Text = "CNIC";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(626, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(397, 23);
            textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 136, 183);
            label8.Location = new Point(15, 164);
            label8.Name = "label8";
            label8.Size = new Size(169, 22);
            label8.TabIndex = 24;
            label8.Text = "TIPS PERMONTH";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(743, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 136, 183);
            label9.Location = new Point(502, 165);
            label9.Name = "label9";
            label9.Size = new Size(235, 22);
            label9.TabIndex = 26;
            label9.Text = "PAYCHECK PER-MONTH";
            // 
            // employee_dash_board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(panel1);
            Name = "employee_dash_board";
            Text = "employee_dash_board";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
    }
}