using System.Collections.Generic;

namespace FinalProject
{
    public static class Invent
    {
        private static List<InventoryItem> inventoryItems = new List<InventoryItem>();

        public static void AddInventoryItem(InventoryItem item)
        {
            inventoryItems.Add(item);
        }

        public static List<InventoryItem> GetInventory()
        {
            return inventoryItems;
        }
    }
}
