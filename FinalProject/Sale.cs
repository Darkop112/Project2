using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Sale
    {
        public DateTime Date { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
    }
}
