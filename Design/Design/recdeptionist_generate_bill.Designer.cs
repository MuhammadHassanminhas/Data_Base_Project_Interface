namespace Design
{
    partial class recdeptionist_generate_bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recdeptionist_generate_bill));
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            total_price = new TextBox();
            label5 = new Label();
            tip = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ADD_BUTTON = new Button();
            contact = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label2 = new Label();
            generate_bill = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(total_price);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tip);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 721);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 136, 183);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 136, 183);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(111, 524);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(233, 60);
            button1.TabIndex = 27;
            button1.Text = "GENERATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 339);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 28);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "SELECT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 136, 183);
            label6.Location = new Point(21, 339);
            label6.Name = "label6";
            label6.Size = new Size(235, 29);
            label6.TabIndex = 25;
            label6.Text = "TYPE OF PAYMENT";
            // 
            // total_price
            // 
            total_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_price.Location = new Point(198, 218);
            total_price.Margin = new Padding(3, 4, 3, 4);
            total_price.Name = "total_price";
            total_price.Size = new Size(235, 34);
            total_price.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(21, 223);
            label5.Name = "label5";
            label5.Size = new Size(171, 29);
            label5.TabIndex = 23;
            label5.Text = "TOTAL PRICE";
            // 
            // tip
            // 
            tip.Location = new Point(143, 127);
            tip.Margin = new Padding(3, 4, 3, 4);
            tip.Name = "tip";
            tip.Size = new Size(235, 27);
            tip.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(46, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 29);
            label3.TabIndex = 21;
            label3.Text = "TIP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(469, 127);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 20;
            label1.Text = "RECORDS";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(253, 210, 227);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(469, 173);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 548);
            dataGridView1.TabIndex = 19;
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
            ADD_BUTTON.Location = new Point(1002, 21);
            ADD_BUTTON.Margin = new Padding(3, 4, 3, 4);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(171, 60);
            ADD_BUTTON.TabIndex = 13;
            ADD_BUTTON.Text = "SEARCH";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            ADD_BUTTON.Click += ADD_BUTTON_Click;
            // 
            // contact
            // 
            contact.Location = new Point(702, 31);
            contact.Margin = new Padding(3, 4, 3, 4);
            contact.Name = "contact";
            contact.Size = new Size(235, 27);
            contact.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(457, 32);
            label4.Name = "label4";
            label4.Size = new Size(239, 29);
            label4.TabIndex = 11;
            label4.Text = "CONTACT NUMBER";
            // 
            // name
            // 
            name.Location = new Point(143, 31);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(235, 27);
            name.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(46, 32);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 9;
            label2.Text = "NAME";
            // 
            // generate_bill
            // 
            generate_bill.PrintPage += generate_bill_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // recdeptionist_generate_bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1253, 784);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "recdeptionist_generate_bill";
            Text = "recdeptionist_generate_bill";
            Load += recdeptionist_generate_bill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox contact;
        private Label label4;
        private TextBox name;
        private Label label2;
        private Button ADD_BUTTON;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox tip;
        private Label label3;
        private TextBox total_price;
        private Label label5;
        private Label label6;
        private Button button1;
        private ComboBox comboBox1;
        private System.Drawing.Printing.PrintDocument generate_bill;
        private PrintDialog printDialog1;
    }
}