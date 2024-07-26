using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    public class SalesDataProvider
    {
        private static List<Sale> salesData = new List<Sale>();

        public IEnumerable<Sale> GetSales(DateTime startDate)
        {
            return salesData.Where(s => s.Date >= startDate);
        }

        public static void AddSale(Sale sale)
        {
            salesData.Add(sale);
        }
    }
}
