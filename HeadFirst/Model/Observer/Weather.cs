using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Model.Observer
{
    public class Weather
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double GenerationTimeMs { get; set; }
        public int UtcOffsetSeconds { get; set; }
        public string Timezone { get; set; }
        public string TimezoneAbbreviation { get; set; }
        public double Elevation { get; set; }
        public CurrentUnits CurrentUnits { get; set; }
        public CurrentWeather Current { get; set; }
    }

    public class CurrentUnits
    {
        public string Time { get; set; }
        public string Interval { get; set; }
        [JsonProperty("temperature_2m")]
        public string Temperature2m { get; set; }
        [JsonProperty("relative_humidity_2m")]
        public string RelativeHumidity2m { get; set; }
    }

    public class CurrentWeather
    {
        public string Time { get; set; }
        public int Interval { get; set; }
        [JsonProperty("temperature_2m")]
        public double Temperature2m { get; set; }
        [JsonProperty("relative_humidity_2m")]
        public int RelativeHumidity2m { get; set; }
    }

}
