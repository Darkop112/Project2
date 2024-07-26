using System;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class ReportInSalesForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Button dailyReportButton;
        private System.Windows.Forms.Button monthlyReportButton;
        private System.Windows.Forms.Button productWiseReportButton;
        private System.Windows.Forms.Button customerWiseReportButton;
        private System.Windows.Forms.DataGridView reportDataGridView;

        public ReportInSalesForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dailyReportButton = new System.Windows.Forms.Button();
            this.monthlyReportButton = new System.Windows.Forms.Button();
            this.productWiseReportButton = new System.Windows.Forms.Button();
            this.customerWiseReportButton = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(12, 12);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatePicker.TabIndex = 0;

            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(218, 12);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 20);
            this.toDatePicker.TabIndex = 1;

            // 
            // dailyReportButton
            // 
            this.dailyReportButton.Location = new System.Drawing.Point(12, 50);
            this.dailyReportButton.Name = "dailyReportButton";
            this.dailyReportButton.Size = new System.Drawing.Size(100, 23);
            this.dailyReportButton.TabIndex = 2;
            this.dailyReportButton.Text = "Daily Report";
            this.dailyReportButton.UseVisualStyleBackColor = true;

            // 
            // monthlyReportButton
            // 
            this.monthlyReportButton.Location = new System.Drawing.Point(118, 50);
            this.monthlyReportButton.Name = "monthlyReportButton";
            this.monthlyReportButton.Size = new System.Drawing.Size(100, 23);
            this.monthlyReportButton.TabIndex = 3;
            this.monthlyReportButton.Text = "Monthly Report";
            this.monthlyReportButton.UseVisualStyleBackColor = true;

            // 
            // productWiseReportButton
            // 
            this.productWiseReportButton.Location = new System.Drawing.Point(224, 50);
            this.productWiseReportButton.Name = "productWiseReportButton";
            this.productWiseReportButton.Size = new System.Drawing.Size(120, 23);
            this.productWiseReportButton.TabIndex = 4;
            this.productWiseReportButton.Text = "Product-Wise Report";
            this.productWiseReportButton.UseVisualStyleBackColor = true;

            // 
            // customerWiseReportButton
            // 
            this.customerWiseReportButton.Location = new System.Drawing.Point(350, 50);
            this.customerWiseReportButton.Name = "customerWiseReportButton";
            this.customerWiseReportButton.Size = new System.Drawing.Size(120, 23);
            this.customerWiseReportButton.TabIndex = 5;
            this.customerWiseReportButton.Text = "Customer-Wise Report";
            this.customerWiseReportButton.UseVisualStyleBackColor = true;

            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(12, 90);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(776, 348);
            this.reportDataGridView.TabIndex = 6;

            // 
            // ReportInSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.customerWiseReportButton);
            this.Controls.Add(this.productWiseReportButton);
            this.Controls.Add(this.monthlyReportButton);
            this.Controls.Add(this.dailyReportButton);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Name = "ReportInSalesForm";
            this.Text = "Report in Sales";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
