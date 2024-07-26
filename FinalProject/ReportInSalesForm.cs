using System;
using System.Windows.Forms;
using System.Data;

namespace FinalProject { 
public class ReportInSalesForm : Form
{
    private DateTimePicker fromDatePicker, toDatePicker;
    private Button dailyReportButton, monthlyReportButton, productWiseReportButton, customerWiseReportButton;
    private DataGridView reportDataGridView;

    public ReportInSalesForm()
    {
        // Initialize components
        fromDatePicker = new DateTimePicker { Dock = DockStyle.Top };
        toDatePicker = new DateTimePicker { Dock = DockStyle.Top };
        dailyReportButton = new Button { Text = "Generate Daily Report", Dock = DockStyle.Top };
        monthlyReportButton = new Button { Text = "Generate Monthly Report", Dock = DockStyle.Top };
        productWiseReportButton = new Button { Text = "Generate Product-wise Report", Dock = DockStyle.Top };
        customerWiseReportButton = new Button { Text = "Generate Customer-wise Report", Dock = DockStyle.Top };
        reportDataGridView = new DataGridView { Dock = DockStyle.Fill };

        // Add components to the form
        this.Controls.Add(reportDataGridView);
        this.Controls.Add(customerWiseReportButton);
        this.Controls.Add(productWiseReportButton);
        this.Controls.Add(monthlyReportButton);
        this.Controls.Add(dailyReportButton);
        this.Controls.Add(toDatePicker);
        this.Controls.Add(fromDatePicker);

        // Event handlers
        dailyReportButton.Click += DailyReportButton_Click;
        monthlyReportButton.Click += MonthlyReportButton_Click;
        productWiseReportButton.Click += ProductWiseReportButton_Click;
        customerWiseReportButton.Click += CustomerWiseReportButton_Click;
    }

    private void DailyReportButton_Click(object sender, EventArgs e)
    {
        // Implement daily report generation logic
        LoadReportData("daily");
    }

    private void MonthlyReportButton_Click(object sender, EventArgs e)
    {
        // Implement monthly report generation logic
        LoadReportData("monthly");
    }

    private void ProductWiseReportButton_Click(object sender, EventArgs e)
    {
        // Implement product-wise report generation logic
        LoadReportData("product-wise");
    }

    private void CustomerWiseReportButton_Click(object sender, EventArgs e)
    {
        // Implement customer-wise report generation logic
        LoadReportData("customer-wise");
    }

    private void LoadReportData(string reportType)
    {
        // Replace with actual report data loading logic
        DataTable dt = new DataTable();
        dt.Columns.Add("Date");
        dt.Columns.Add("Product");
        dt.Columns.Add("Quantity");
        dt.Columns.Add("Total");

        // Sample data
        dt.Rows.Add(DateTime.Now.ToString(), "Apple", 2, 40.00);
        dt.Rows.Add(DateTime.Now.ToString(), "Banana", 5, 75.00);

        reportDataGridView.DataSource = dt;
    }
}

}
