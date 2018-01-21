using System.Collections.Generic;
using IMS.Models;

namespace IMS.ViewModels
{
    public class TypeIndexViewModel
    {
        public Models.Type Type { get; set; }
        public IEnumerable<Models.Type> Types {get; set; }
    }
}