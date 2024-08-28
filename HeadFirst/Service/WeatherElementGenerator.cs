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
    }
}
