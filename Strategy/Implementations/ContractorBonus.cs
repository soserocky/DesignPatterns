using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    internal class ContractorBonus : IBonus
    {
        public int GetBonus(int salary)
        {
            return salary / 10;
        }
    }
}
