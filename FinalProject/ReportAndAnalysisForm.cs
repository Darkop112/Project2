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

        public ReportAndAnalysisForm()
        {
            InitializeComponent();
            _salesDataProvider = new SalesDataProvider();
            _inventoryDataProvider = new InventoryDataProvider();
            _chartManager = new ChartManager(reportChart);

            salesTrendButton.Click += SalesTrendButton_Click;
            inventoryAnalysisButton.Click += InventoryAnalysisButton_Click;
            profitAnalysisButton.Click += ProfitAnalysisButton_Click;
        }

        private void SalesTrendButton_Click(object sender, EventArgs e)
        {
            try
            {
                var lastMonth = DateTime.Today.AddMonths(-1);
                var sales = _salesDataProvider.GetSales(lastMonth);

                var salesData = sales
                    .GroupBy(s => s.Items.First().Name)
                    .Select(g => new
                    {
                        FruitName = g.Key,
                        Quantity = g.Sum(s => s.Items.First().Quantity)
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
                var lastMonth = DateTime.Today.AddMonths(-1);
                var inventory = _inventoryDataProvider.GetInventoryItems(lastMonth);

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
                var lastYear = DateTime.Today.AddYears(-1);
                var sales = _salesDataProvider.GetSales(lastYear);

                var profitData = sales
                    .GroupBy(s => s.Date.ToString("yyyy-MM"))
                    .Select(g => new
                    {
                        Month = g.Key,
                        Profit = g.Sum(s => s.TotalAmount)
                    })
                    .ToList();

                _chartManager.DisplayChart("ProfitAnalysis", SeriesChartType.Line, profitData, "Month", "Profit");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profit analysis data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
