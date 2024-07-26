using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    public class SalesDataProvider
    {
        public IEnumerable<Sale> GetSales(DateTime startDate, DateTime endDate)
        {
            return SalesHistory.GetSales().Where(s => s.Date >= startDate && s.Date <= endDate);
        }
    }
}
