using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SalesHistory : Form
    {
        private static List<Sale> sales = new List<Sale>();

        public SalesHistory()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSalesData();
        }

        public static void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        public static List<Sale> GetSales()
        {
            return sales;
        }

        private void InitializeDataGridView()
        {
            dataGridViewSalesHistory.Columns.Clear();
            dataGridViewSalesHistory.Columns.Add("Date", "Date");
            dataGridViewSalesHistory.Columns.Add("Items", "Items");
            dataGridViewSalesHistory.Columns.Add("TotalAmount", "Total Amount");
            dataGridViewSalesHistory.Columns.Add("PaymentMethod", "Payment Method");
            dataGridViewSalesHistory.Columns.Add("Payment", "Payment");
            dataGridViewSalesHistory.Columns.Add("Change", "Change");
        }

        private void LoadSalesData()
        {
            dataGridViewSalesHistory.Rows.Clear();
            foreach (var sale in sales)
            {
                AddSaleToGrid(sale);
            }
        }

        private void AddSaleToGrid(Sale sale)
        {
            string itemsDescription = string.Join(", ", sale.Items.Select(i => $"{i.Name} x{i.Quantity}"));
            dataGridViewSalesHistory.Rows.Add(
                sale.Date.ToString("d"),
                itemsDescription,
                sale.TotalAmount.ToString("C"),
                sale.PaymentMethod,
                sale.Payment.ToString("C"),
                sale.Change.ToString("C"));
        }
    }
}
