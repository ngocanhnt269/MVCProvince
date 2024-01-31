using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        public string? CityName { get; set; }
        public int Population { get; set; }
        [ForeignKey("ProvinceCode")]
        public string? ProvinceCode { get; set; }
        public Province? Province { get; set; }

    }
}