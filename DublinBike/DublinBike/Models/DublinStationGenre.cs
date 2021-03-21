using DublinBike.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBike.Models
{
    public class DublinStationGenre
    {
        public List<DublinStation> DublinStations { get; set; }
        public SelectList Names { get; set; }

        public string StationName { get; set; }

        public string SearchBar { get; set; }

    }
}
