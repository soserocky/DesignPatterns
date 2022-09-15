using Strategy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    internal interface IType
    {
        EmployeeType GetEmployeeType();
    }
}
