using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double Cost { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }

        public virtual Type Type { get; set; }
        public virtual Category Category { get; set; }

    }
}