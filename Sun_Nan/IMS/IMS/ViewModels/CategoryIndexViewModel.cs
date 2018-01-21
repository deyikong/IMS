using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.ViewModels
{
    public class CategoryIndexViewModel
    {
        public Models.Category Category { get; set; }
        public IEnumerable<Models.Category> Categories { get; set; }
    }
}