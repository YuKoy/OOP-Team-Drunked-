using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DublinBikes.Models
{
    public class Bike
    {
        public int Id { get; set; }
        [Range(1, 100)]
        public int Number { get; set; }
        [Display(Name = "Contract Name")]
        [StringLength(30, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string ContractName { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        [Required]
        [StringLength(120)]
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [Required]
        public bool Banking { get; set; }
        [Display(Name = "Available Bikes")]
        [Range(1, 100)]
        public int AvailableBikes { get; set; }
        [Display(Name = "Available Stands")]
        [Range(1, 100)]
        public int AvailableStands { get; set; }
        [Range(1, 100)]
        public int Capacity { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Status { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}
