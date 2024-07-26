using System;

namespace FinalProject
{
    public class InventoryItem
    {
        public string FruitName { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public InventoryItem(string fruitName, int quantity, DateTime date)
        {
            FruitName = fruitName;
            Quantity = quantity;
            Date = date;
        }
    }
}
