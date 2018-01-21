using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxInclusive { get; set; }
        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
    }
}