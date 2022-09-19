using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Observer.Enums.Enums;

namespace Observer.Observers
{
    internal class CNNNews : IObserver
    {
        internal NewsChannels _newsAgency = NewsChannels.CNNNews;
        
        public void GetUpdate(WeatherComponent weatherComponent, NewsBroadcaster weatherAgency, string weatherComponentValue)
        {
            Console.WriteLine($"{weatherComponent.ToString()} update from {_newsAgency.ToString()}: {weatherAgency.ToString()} reports a value of {weatherComponentValue}");
        }
    }
}
