using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Employee
    {
        internal int _id;
        internal string _name;
        internal int _salary;
        internal int _rating;
        internal IHike _iHike;
        internal IBonus _iBonus;
        internal IType _iType;
        internal IHolidays _iHolidays;
        public Employee(int id, string name, int salary, int rating, IType iType, IHike iHike, IBonus iBonus, IHolidays iHolidays)
        {
            _id = id;
            _name = name;
            _salary = salary;
            _rating = rating;
            _iType = iType;
            _iHike = iHike;
            _iBonus = iBonus;
            _iHolidays = iHolidays;
        }

        internal virtual int GetHike()
        {
            return _iHike.GetHike(_iType.GetEmployeeType(), _salary, _rating);
        }

        internal virtual int GetBonus()
        {
            return _iBonus.GetBonus(_salary);
        }
        
        internal virtual int GetHolidays()
        {
            return _iHolidays.GetHolidays();
        }
    }
}
