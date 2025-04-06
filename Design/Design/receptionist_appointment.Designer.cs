namespace Design
{
    partial class receptionist_appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receptionist_appointment));
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ADD_BUTTON = new Button();
            label5 = new Label();
            service_price = new TextBox();
            label4 = new Label();
            service_name = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(service_price);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 541);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(537, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 16;
            label1.Text = "SERVICE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(700, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "SELECT";
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
            ADD_BUTTON.Location = new Point(410, 252);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(235, 37);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(15, 113);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 9;
            label5.Text = "DATE/TIME";
            // 
            // service_price
            // 
            service_price.Location = new Point(700, 48);
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
            label4.Size = new Size(192, 22);
            label4.TabIndex = 7;
            label4.Text = "CONTACT NUMBER";
            // 
            // service_name
            // 
            service_name.Location = new Point(174, 48);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(253, 210, 227);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1049, 205);
            dataGridView1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(15, 175);
            label3.Name = "label3";
            label3.Size = new Size(143, 22);
            label3.TabIndex = 19;
            label3.Text = "EMPLOYEE ID";
            // 
            // receptionist_appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1096, 588);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "receptionist_appointment";
            Text = "receptionist_appointment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Button ADD_BUTTON;
        private Label label5;
        private TextBox service_price;
        private Label label4;
        private TextBox service_name;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label3;
    }
}