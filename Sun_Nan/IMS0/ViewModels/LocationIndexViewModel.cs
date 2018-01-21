using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.ViewModels
{
    public class LocationIndexViewModel
    {
        public Models.Location Location { get; set; }
        public IEnumerable<Models.Location> Locations { get; set; }
    }
}