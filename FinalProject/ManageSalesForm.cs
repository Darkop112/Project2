using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ManageSalesForm : Form
    {
        public ManageSalesForm()
        {
            InitializeComponent();
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sale ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Product");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");

            dt.Rows.Add("1", DateTime.Now.ToString(), "Apple", 2, 20.00, 40.00);
            dt.Rows.Add("2", DateTime.Now.ToString(), "Banana", 5, 15.00, 75.00);

            salesDataGridView.DataSource = dt;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Implement edit functionality
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Implement delete functionality
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Implement add new sale functionality
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Implement search functionality
        }

        private void manageSalesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
