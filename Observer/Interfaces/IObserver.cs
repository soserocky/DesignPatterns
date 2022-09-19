using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Observer.Enums.Enums;

namespace Observer.Interfaces
{
    internal interface IObserver
    {
        void GetUpdate(WeatherComponent weatherComponent, NewsBroadcaster weatherAgency, string weatherComponentValue);
    }
}
