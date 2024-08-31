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
        private float _tempreture;
        private float _humidity;
        private float _pressure;

        public void SetMeasurements()
        {
            _tempreture = WeatherElementGenerator.GetTempreture();
            _humidity = WeatherElementGenerator.GetTempreture();
            _pressure = WeatherElementGenerator.GetTempreture();
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
                o.Update(_tempreture, _humidity, _pressure);
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
