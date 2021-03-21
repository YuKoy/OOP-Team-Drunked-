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

        public string adress { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public int Number { get; set; }

    }
}
