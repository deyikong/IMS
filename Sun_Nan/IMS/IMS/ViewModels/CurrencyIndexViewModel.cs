using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.ViewModels
{
    public class CurrencyIndexViewModel
    {
        public Models.Currency Currency { get; set; }
        public IEnumerable<Models.Currency> Currencies { get; set; }
    }
}