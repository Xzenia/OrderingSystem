namespace Admin
{
    partial class CustomerList
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
            this.customerListGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerBirthdayField = new System.Windows.Forms.DateTimePicker();
            this.customerEmailField = new System.Windows.Forms.MaskedTextBox();
            this.customerCellphoneNumberField = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.membershipTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerIdField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerListGridView
            // 
            this.customerListGridView.AllowUserToAddRows = false;
            this.customerListGridView.AllowUserToDeleteRows = false;
            this.customerListGridView.AllowUserToResizeRows = false;
            this.customerListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.customerListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.customerListGridView.Location = new System.Drawing.Point(12, 12);
            this.customerListGridView.MultiSelect = false;
            this.customerListGridView.Name = "customerListGridView";
            this.customerListGridView.ReadOnly = true;
            this.customerListGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.customerListGridView.Size = new System.Drawing.Size(750, 294);
            this.customerListGridView.TabIndex = 0;
            this.customerListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerListGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerPictureBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.customerBirthdayField);
            this.groupBox1.Controls.Add(this.customerEmailField);
            this.groupBox1.Controls.Add(this.customerCellphoneNumberField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.acceptBtn);
            this.groupBox1.Controls.Add(this.membershipTypeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerNameField);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // customerPictureBox
            // 
            this.customerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerPictureBox.Image = global::Admin.Properties.Resources.defaultImage;
            this.customerPictureBox.InitialImage = null;
            this.customerPictureBox.Location = new System.Drawing.Point(172, 38);
            this.customerPictureBox.Name = "customerPictureBox";
            this.customerPictureBox.Size = new System.Drawing.Size(144, 146);
            this.customerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerPictureBox.TabIndex = 26;
            this.customerPictureBox.TabStop = false;
            this.customerPictureBox.DoubleClick += new System.EventHandler(this.customerPictureBox_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Product Picture: ";
            // 
            // customerBirthdayField
            // 
            this.customerBirthdayField.CustomFormat = "MMMM dd, yyyy";
            this.customerBirthdayField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBirthdayField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customerBirthdayField.Location = new System.Drawing.Point(513, 120);
            this.customerBirthdayField.Name = "customerBirthdayField";
            this.customerBirthdayField.Size = new System.Drawing.Size(227, 33);
            this.customerBirthdayField.TabIndex = 24;
            this.customerBirthdayField.Value = new System.DateTime(2017, 12, 13, 0, 0, 0, 0);
            // 
            // customerEmailField
            // 
            this.customerEmailField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerEmailField.Location = new System.Drawing.Point(513, 212);
            this.customerEmailField.Name = "customerEmailField";
            this.customerEmailField.Size = new System.Drawing.Size(228, 33);
            this.customerEmailField.TabIndex = 22;
            // 
            // customerCellphoneNumberField
            // 
            this.customerCellphoneNumberField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCellphoneNumberField.Location = new System.Drawing.Point(513, 165);
            this.customerCellphoneNumberField.Name = "customerCellphoneNumberField";
            this.customerCellphoneNumberField.Size = new System.Drawing.Size(228, 33);
            this.customerCellphoneNumberField.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(322, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(321, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Customer Birthday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(322, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cellphone Number:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Firebrick;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(386, 263);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(162, 39);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.acceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.Location = new System.Drawing.Point(181, 263);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(140, 39);
            this.acceptBtn.TabIndex = 9;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // membershipTypeComboBox
            // 
            this.membershipTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.membershipTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipTypeComboBox.FormattingEnabled = true;
            this.membershipTypeComboBox.Items.AddRange(new object[] {
            "Regular",
            "V.I.P"});
            this.membershipTypeComboBox.Location = new System.Drawing.Point(513, 79);
            this.membershipTypeComboBox.Name = "membershipTypeComboBox";
            this.membershipTypeComboBox.Size = new System.Drawing.Size(228, 33);
            this.membershipTypeComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(322, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Membership Type: ";
            // 
            // customerNameField
            // 
            this.customerNameField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameField.Location = new System.Drawing.Point(513, 32);
            this.customerNameField.Name = "customerNameField";
            this.customerNameField.Size = new System.Drawing.Size(228, 33);
            this.customerNameField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(322, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name: ";
            // 
            // customerIdField
            // 
            this.customerIdField.Location = new System.Drawing.Point(611, -1);
            this.customerIdField.Name = "customerIdField";
            this.customerIdField.ReadOnly = true;
            this.customerIdField.Size = new System.Drawing.Size(100, 29);
            this.customerIdField.TabIndex = 2;
            this.customerIdField.Visible = false;
            // 
            // CustomerList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(780, 632);
            this.Controls.Add(this.customerIdField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerListGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox membershipTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.DateTimePicker customerBirthdayField;
        private System.Windows.Forms.MaskedTextBox customerEmailField;
        private System.Windows.Forms.MaskedTextBox customerCellphoneNumberField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox customerPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerIdField;
    }
}