using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class Sale
    {
        public DateTime Date { get; set; }
        public List<SaleItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }

        public Sale(DateTime date, List<SaleItem> items, decimal totalAmount, string paymentMethod, decimal payment, decimal change)
        {
            Date = date;
            Items = items;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
            Payment = payment;
            Change = change;
        }
    }
}

