using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Product
    {
        public string ItemName { get; set;}
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public double NormalPrice { get; set; }
        public double BulkPrice { get; set; }
        public double DiscountPrice { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
    }
}