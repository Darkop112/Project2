using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    public class InventoryDataProvider
    {
        public IEnumerable<InventoryItem> GetInventoryItems(DateTime startDate, DateTime endDate)
        {
            return Invent.GetInventory().Where(i => i.Date >= startDate && i.Date <= endDate);
        }
    }
}
