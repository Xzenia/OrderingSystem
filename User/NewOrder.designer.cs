﻿namespace User
{
    partial class NewOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.ord = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productListGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Order";
            // 
            // ord
            // 
            this.ord.Controls.Add(this.btnAccept);
            this.ord.Controls.Add(this.btnCancel);
            this.ord.Controls.Add(this.orderDataGridView);
            this.ord.Controls.Add(this.orderDateAndTime);
            this.ord.Controls.Add(this.label4);
            this.ord.Controls.Add(this.label5);
            this.ord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord.ForeColor = System.Drawing.Color.PeachPuff;
            this.ord.Location = new System.Drawing.Point(624, 12);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(428, 577);
            this.ord.TabIndex = 1;
            this.ord.TabStop = false;
            this.ord.Text = "Order Details";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Peru;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnAccept.FlatAppearance.BorderSize = 2;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAccept.Location = new System.Drawing.Point(23, 502);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(200, 62);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept Order";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Location = new System.Drawing.Point(229, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 62);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClick);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AllowUserToResizeColumns = false;
            this.orderDataGridView.AllowUserToResizeRows = false;
            this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.orderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDataGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.orderDataGridView.Location = new System.Drawing.Point(23, 137);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.ShowCellErrors = false;
            this.orderDataGridView.ShowCellToolTips = false;
            this.orderDataGridView.ShowEditingIcon = false;
            this.orderDataGridView.ShowRowErrors = false;
            this.orderDataGridView.Size = new System.Drawing.Size(380, 359);
            this.orderDataGridView.TabIndex = 2;
            this.orderDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellDoubleClick);
            // 
            // orderDateAndTime
            // 
            this.orderDateAndTime.CustomFormat = "dd MMM yyyy hh:mm tt";
            this.orderDateAndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateAndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateAndTime.Location = new System.Drawing.Point(23, 66);
            this.orderDateAndTime.Name = "orderDateAndTime";
            this.orderDateAndTime.Size = new System.Drawing.Size(228, 29);
            this.orderDateAndTime.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Date and Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(21, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Items Ordered";
            // 
            // productListGridView
            // 
            this.productListGridView.AllowUserToAddRows = false;
            this.productListGridView.AllowUserToDeleteRows = false;
            this.productListGridView.AllowUserToResizeColumns = false;
            this.productListGridView.AllowUserToResizeRows = false;
            this.productListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productListGridView.BackgroundColor = System.Drawing.Color.Chocolate;
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.productListGridView.Location = new System.Drawing.Point(12, 50);
            this.productListGridView.MultiSelect = false;
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.ReadOnly = true;
            this.productListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListGridView.ShowCellErrors = false;
            this.productListGridView.ShowCellToolTips = false;
            this.productListGridView.ShowEditingIcon = false;
            this.productListGridView.ShowRowErrors = false;
            this.productListGridView.Size = new System.Drawing.Size(594, 526);
            this.productListGridView.TabIndex = 2;
            this.productListGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productListGridView_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(444, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "See The Whole Menu!";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.productListGridView);
            this.Controls.Add(this.ord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewOrder";
            this.Text = "Start a new Order";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ord.ResumeLayout(false);
            this.ord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ord;
        private System.Windows.Forms.DateTimePicker orderDateAndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridView productListGridView;
        private System.Windows.Forms.Label label2;
    }
}