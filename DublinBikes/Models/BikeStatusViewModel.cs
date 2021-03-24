using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DublinBikes.Models
{
    public class BikeStatusViewModel
    {
        public List<Bike> Bikes { get; set; }
        public SelectList Status { get; set; }
        public string BikeStatus { get; set; }
        public string SearchString { get; set; }
    }
}