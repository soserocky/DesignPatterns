using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Observer.Enums.Enums;

namespace Observer.Interfaces
{
    internal interface ISubject
    {
        public string Temperature { get; set; }
        public string Humidity { get; set; }
        public string WindSpeed { get; set; }
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(NewsBroadcaster newsAgency, string weatherComponentValue);
    }
}
