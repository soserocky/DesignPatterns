using Strategy.Enums;
using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    internal class ContractorEmpType : IType
    {
        public EmployeeType GetEmployeeType()
        {
            return EmployeeType.Contractor;
        }
    }
}
