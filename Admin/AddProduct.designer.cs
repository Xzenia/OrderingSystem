namespace Admin
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productPriceField = new System.Windows.Forms.TextBox();
            this.productNameField = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPictureBox.Image = global::Admin.Properties.Resources.defaultImage;
            this.productPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("productPictureBox.InitialImage")));
            this.productPictureBox.Location = new System.Drawing.Point(126, 12);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(150, 150);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPictureBox.TabIndex = 15;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.DoubleClick += new System.EventHandler(this.productPictureBox_DoubleClick);
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.productCategoryComboBox.Location = new System.Drawing.Point(126, 283);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(195, 21);
            this.productCategoryComboBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Category: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Price: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Picture: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name: ";
            // 
            // productPriceField
            // 
            this.productPriceField.Location = new System.Drawing.Point(126, 238);
            this.productPriceField.Name = "productPriceField";
            this.productPriceField.Size = new System.Drawing.Size(195, 20);
            this.productPriceField.TabIndex = 7;
            // 
            // productNameField
            // 
            this.productNameField.Location = new System.Drawing.Point(126, 197);
            this.productNameField.Name = "productNameField";
            this.productNameField.Size = new System.Drawing.Size(195, 20);
            this.productNameField.TabIndex = 8;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(126, 386);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(120, 34);
            this.AddBtn.TabIndex = 17;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 454);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.productCategoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPriceField);
            this.Controls.Add(this.productNameField);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.ComboBox productCategoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productPriceField;
        private System.Windows.Forms.TextBox productNameField;
        private System.Windows.Forms.Button AddBtn;
    }
}