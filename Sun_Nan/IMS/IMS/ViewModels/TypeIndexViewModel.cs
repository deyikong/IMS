using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.ViewModels
{
    public class TypeIndexViewModel
    {
        public Models.Type Type { get; set; }
        public IEnumerable<Models.Type> Types {get; set; }
    }
}