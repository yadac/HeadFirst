using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Service
{
    public static class WeatherElementGenerator
    {
        private static Random rand = new Random();
        public static float GetTempreture()
        {
            return (float)rand.NextDouble();
        }

        private static void GetWeatherFromOpenMeteo()
        {
            // https://api.open-meteo.com/v1/forecast?latitude=35.6895&longitude=139.6917&current=temperature_2m,relative_humidity_2m&hourly=&daily=weather_code,temperature_2m_max,temperature_2m_min&timezone=Asia%2FTokyo
            
        }
    }
}
