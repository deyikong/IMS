﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class ItemPrice
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int PriceId { get; set; }
        public double SalesPrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Price Price { get; set; }
    }
}