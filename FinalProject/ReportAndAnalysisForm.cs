using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject
{
    public partial class ReportAndAnalysisForm : Form
    {
        private readonly SalesDataProvider _salesDataProvider;
        private readonly InventoryDataProvider _inventoryDataProvider;
        private readonly ChartManager _chartManager;
        private int _selectedYear;
        private int _selectedMonth;

        public ReportAndAnalysisForm()
        {
            InitializeComponent();
            _salesDataProvider = new SalesDataProvider();
            _inventoryDataProvider = new InventoryDataProvider();
            _chartManager = new ChartManager(reportChart);

            _selectedYear = DateTime.Now.Year;
            _selectedMonth = DateTime.Now.Month;

            // Event handler subscriptions
            salesTrendButton.Click += SalesTrendButton_Click;
            inventoryAnalysisButton.Click += InventoryAnalysisButton_Click;
            profitAnalysisButton.Click += ProfitAnalysisButton_Click;
            filterButton.Click += FilterButton_Click;
        }

        private void SalesTrendButton_Click(object sender, EventArgs e)
        {
            try
            {
                var startOfMonth = new DateTime(_selectedYear, _selectedMonth, 1);
                var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
                var sales = _salesDataProvider.GetSales(startOfMonth, endOfMonth).ToList();

                if (!sales.Any())
                {
                    MessageBox.Show("No sales data available for the selected month.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var salesData = sales
                    .SelectMany(s => s.Items)
                    .GroupBy(i => i.Name)
                    .Select(g => new
                    {
                        FruitName = g.Key,
                        Quantity = g.Sum(i => i.Quantity)
                    })
                    .ToList();

                _chartManager.DisplayChart("SalesTrend", SeriesChartType.Bar, salesData, "FruitName", "Quantity");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales trend data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventoryAnalysisButton_Click(object sender, EventArgs e)
        {
            try
            {
                var startOfMonth = new DateTime(_selectedYear, _selectedMonth, 1);
                var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
                var inventory = _inventoryDataProvider.GetInventoryItems(startOfMonth, endOfMonth).ToList();

                if (!inventory.Any())
                {
                    MessageBox.Show("No inventory data available for the selected month.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var inventoryData = inventory
                    .GroupBy(i => i.FruitName)
                    .Select(g => new
                    {
                        FruitName = g.Key,
                        Quantity = g.Sum(i => i.Quantity)
                    })
                    .ToList();

                _chartManager.DisplayChart("InventoryAnalysis", SeriesChartType.Bar, inventoryData, "FruitName", "Quantity");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory analysis data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfitAnalysisButton_Click(object sender, EventArgs e)
        {
            try
            {
                var startOfYear = new DateTime(_selectedYear, 1, 1);
                var endOfYear = new DateTime(_selectedYear, 12, 31);
                var sales = _salesDataProvider.GetSales(startOfYear, endOfYear).ToList();

                if (!sales.Any())
                {
                    MessageBox.Show("No sales data available for the selected year.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var profitData = sales
                    .SelectMany(s => s.Items)
                    .GroupBy(i => i.Name)
                    .Select(g => new
                    {
                        FruitName = g.Key,
                        TotalProfit = g.Sum(i => i.Quantity * i.Price)
                    })
                    .ToList();

                _chartManager.DisplayChart("ProfitAnalysis", SeriesChartType.Bar, profitData, "FruitName", "TotalProfit");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profit analysis data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            using (var filterForm = new FilterForm(_selectedYear, _selectedMonth))
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    _selectedYear = filterForm.SelectedYear;
                    _selectedMonth = filterForm.SelectedMonth;
                }
            }
        }
    }
}
