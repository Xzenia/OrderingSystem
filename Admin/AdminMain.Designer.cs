namespace Admin
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.manageCustomerBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.pnlbtm = new System.Windows.Forms.Panel();
            this.SalesLogBtn = new System.Windows.Forms.Button();
            this.SalesReportBtn = new System.Windows.Forms.Button();
            this.orderHistoryBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.manageProductsBtn = new System.Windows.Forms.Button();
            this.lblLogged = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenRep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransRep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlbtm.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.panel3.BackgroundImage = global::Admin.Properties.Resources.coffee2;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnlbtm);
            this.panel3.Controls.Add(this.lblLogged);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.mainMenu);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 530);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(355, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 439);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.manageCustomerBtn);
            this.panel2.Controls.Add(this.addUserBtn);
            this.panel2.Location = new System.Drawing.Point(846, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 446);
            this.panel2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SaddleBrown;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::Admin.Properties.Resources.ic_perm_identity_white_24dp_2x1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(10, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 64);
            this.button4.TabIndex = 0;
            this.button4.Text = "Change Account Details";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.accountManagement);
            // 
            // manageCustomerBtn
            // 
            this.manageCustomerBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.manageCustomerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.manageCustomerBtn.FlatAppearance.BorderSize = 2;
            this.manageCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCustomerBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageCustomerBtn.Image")));
            this.manageCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageCustomerBtn.Location = new System.Drawing.Point(10, 109);
            this.manageCustomerBtn.Name = "manageCustomerBtn";
            this.manageCustomerBtn.Size = new System.Drawing.Size(270, 63);
            this.manageCustomerBtn.TabIndex = 0;
            this.manageCustomerBtn.Text = "Manage Customers";
            this.manageCustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageCustomerBtn.UseVisualStyleBackColor = false;
            this.manageCustomerBtn.Click += new System.EventHandler(this.accountManagement);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.addUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.addUserBtn.FlatAppearance.BorderSize = 2;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("addUserBtn.Image")));
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUserBtn.Location = new System.Drawing.Point(10, 22);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(270, 63);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Add a New User";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.accountManagement);
            // 
            // pnlbtm
            // 
            this.pnlbtm.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlbtm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbtm.Controls.Add(this.SalesLogBtn);
            this.pnlbtm.Controls.Add(this.SalesReportBtn);
            this.pnlbtm.Controls.Add(this.orderHistoryBtn);
            this.pnlbtm.Controls.Add(this.addProductBtn);
            this.pnlbtm.Controls.Add(this.manageProductsBtn);
            this.pnlbtm.Location = new System.Drawing.Point(11, 46);
            this.pnlbtm.Name = "pnlbtm";
            this.pnlbtm.Size = new System.Drawing.Size(291, 379);
            this.pnlbtm.TabIndex = 9;
            // 
            // SalesLogBtn
            // 
            this.SalesLogBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.SalesLogBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.SalesLogBtn.FlatAppearance.BorderSize = 2;
            this.SalesLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesLogBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLogBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SalesLogBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesLogBtn.Image")));
            this.SalesLogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalesLogBtn.Location = new System.Drawing.Point(10, 22);
            this.SalesLogBtn.Name = "SalesLogBtn";
            this.SalesLogBtn.Size = new System.Drawing.Size(270, 63);
            this.SalesLogBtn.TabIndex = 0;
            this.SalesLogBtn.Text = "Show Sales Log";
            this.SalesLogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesLogBtn.UseVisualStyleBackColor = false;
            this.SalesLogBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // SalesReportBtn
            // 
            this.SalesReportBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.SalesReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.SalesReportBtn.FlatAppearance.BorderSize = 2;
            this.SalesReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesReportBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SalesReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesReportBtn.Image")));
            this.SalesReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalesReportBtn.Location = new System.Drawing.Point(10, 91);
            this.SalesReportBtn.Name = "SalesReportBtn";
            this.SalesReportBtn.Size = new System.Drawing.Size(270, 63);
            this.SalesReportBtn.TabIndex = 0;
            this.SalesReportBtn.Text = "Generate Sales Report";
            this.SalesReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesReportBtn.UseVisualStyleBackColor = false;
            this.SalesReportBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // orderHistoryBtn
            // 
            this.orderHistoryBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.orderHistoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.orderHistoryBtn.FlatAppearance.BorderSize = 2;
            this.orderHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.orderHistoryBtn.Image = global::Admin.Properties.Resources.ic_history_white_24dp_2x;
            this.orderHistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.orderHistoryBtn.Location = new System.Drawing.Point(10, 160);
            this.orderHistoryBtn.Name = "orderHistoryBtn";
            this.orderHistoryBtn.Size = new System.Drawing.Size(270, 64);
            this.orderHistoryBtn.TabIndex = 0;
            this.orderHistoryBtn.Text = "Order History";
            this.orderHistoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderHistoryBtn.UseVisualStyleBackColor = false;
            this.orderHistoryBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.addProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.addProductBtn.FlatAppearance.BorderSize = 2;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addProductBtn.Image = global::Admin.Properties.Resources.ic_add_shopping_cart_white_24dp_2x;
            this.addProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProductBtn.Location = new System.Drawing.Point(10, 230);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(270, 63);
            this.addProductBtn.TabIndex = 0;
            this.addProductBtn.Text = "Add a New Product";
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // manageProductsBtn
            // 
            this.manageProductsBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.manageProductsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.manageProductsBtn.FlatAppearance.BorderSize = 2;
            this.manageProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageProductsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageProductsBtn.Image = ((System.Drawing.Image)(resources.GetObject("manageProductsBtn.Image")));
            this.manageProductsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageProductsBtn.Location = new System.Drawing.Point(10, 299);
            this.manageProductsBtn.Name = "manageProductsBtn";
            this.manageProductsBtn.Size = new System.Drawing.Size(270, 63);
            this.manageProductsBtn.TabIndex = 0;
            this.manageProductsBtn.Text = "Manage Products";
            this.manageProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageProductsBtn.UseVisualStyleBackColor = false;
            this.manageProductsBtn.Click += new System.EventHandler(this.btnClick);
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLogged.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogged.Location = new System.Drawing.Point(831, 3);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(215, 21);
            this.lblLogged.TabIndex = 8;
            this.lblLogged.Text = "You are logged in as EugeneK";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Chocolate;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnMinimize.FlatAppearance.BorderSize = 2;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnMinimize.Location = new System.Drawing.Point(1046, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnExit.Location = new System.Drawing.Point(1086, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.menuUser,
            this.systemToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1143, 29);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenRep,
            this.mnuTransRep});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 25);
            this.mnuFile.Text = "File";
            // 
            // mnuGenRep
            // 
            this.mnuGenRep.Name = "mnuGenRep";
            this.mnuGenRep.Size = new System.Drawing.Size(278, 26);
            this.mnuGenRep.Text = "Generate Sales Report";
            // 
            // mnuTransRep
            // 
            this.mnuTransRep.Name = "mnuTransRep";
            this.mnuTransRep.Size = new System.Drawing.Size(278, 26);
            this.mnuTransRep.Text = "Generate Transaction Report";
            // 
            // menuUser
            // 
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut,
            this.mnuChangeDetails});
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(68, 25);
            this.menuUser.Text = "Admin";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(380, 26);
            this.mnuLogOut.Text = "Log out";
            // 
            // mnuChangeDetails
            // 
            this.mnuChangeDetails.Name = "mnuChangeDetails";
            this.mnuChangeDetails.Size = new System.Drawing.Size(380, 26);
            this.mnuChangeDetails.Text = "Change Details (Requires Admin Password)";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.systemToolStripMenuItem.Text = "Application";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(10, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage User Accounts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.accountManagement);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1148, 554);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain";
            this.Text = "AdminControl";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlbtm.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuGenRep;
        private System.Windows.Forms.ToolStripMenuItem mnuTransRep;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeDetails;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button orderHistoryBtn;
        private System.Windows.Forms.Button SalesLogBtn;
        private System.Windows.Forms.Button SalesReportBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Panel pnlbtm;
        private System.Windows.Forms.Button manageCustomerBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button manageProductsBtn;
        private System.Windows.Forms.Button button1;
    }
}