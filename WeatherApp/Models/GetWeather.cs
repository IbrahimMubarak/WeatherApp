using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class GetWeather
    {
        [Display(Name="City Name")]
        public string Name { get; set; }
        public float Temperature { get; set; }
        public int Humditiy { get; set; }
        public int Pressure { get; set; }
        public float Wind { get; set; }
        [Display(Name ="Weather Condition")]
        public string Weather { get; set; }
        public int TimeZone { get; set; }
        public string Country { get; set; }
        public float feelsLike { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public string message { get; set; }
    }
}
