using Strategy.Implementations;
using System;

namespace Strategy
{
    public class StrategyDemo
    {
        public static void Start()
        {
            var sabya = new PermanentEmployee(1, "Sabyasachi", 100000, 1, new PermanentEmpType(), new PermanentEmployeeHike(), new PermanentEmployeeBonus(), new PermanentEmpHolidays());
            var hike = sabya.GetHike();
            var bonus = sabya.GetBonus();
            var holidays = sabya.GetHolidays();
        }
    }
}