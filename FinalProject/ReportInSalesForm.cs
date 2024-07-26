using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ReportInSalesForm : Form
    {
        public ReportInSalesForm()
        {
            InitializeComponent();
            dailyReportButton.Click += DailyReportButton_Click;
            monthlyReportButton.Click += MonthlyReportButton_Click;
            productWiseReportButton.Click += ProductWiseReportButton_Click;
            customerWiseReportButton.Click += CustomerWiseReportButton_Click;
            printButton.Click += (s, e) => PrintSalesData();
        }

        private void DailyReportButton_Click(object sender, EventArgs e)
        {
            LoadReportData("daily");
        }

        private void MonthlyReportButton_Click(object sender, EventArgs e)
        {
            LoadReportData("monthly");
        }

        private void ProductWiseReportButton_Click(object sender, EventArgs e)
        {
            LoadReportData("product-wise");
        }

        private void CustomerWiseReportButton_Click(object sender, EventArgs e)
        {
            LoadReportData("customer-wise");
        }

        private void LoadReportData(string reportType)
        {
            var sales = SalesHistory.GetSales();
            var filteredSales = new List<Sale>();

            if (reportType == "daily")
            {
                var today = DateTime.Today;
                filteredSales = sales.Where(s => s.Date.Date == today).ToList();
            }
            else if (reportType == "monthly")
            {
                var currentMonth = DateTime.Today.Month;
                var currentYear = DateTime.Today.Year;
                filteredSales = sales.Where(s => s.Date.Month == currentMonth && s.Date.Year == currentYear).ToList();
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("Items");
            dt.Columns.Add("Total Amount");
            dt.Columns.Add("Payment Method");
            dt.Columns.Add("Payment");
            dt.Columns.Add("Change");

            foreach (var sale in filteredSales)
            {
                string itemsDescription = string.Join(", ", sale.Items.Select(i => $"{i.Name} x{i.Quantity}"));
                dt.Rows.Add(
                    sale.Date.ToString("yyyy-MM-dd"),
                    itemsDescription,
                    sale.TotalAmount.ToString("C"),
                    sale.PaymentMethod,
                    sale.Payment.ToString("C"),
                    sale.Change.ToString("C"));
            }

            reportDataGridView.DataSource = dt;
        }

        private void PrintSalesData()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 10;
            int rowHeight = 30;
            int columnWidth = 100;
            int headerHeight = 30;

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Draw column headers
            foreach (DataGridViewColumn column in reportDataGridView.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, font, brush, x, y);
                x += columnWidth;
            }

            y += headerHeight;
            x = 10;

            // Draw rows
            foreach (DataGridViewRow row in reportDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                x = 10;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value?.ToString() ?? string.Empty;

                    var textLines = SplitTextIntoLines(cellText, font, columnWidth);
                    foreach (var line in textLines)
                    {
                        e.Graphics.DrawString(line, font, brush, x, y);
                        y += font.Height;
                    }

                    x += columnWidth;
                }
                y += rowHeight;
            }
        }

        private List<string> SplitTextIntoLines(string text, Font font, int maxWidth)
        {
            var lines = new List<string>();
            var words = text.Split(' ');

            string currentLine = string.Empty;

            foreach (var word in words)
            {
                string testLine = currentLine + word + " ";

                if (TextRenderer.MeasureText(testLine, font).Width > maxWidth)
                {
                    if (currentLine.Length > 0)
                    {
                        lines.Add(currentLine.TrimEnd());
                        currentLine = word + " ";
                    }
                    else
                    {
                        lines.Add(word);
                    }
                }
                else
                {
                    currentLine = testLine;
                }
            }

            if (currentLine.Length > 0)
            {
                lines.Add(currentLine.TrimEnd());
            }

            return lines;
        }
    }
}
