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

            // Load existing sales into the data grid
            foreach (var sale in sales)
            {
                AddSaleToGrid(sale);
            }
        }

        public static void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        public static List<Sale> GetSales()
        {
            return sales;
        }

        private void AddSaleToGrid(Sale sale)
        {
            string itemsDescription = string.Join(", ", sale.Items.Select(i => $"{i.Name} x{i.Quantity}"));
            dataGridViewSalesHistory.Rows.Add(
                sale.Date.ToString("dddd"),
                itemsDescription,
                sale.TotalAmount.ToString("C"),
                sale.PaymentMethod,
                sale.Payment.ToString("C"),
                sale.Change.ToString("C"));
        }
    }
}
