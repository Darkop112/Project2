namespace FinalProject
{
    partial class ReportInSalesForm
    {
        private System.ComponentModel.IContainer components = null;

        private DateTimePicker fromDatePicker, toDatePicker;
        private Button dailyReportButton, monthlyReportButton, productWiseReportButton, customerWiseReportButton, printButton;
        private DataGridView reportDataGridView;

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
            fromDatePicker = new DateTimePicker();
            toDatePicker = new DateTimePicker();
            dailyReportButton = new Button();
            monthlyReportButton = new Button();
            productWiseReportButton = new Button();
            customerWiseReportButton = new Button();
            reportDataGridView = new DataGridView();
            printButton = new Button();
            ((System.ComponentModel.ISupportInitialize)reportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // fromDatePicker
            // 
            fromDatePicker.Dock = DockStyle.Top;
            fromDatePicker.Location = new Point(0, 0);
            fromDatePicker.Name = "fromDatePicker";
            fromDatePicker.Size = new Size(989, 27);
            fromDatePicker.TabIndex = 7;
            // 
            // toDatePicker
            // 
            toDatePicker.Dock = DockStyle.Top;
            toDatePicker.Location = new Point(0, 27);
            toDatePicker.Name = "toDatePicker";
            toDatePicker.Size = new Size(989, 27);
            toDatePicker.TabIndex = 6;
            // 
            // dailyReportButton
            // 
            dailyReportButton.Dock = DockStyle.Top;
            dailyReportButton.Location = new Point(0, 54);
            dailyReportButton.Name = "dailyReportButton";
            dailyReportButton.Size = new Size(989, 40);
            dailyReportButton.TabIndex = 5;
            dailyReportButton.Text = "Generate Daily Report";
            // 
            // monthlyReportButton
            // 
            monthlyReportButton.Dock = DockStyle.Top;
            monthlyReportButton.Location = new Point(0, 94);
            monthlyReportButton.Name = "monthlyReportButton";
            monthlyReportButton.Size = new Size(989, 39);
            monthlyReportButton.TabIndex = 4;
            monthlyReportButton.Text = "Generate Monthly Report";
            // 
            // productWiseReportButton
            // 
            productWiseReportButton.Dock = DockStyle.Top;
            productWiseReportButton.Location = new Point(0, 133);
            productWiseReportButton.Name = "productWiseReportButton";
            productWiseReportButton.Size = new Size(989, 43);
            productWiseReportButton.TabIndex = 3;
            productWiseReportButton.Text = "Generate Product-wise Report";
            // 
            // customerWiseReportButton
            // 
            customerWiseReportButton.Dock = DockStyle.Top;
            customerWiseReportButton.Location = new Point(0, 176);
            customerWiseReportButton.Name = "customerWiseReportButton";
            customerWiseReportButton.Size = new Size(989, 37);
            customerWiseReportButton.TabIndex = 2;
            customerWiseReportButton.Text = "Generate Customer-wise Report";
            // 
            // reportDataGridView
            // 
            reportDataGridView.ColumnHeadersHeight = 29;
            reportDataGridView.Dock = DockStyle.Fill;
            reportDataGridView.Location = new Point(0, 252);
            reportDataGridView.Name = "reportDataGridView";
            reportDataGridView.RowHeadersWidth = 51;
            reportDataGridView.Size = new Size(989, 277);
            reportDataGridView.TabIndex = 0;
            // 
            // printButton
            // 
            printButton.Dock = DockStyle.Top;
            printButton.Location = new Point(0, 213);
            printButton.Name = "printButton";
            printButton.Size = new Size(989, 39);
            printButton.TabIndex = 1;
            printButton.Text = "Print Sales Data";
            // 
            // ReportInSalesForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(989, 529);
            ControlBox = false;
            Controls.Add(reportDataGridView);
            Controls.Add(printButton);
            Controls.Add(customerWiseReportButton);
            Controls.Add(productWiseReportButton);
            Controls.Add(monthlyReportButton);
            Controls.Add(dailyReportButton);
            Controls.Add(toDatePicker);
            Controls.Add(fromDatePicker);
            Name = "ReportInSalesForm";
            ((System.ComponentModel.ISupportInitialize)reportDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}
