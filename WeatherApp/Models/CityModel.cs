using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class CityModel
    {
        [Required]
        [MaxLength(50),MinLength(3)]
        public string City { get; set; }
    }
}
