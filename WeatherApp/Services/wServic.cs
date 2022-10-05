using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class wServic : IwReprosetory
    {
        public Result GetForcast(string city)
        {
            var App_id = Configration.Value.Key;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={App_id}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if(response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<Result>();
            }
            return null;
        }
    }
}
