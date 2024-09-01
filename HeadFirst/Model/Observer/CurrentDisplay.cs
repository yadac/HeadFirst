using System.Diagnostics;

namespace HeadFirst.Model.Observer
{
    public class CurrentDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private double _tempreture;
        private double _humidity;

        public CurrentDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.Regist(this);
        }

        public void Display()
        {
            Debug.WriteLine($"気温: {_tempreture}");
            Debug.WriteLine($"湿度: {_humidity}");
        }

        public void Update()
        {
            _tempreture = _weatherData.Tempreture;
            _humidity = _weatherData.Humidity;
            Display();
        }
    }
}
