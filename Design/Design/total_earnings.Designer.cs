namespace Design
{
    partial class total_earnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(total_earnings));
            panel1 = new Panel();
            label4 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            service_name = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 314);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(607, 230);
            label4.Name = "label4";
            label4.Size = new Size(131, 22);
            label4.TabIndex = 25;
            label4.Text = "NET INCOME";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(820, 219);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(206, 40);
            textBox9.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 136, 183);
            label8.Location = new Point(59, 30);
            label8.Name = "label8";
            label8.Size = new Size(81, 22);
            label8.TabIndex = 18;
            label8.Text = "MONTH";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(842, 125);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(206, 23);
            textBox8.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 136, 183);
            label9.Location = new Point(617, 126);
            label9.Name = "label9";
            label9.Size = new Size(219, 22);
            label9.TabIndex = 16;
            label9.Text = "EMPLOYEE SALARIES";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(319, 218);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(47, 215);
            label6.Name = "label6";
            label6.Size = new Size(190, 22);
            label6.TabIndex = 10;
            label6.Text = "SERVICE REVENUE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(709, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(626, 34);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 8;
            label3.Text = "TIPS";
            // 
            // service_name
            // 
            service_name.Location = new Point(393, 121);
            service_name.Name = "service_name";
            service_name.Size = new Size(206, 23);
            service_name.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(47, 118);
            label2.Name = "label2";
            label2.Size = new Size(297, 22);
            label2.TabIndex = 4;
            label2.Text = "TOTAL SERVICES PER MONTH";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // total_earnings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1096, 588);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "total_earnings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox2;
        private Label label3;
        private TextBox service_name;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}