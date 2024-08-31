using System.Diagnostics;

namespace HeadFirst.Model
{
    public class CurrentDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private float _tempreture;
        private float _humidity;
        private float _pressure;

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
