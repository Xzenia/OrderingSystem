﻿namespace User
{
    partial class CustomerOrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderHistory));
            this.customerOrderHistoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrderHistoryGridView
            // 
            this.customerOrderHistoryGridView.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.customerOrderHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrderHistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrderHistoryGridView.Location = new System.Drawing.Point(0, 0);
            this.customerOrderHistoryGridView.Name = "customerOrderHistoryGridView";
            this.customerOrderHistoryGridView.ReadOnly = true;
            this.customerOrderHistoryGridView.Size = new System.Drawing.Size(659, 485);
            this.customerOrderHistoryGridView.TabIndex = 0;
            // 
            // CustomerOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 485);
            this.Controls.Add(this.customerOrderHistoryGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerOrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderHistoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerOrderHistoryGridView;

    }
}