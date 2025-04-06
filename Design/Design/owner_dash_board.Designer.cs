namespace Design
{
    partial class owner_dash_board
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(owner_dash_board));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            owner_menu = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            total_earning = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            owner_stock = new Button();
            panel11 = new Panel();
            panel12 = new Panel();
            services = new Button();
            employee_menu_container = new FlowLayoutPanel();
            panel7 = new Panel();
            panel8 = new Panel();
            employee_button = new Button();
            panel15 = new Panel();
            panel16 = new Panel();
            paycheck_button = new Button();
            panel17 = new Panel();
            panel18 = new Panel();
            attendence_button = new Button();
            records_menu_container = new FlowLayoutPanel();
            panel9 = new Panel();
            panel10 = new Panel();
            records_button = new Button();
            panel20 = new Panel();
            panel21 = new Panel();
            employee_record_button = new Button();
            panel22 = new Panel();
            panel23 = new Panel();
            client_record_button = new Button();
            panel13 = new Panel();
            panel14 = new Panel();
            owner_logout = new Button();
            employee_menu_timer = new System.Windows.Forms.Timer(components);
            record_menu_timer = new System.Windows.Forms.Timer(components);
            main_panel = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            employee_menu_container.SuspendLayout();
            panel7.SuspendLayout();
            panel15.SuspendLayout();
            panel17.SuspendLayout();
            records_menu_container.SuspendLayout();
            panel9.SuspendLayout();
            panel20.SuspendLayout();
            panel22.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(232, 164, 191);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(employee_menu_container);
            flowLayoutPanel1.Controls.Add(records_menu_container);
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(263, 666);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(253, 210, 227);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(owner_menu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 43);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(9, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(32, 30);
            panel2.TabIndex = 2;
            // 
            // owner_menu
            // 
            owner_menu.BackColor = Color.Transparent;
            owner_menu.FlatAppearance.BorderSize = 0;
            owner_menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            owner_menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            owner_menu.FlatStyle = FlatStyle.Flat;
            owner_menu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner_menu.ForeColor = Color.Black;
            owner_menu.Location = new Point(47, 2);
            owner_menu.Name = "owner_menu";
            owner_menu.Size = new Size(184, 37);
            owner_menu.TabIndex = 2;
            owner_menu.Text = "MENU";
            owner_menu.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(253, 210, 227);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(total_earning);
            panel3.Location = new Point(3, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(246, 43);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(9, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(32, 30);
            panel4.TabIndex = 2;
            // 
            // total_earning
            // 
            total_earning.BackColor = Color.Transparent;
            total_earning.FlatAppearance.BorderSize = 0;
            total_earning.FlatAppearance.MouseDownBackColor = Color.Transparent;
            total_earning.FlatAppearance.MouseOverBackColor = Color.Transparent;
            total_earning.FlatStyle = FlatStyle.Flat;
            total_earning.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_earning.ForeColor = Color.Black;
            total_earning.Location = new Point(47, 3);
            total_earning.Name = "total_earning";
            total_earning.Size = new Size(184, 37);
            total_earning.TabIndex = 2;
            total_earning.Text = "TOTAL EARNING";
            total_earning.UseVisualStyleBackColor = false;
            total_earning.Click += total_earning_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(253, 210, 227);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(owner_stock);
            panel5.Location = new Point(3, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 43);
            panel5.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(9, 9);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 30);
            panel6.TabIndex = 2;
            // 
            // owner_stock
            // 
            owner_stock.BackColor = Color.Transparent;
            owner_stock.FlatAppearance.BorderSize = 0;
            owner_stock.FlatAppearance.MouseDownBackColor = Color.Transparent;
            owner_stock.FlatAppearance.MouseOverBackColor = Color.Transparent;
            owner_stock.FlatStyle = FlatStyle.Flat;
            owner_stock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner_stock.ForeColor = Color.Black;
            owner_stock.Location = new Point(47, 2);
            owner_stock.Name = "owner_stock";
            owner_stock.Size = new Size(184, 37);
            owner_stock.TabIndex = 2;
            owner_stock.Text = "STOCK";
            owner_stock.UseVisualStyleBackColor = false;
            owner_stock.Click += owner_stock_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(253, 210, 227);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(services);
            panel11.Location = new Point(3, 150);
            panel11.Name = "panel11";
            panel11.Size = new Size(246, 43);
            panel11.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.BackgroundImage = (Image)resources.GetObject("panel12.BackgroundImage");
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.Location = new Point(9, 9);
            panel12.Name = "panel12";
            panel12.Size = new Size(32, 30);
            panel12.TabIndex = 2;
            // 
            // services
            // 
            services.BackColor = Color.Transparent;
            services.FlatAppearance.BorderSize = 0;
            services.FlatAppearance.MouseDownBackColor = Color.Transparent;
            services.FlatAppearance.MouseOverBackColor = Color.Transparent;
            services.FlatStyle = FlatStyle.Flat;
            services.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            services.ForeColor = Color.Black;
            services.Location = new Point(47, 3);
            services.Name = "services";
            services.Size = new Size(184, 37);
            services.TabIndex = 2;
            services.Text = "SERVICES";
            services.UseVisualStyleBackColor = false;
            services.Click += services_Click;
            // 
            // employee_menu_container
            // 
            employee_menu_container.BackColor = Color.FromArgb(253, 210, 227);
            employee_menu_container.Controls.Add(panel7);
            employee_menu_container.Controls.Add(panel15);
            employee_menu_container.Controls.Add(panel17);
            employee_menu_container.Location = new Point(3, 199);
            employee_menu_container.Name = "employee_menu_container";
            employee_menu_container.Size = new Size(246, 51);
            employee_menu_container.TabIndex = 2;
            employee_menu_container.Paint += employee_menu_container_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(253, 210, 227);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(employee_button);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(228, 43);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(9, 9);
            panel8.Name = "panel8";
            panel8.Size = new Size(32, 30);
            panel8.TabIndex = 2;
            // 
            // employee_button
            // 
            employee_button.BackColor = Color.Transparent;
            employee_button.FlatAppearance.BorderSize = 0;
            employee_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            employee_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            employee_button.FlatStyle = FlatStyle.Flat;
            employee_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_button.ForeColor = Color.Black;
            employee_button.Location = new Point(47, 2);
            employee_button.Name = "employee_button";
            employee_button.Size = new Size(163, 37);
            employee_button.TabIndex = 2;
            employee_button.Text = "EMPLOYEE";
            employee_button.UseVisualStyleBackColor = false;
            employee_button.Click += employee_button_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(232, 164, 191);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(paycheck_button);
            panel15.Location = new Point(3, 52);
            panel15.Name = "panel15";
            panel15.Size = new Size(231, 43);
            panel15.TabIndex = 4;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Transparent;
            panel16.BackgroundImage = (Image)resources.GetObject("panel16.BackgroundImage");
            panel16.BackgroundImageLayout = ImageLayout.Zoom;
            panel16.Location = new Point(9, 9);
            panel16.Name = "panel16";
            panel16.Size = new Size(32, 30);
            panel16.TabIndex = 2;
            // 
            // paycheck_button
            // 
            paycheck_button.BackColor = Color.Transparent;
            paycheck_button.FlatAppearance.BorderSize = 0;
            paycheck_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            paycheck_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            paycheck_button.FlatStyle = FlatStyle.Flat;
            paycheck_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paycheck_button.ForeColor = Color.Black;
            paycheck_button.Location = new Point(47, 2);
            paycheck_button.Name = "paycheck_button";
            paycheck_button.Size = new Size(169, 37);
            paycheck_button.TabIndex = 2;
            paycheck_button.Text = "PAYCHECK";
            paycheck_button.UseVisualStyleBackColor = false;
            paycheck_button.Click += paycheck_button_Click;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(232, 164, 191);
            panel17.Controls.Add(panel18);
            panel17.Controls.Add(attendence_button);
            panel17.Location = new Point(3, 101);
            panel17.Name = "panel17";
            panel17.Size = new Size(231, 43);
            panel17.TabIndex = 4;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Transparent;
            panel18.BackgroundImage = (Image)resources.GetObject("panel18.BackgroundImage");
            panel18.BackgroundImageLayout = ImageLayout.Zoom;
            panel18.Location = new Point(9, 9);
            panel18.Name = "panel18";
            panel18.Size = new Size(32, 30);
            panel18.TabIndex = 2;
            // 
            // attendence_button
            // 
            attendence_button.BackColor = Color.Transparent;
            attendence_button.FlatAppearance.BorderSize = 0;
            attendence_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            attendence_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            attendence_button.FlatStyle = FlatStyle.Flat;
            attendence_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendence_button.ForeColor = Color.Black;
            attendence_button.Location = new Point(47, 2);
            attendence_button.Name = "attendence_button";
            attendence_button.Size = new Size(169, 37);
            attendence_button.TabIndex = 2;
            attendence_button.Text = "ATTENDENCE";
            attendence_button.UseVisualStyleBackColor = false;
            attendence_button.Click += attendence_button_Click;
            // 
            // records_menu_container
            // 
            records_menu_container.BackColor = Color.FromArgb(253, 210, 227);
            records_menu_container.Controls.Add(panel9);
            records_menu_container.Controls.Add(panel20);
            records_menu_container.Controls.Add(panel22);
            records_menu_container.Location = new Point(3, 256);
            records_menu_container.Name = "records_menu_container";
            records_menu_container.Size = new Size(246, 51);
            records_menu_container.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(253, 210, 227);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(records_button);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(231, 43);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.Location = new Point(9, 9);
            panel10.Name = "panel10";
            panel10.Size = new Size(32, 30);
            panel10.TabIndex = 2;
            // 
            // records_button
            // 
            records_button.BackColor = Color.Transparent;
            records_button.FlatAppearance.BorderSize = 0;
            records_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            records_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            records_button.FlatStyle = FlatStyle.Flat;
            records_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            records_button.ForeColor = Color.Black;
            records_button.Location = new Point(47, 2);
            records_button.Name = "records_button";
            records_button.Size = new Size(181, 37);
            records_button.TabIndex = 2;
            records_button.Text = "RECORDS";
            records_button.UseVisualStyleBackColor = false;
            records_button.Click += records_button_Click;
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(232, 164, 191);
            panel20.Controls.Add(panel21);
            panel20.Controls.Add(employee_record_button);
            panel20.Location = new Point(3, 52);
            panel20.Name = "panel20";
            panel20.Size = new Size(231, 43);
            panel20.TabIndex = 5;
            // 
            // panel21
            // 
            panel21.BackColor = Color.Transparent;
            panel21.BackgroundImage = (Image)resources.GetObject("panel21.BackgroundImage");
            panel21.BackgroundImageLayout = ImageLayout.Zoom;
            panel21.Location = new Point(9, 9);
            panel21.Name = "panel21";
            panel21.Size = new Size(32, 30);
            panel21.TabIndex = 2;
            // 
            // employee_record_button
            // 
            employee_record_button.BackColor = Color.Transparent;
            employee_record_button.FlatAppearance.BorderSize = 0;
            employee_record_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            employee_record_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            employee_record_button.FlatStyle = FlatStyle.Flat;
            employee_record_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_record_button.ForeColor = Color.Black;
            employee_record_button.Location = new Point(47, 2);
            employee_record_button.Name = "employee_record_button";
            employee_record_button.Size = new Size(169, 37);
            employee_record_button.TabIndex = 2;
            employee_record_button.Text = "EMPLOYEE";
            employee_record_button.UseVisualStyleBackColor = false;
            employee_record_button.Click += employee_record_button_Click;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(232, 164, 191);
            panel22.Controls.Add(panel23);
            panel22.Controls.Add(client_record_button);
            panel22.Location = new Point(3, 101);
            panel22.Name = "panel22";
            panel22.Size = new Size(231, 43);
            panel22.TabIndex = 5;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Transparent;
            panel23.BackgroundImage = (Image)resources.GetObject("panel23.BackgroundImage");
            panel23.BackgroundImageLayout = ImageLayout.Zoom;
            panel23.Location = new Point(9, 9);
            panel23.Name = "panel23";
            panel23.Size = new Size(32, 30);
            panel23.TabIndex = 2;
            // 
            // client_record_button
            // 
            client_record_button.BackColor = Color.Transparent;
            client_record_button.FlatAppearance.BorderSize = 0;
            client_record_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            client_record_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            client_record_button.FlatStyle = FlatStyle.Flat;
            client_record_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_record_button.ForeColor = Color.Black;
            client_record_button.Location = new Point(47, 2);
            client_record_button.Name = "client_record_button";
            client_record_button.Size = new Size(163, 37);
            client_record_button.TabIndex = 2;
            client_record_button.Text = "CLIENT";
            client_record_button.UseVisualStyleBackColor = false;
            client_record_button.Click += client_record_button_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(253, 210, 227);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(owner_logout);
            panel13.Location = new Point(3, 313);
            panel13.Name = "panel13";
            panel13.Size = new Size(246, 43);
            panel13.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Transparent;
            panel14.BackgroundImage = (Image)resources.GetObject("panel14.BackgroundImage");
            panel14.BackgroundImageLayout = ImageLayout.Zoom;
            panel14.Location = new Point(9, 9);
            panel14.Name = "panel14";
            panel14.Size = new Size(32, 30);
            panel14.TabIndex = 2;
            // 
            // owner_logout
            // 
            owner_logout.BackColor = Color.Transparent;
            owner_logout.FlatAppearance.BorderSize = 0;
            owner_logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            owner_logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            owner_logout.FlatStyle = FlatStyle.Flat;
            owner_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner_logout.ForeColor = Color.Black;
            owner_logout.Location = new Point(47, 3);
            owner_logout.Name = "owner_logout";
            owner_logout.Size = new Size(184, 37);
            owner_logout.TabIndex = 2;
            owner_logout.Text = "LOGOUT";
            owner_logout.UseVisualStyleBackColor = false;
            // 
            // employee_menu_timer
            // 
            employee_menu_timer.Tick += employee_menu_timer_Tick;
            // 
            // record_menu_timer
            // 
            record_menu_timer.Tick += record_menu_timer_Tick;
            // 
            // main_panel
            // 
            main_panel.BackgroundImage = (Image)resources.GetObject("main_panel.BackgroundImage");
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(263, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1128, 666);
            main_panel.TabIndex = 2;
            // 
            // owner_dash_board
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1391, 666);
            Controls.Add(main_panel);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.FromArgb(255, 136, 183);
            Name = "owner_dash_board";
            Text = "owner_dash_board";
            Load += owner_dash_board_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel11.ResumeLayout(false);
            employee_menu_container.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel17.ResumeLayout(false);
            records_menu_container.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button owner_menu;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button total_earning;
        private Panel panel5;
        private Panel panel6;
        private Button owner_stock;
        private Panel panel7;
        private Panel panel8;
        private Button employee_button;
        private Panel panel9;
        private Panel panel10;
        private Button records_button;
        private Panel panel11;
        private Panel panel12;
        private Button services;
        private Panel panel13;
        private Panel panel14;
        private Button owner_logout;
        private FlowLayoutPanel employee_menu_container;
        private Panel panel15;
        private Panel panel16;
        private Button paycheck_button;
        private Panel panel17;
        private Panel panel18;
        private Button attendence_button;
        private System.Windows.Forms.Timer employee_menu_timer;
        private Panel panel22;
        private Panel panel23;
        private Button client_record_button;
        private Panel panel20;
        private Panel panel21;
        private Button employee_record_button;
        private FlowLayoutPanel records_menu_container;
        private System.Windows.Forms.Timer record_menu_timer;
        private Panel main_panel;
    }
}