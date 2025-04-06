namespace Design
{
    partial class stock_owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_owner));
            panel1 = new Panel();
            STOCK_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            stock_name = new TextBox();
            label2 = new Label();
            stock_ID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)STOCK_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(STOCK_dataGridView);
            panel1.Controls.Add(DELETE_BUTTON);
            panel1.Controls.Add(EDIT_BUTTON);
            panel1.Controls.Add(ADD_BUTTON);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(stock_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(stock_ID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 541);
            panel1.TabIndex = 0;
            // 
            // STOCK_dataGridView
            // 
            STOCK_dataGridView.BackgroundColor = Color.FromArgb(253, 210, 227);
            STOCK_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            STOCK_dataGridView.Location = new Point(408, 26);
            STOCK_dataGridView.Name = "STOCK_dataGridView";
            STOCK_dataGridView.Size = new Size(627, 494);
            STOCK_dataGridView.TabIndex = 14;
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
            DELETE_BUTTON.Location = new Point(231, 400);
            DELETE_BUTTON.Name = "DELETE_BUTTON";
            DELETE_BUTTON.Size = new Size(114, 37);
            DELETE_BUTTON.TabIndex = 12;
            DELETE_BUTTON.Text = "DELETE";
            DELETE_BUTTON.UseVisualStyleBackColor = false;
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
            EDIT_BUTTON.Location = new Point(123, 400);
            EDIT_BUTTON.Name = "EDIT_BUTTON";
            EDIT_BUTTON.Size = new Size(102, 37);
            EDIT_BUTTON.TabIndex = 11;
            EDIT_BUTTON.Text = "EDIT";
            EDIT_BUTTON.UseVisualStyleBackColor = false;
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
            ADD_BUTTON.Location = new Point(15, 400);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(102, 37);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(15, 229);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 7;
            label4.Text = "PRICE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 136, 183);
            label3.Location = new Point(15, 186);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 4;
            label3.Text = "QUANTITY";
            // 
            // stock_name
            // 
            stock_name.Location = new Point(138, 143);
            stock_name.Name = "stock_name";
            stock_name.Size = new Size(206, 23);
            stock_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 136, 183);
            label2.Location = new Point(15, 143);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 2;
            label2.Text = "NAME";
            // 
            // stock_ID
            // 
            stock_ID.Location = new Point(138, 99);
            stock_ID.Name = "stock_ID";
            stock_ID.Size = new Size(206, 23);
            stock_ID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 136, 183);
            label1.Location = new Point(15, 100);
            label1.Name = "label1";
            label1.Size = new Size(29, 22);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // stock_owner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1096, 588);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "stock_owner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "stock_owner";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)STOCK_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox stock_ID;
        private TextBox stock_name;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Button ADD_BUTTON;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private DataGridView STOCK_dataGridView;
    }
}