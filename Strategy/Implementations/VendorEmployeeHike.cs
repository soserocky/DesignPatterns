using Strategy.Enums;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    internal class VendorEmployeeHike : IHike
    {
        public int GetHike(EmployeeType empType, int salary, int rating)
        {
            if (rating == 1) return salary * 13 / 10;
            else if (rating == 2) return salary * 11 / 10;
            else return salary * 105 / 100;
        }
    }
}
