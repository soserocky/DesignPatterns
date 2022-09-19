using Observer.Interfaces;
using Observer.Observers;
using Observer.Subjects;
using static Observer.Enums.Enums;

namespace Observer
{
    public class ObserverDemo
    {
        public static void Start()
        {
            ISubject alphaWeatherAgency = new AlphaWeatherAgency();
            alphaWeatherAgency.AddObserver(new BBCNews());
            alphaWeatherAgency.AddObserver(new CNNNews());
            alphaWeatherAgency.Temperature = "45";

            ISubject betaWeatherAgency = new BetaWeatherAgency();
            betaWeatherAgency.AddObserver(new TimesNews());
            betaWeatherAgency.AddObserver(new BBCNews());
            betaWeatherAgency.Humidity = "High";
        }
    }
}