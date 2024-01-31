using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Province
    {
        [Key]
        [MaxLength(30)]
        [Display(Name = "Province Code")]
        public string? ProvinceCode { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string? ProvinceName { get; set; }

        public List<City>? Cities { get; set; }
    }
}