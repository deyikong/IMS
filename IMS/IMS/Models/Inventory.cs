using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Inventory
    {
        public int ItemId { get; set; }
        public int LocationId { get; set; }
        public double Quantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual Price Price { get; set; }
    }
}