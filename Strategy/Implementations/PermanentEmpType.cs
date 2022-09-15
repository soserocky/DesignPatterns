using Strategy.Enums;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    internal class PermanentEmpType : IType
    {
        public EmployeeType GetEmployeeType()
        {
            return EmployeeType.Permanent;
        }
    }
}
