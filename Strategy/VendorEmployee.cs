using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class VendorEmployee : Employee
    {
        public VendorEmployee(int id, string name, int salary, int rating, IType iType, IHike iHike, IBonus iBonus, IHolidays iHolidays) : base(id, name, salary, rating, iType, iHike, iBonus, iHolidays)
        {
        }
    }
}
