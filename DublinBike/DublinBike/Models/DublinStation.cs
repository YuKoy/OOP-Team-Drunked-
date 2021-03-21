using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DublinBike.Models
{
    public class DublinStation
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Number { get; set; }

    }
}
