using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    public class InventoryDataProvider
    {
        public IEnumerable<InventoryItem> GetInventoryItems(DateTime startDate)
        {
            var inventory = Invent.GetInventory();
            return inventory.Where(i => i.Date >= startDate);
        }
    }
}
