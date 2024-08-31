using System.Diagnostics;

namespace HeadFirst.Model
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private WeatherData _weatherData;
        private float _tempreture;
        private float _humidity;
        private float _pressure;

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

        public void Update(float templature, float humidity, float pressure)
        {
            _tempreture = templature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
