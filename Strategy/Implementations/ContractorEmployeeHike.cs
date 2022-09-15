using Strategy.Enums;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    internal class ContractorEmployeeHike : IHike
    {
        public int GetHike(EmployeeType empType, int salary, int rating)
        {
            if (rating == 1) return salary * 14 / 10;
            else if (rating == 2) return salary * 12 / 10;
            else return salary * 110 / 100;
        }
    }
}
