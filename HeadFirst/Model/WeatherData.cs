using HeadFirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Model
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private double _tempreture;
        private double _humidity;
        public double Tempreture { get; private set; }
        public double Humidity { get; private set; }

        public async void SetMeasurements()
        {
            Tempreture = await WeatherElementGenerator.GetTempretureAsync();
            Humidity = await WeatherElementGenerator.GetHumidityAsync();
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            Notify();
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }

        public void Regist(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
