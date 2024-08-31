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
        public float Tempreture { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }

        public void SetMeasurements()
        {
            Tempreture = WeatherElementGenerator.GetTempreture();
            Humidity = WeatherElementGenerator.GetTempreture();
            Pressure = WeatherElementGenerator.GetTempreture();
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
