using System.Diagnostics;

namespace HeadFirst.Model
{
    public class NormalDisplayDevice : IObserver, IDisplay
    {
        private WeatherElement _weatherElement;

        public string Display()
        {
            return $"Tempreture: {_weatherElement.Element}.";
        }

        public void Update(WeatherElement weatherElement)
        {
            _weatherElement = weatherElement;
        }
    }
}
