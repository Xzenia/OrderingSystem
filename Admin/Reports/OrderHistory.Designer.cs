namespace Admin.Reports
{
    partial class OrderHistory
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistory));
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableDataSet = new Admin.OrderTableDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orderTableTableAdapter = new Admin.OrderTableDataSetTableAdapters.OrderTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this.orderTableDataSet;
            // 
            // orderTableDataSet
            // 
            this.orderTableDataSet.DataSetName = "OrderTableDataSet";
            this.orderTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Sienna;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrderHistory";
            reportDataSource1.Value = this.orderTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin.Reports.OrderHistory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(758, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // orderTableTableAdapter
            // 
            this.orderTableTableAdapter.ClearBeforeFill = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(758, 517);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderHistory";
            this.Text = "Order History";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OrderTableDataSet orderTableDataSet;
        private System.Windows.Forms.BindingSource orderTableBindingSource;
        private OrderTableDataSetTableAdapters.OrderTableTableAdapter orderTableTableAdapter;
    }
}