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
        private WeatherElement _tempreture = new Tempreture();

        public void SetMeasurements()
        {
            _tempreture.Element = WeatherElementGenerator.GetTempreture();
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
                o.Update(_tempreture);
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
