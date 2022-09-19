using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Observer.Enums.Enums;

namespace Observer.Subjects
{
    internal class GammaWeatherAgency : ISubject
    {
        internal NewsBroadcaster _weatherAgency = NewsBroadcaster.Gamma;
        private WeatherComponent _weatherComponent;
        private static IList<IObserver> _observers;
        private string _temperature;
        private string _humidity;
        private string _windSpeed;
        public string Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                _weatherComponent = WeatherComponent.Temperature;
                NotifyObservers(_weatherAgency, value);
            }
        }
        public string Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                _humidity = value;
                _weatherComponent = WeatherComponent.Humidity;
                NotifyObservers(_weatherAgency, value);
            }
        }
        public string WindSpeed
        {
            get
            {
                return _windSpeed;
            }
            set
            {
                _windSpeed = value;
                _weatherComponent = WeatherComponent.Wind_Speed;
                NotifyObservers(_weatherAgency, value);
            }
        }
        public GammaWeatherAgency()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(NewsBroadcaster weatherAgency, string weatherComponentValue)
        {
            foreach (var observer in _observers)
            {
                observer.GetUpdate(_weatherComponent, weatherAgency, weatherComponentValue);
            }
        }
    }
}
