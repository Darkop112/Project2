﻿namespace FinalProject
{
    namespace FinalProject
    {
        public class CartItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => Price * Quantity;
        }
    }


}
