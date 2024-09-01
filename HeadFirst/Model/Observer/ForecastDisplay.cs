using System.Diagnostics;

namespace HeadFirst.Model.Observer
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private double _tempreture;
        private double _humidity;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Regist(this);
        }

        public void Display()
        {
            Debug.WriteLine($"予報気温: {_tempreture}");
            Debug.WriteLine($"予報湿度: {_humidity}");
        }

        public void Update()
        {
            _tempreture = _weatherData.Tempreture;
            _humidity = _weatherData.Humidity;
            Display();
        }
    }
}
