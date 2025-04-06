namespace Design
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            panel1 = new Panel();
            STOCK_dataGridView = new DataGridView();
            DELETE_BUTTON = new Button();
            EDIT_BUTTON = new Button();
            ADD_BUTTON = new Button();
            label5 = new Label();
            service_price = new TextBox();
            label4 = new Label();
            service_category = new ComboBox();
            service_name = new TextBox();
            label2 = new Label();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(service_price);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(service_category);
            panel1.Controls.Add(service_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 541);
            panel1.TabIndex = 1;
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
            DELETE_BUTTON.Location = new Point(230, 290);
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
            EDIT_BUTTON.Location = new Point(122, 290);
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
            ADD_BUTTON.Location = new Point(14, 290);
            ADD_BUTTON.Name = "ADD_BUTTON";
            ADD_BUTTON.Size = new Size(102, 37);
            ADD_BUTTON.TabIndex = 10;
            ADD_BUTTON.Text = "ADD";
            ADD_BUTTON.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 136, 183);
            label5.Location = new Point(15, 232);
            label5.Name = "label5";
            label5.Size = new Size(117, 22);
            label5.TabIndex = 9;
            label5.Text = "CATEGORY";
            // 
            // service_price
            // 
            service_price.Location = new Point(139, 188);
            service_price.Name = "service_price";
            service_price.Size = new Size(206, 23);
            service_price.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 136, 183);
            label4.Location = new Point(15, 186);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 7;
            label4.Text = "PRICE";
            // 
            // service_category
            // 
            service_category.FormattingEnabled = true;
            service_category.Location = new Point(138, 235);
            service_category.Name = "service_category";
            service_category.Size = new Size(206, 23);
            service_category.TabIndex = 6;
            service_category.Text = "SELECT";
            // 
            // service_name
            // 
            service_name.Location = new Point(138, 143);
            service_name.Name = "service_name";
            service_name.Size = new Size(206, 23);
            service_name.TabIndex = 3;
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
            // services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1096, 588);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "services";
            Text = "services";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)STOCK_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView STOCK_dataGridView;
        private Button DELETE_BUTTON;
        private Button EDIT_BUTTON;
        private Button ADD_BUTTON;
        private Label label5;
        private TextBox service_price;
        private Label label4;
        private ComboBox service_category;
        private TextBox service_name;
        private Label label2;
    }
}