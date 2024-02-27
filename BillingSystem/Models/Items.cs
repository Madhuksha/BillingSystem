using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingSystem.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int ItemIndex { get; set; }
    }
}