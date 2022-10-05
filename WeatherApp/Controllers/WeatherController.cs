using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IwReprosetory _Weather;
        public WeatherController(IwReprosetory Weather)
        {
            _Weather = Weather;
        }
        public object Modelstate { get; private set; }

        public IActionResult City()
        {
            return View();
        }
        [HttpPost]
        public IActionResult City(CityModel cityModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetWeather",new{city=cityModel.City});
            }
            return View(cityModel);
        }

        public IActionResult GetWeather(string city)
        {
            Result res = _Weather.GetForcast(city);
            GetWeather get = new GetWeather();
            if (res != null)
            {
                get.Name = res.name;
                get.Temperature = res.main.temp;
                get.Pressure = res.main.pressure;
                get.Humditiy = res.main.humidity;
                get.Wind = res.Wind.speed;
                get.Weather = res.Weather[0].main;
                get.TimeZone = res.TimeZone;
                get.Country = res.Sys.country;
                get.max = res.main.temp_max;
                get.min = res.main.temp_min;
                get.feelsLike = res.main.feels_like;

            }
            else get.message = "Wrong City Name";
            return View(get);
        }



    }
}
