using Strategy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    internal interface IHike
    {
        int GetHike(EmployeeType empType, int salary, int rating);
    }
}
