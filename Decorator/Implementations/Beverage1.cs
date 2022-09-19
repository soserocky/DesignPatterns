using Decorator.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    internal class Beverage1 : Beverage
    {
        internal override int GetCost()
        {
            return 5;
        }

        internal override string GetDescription()
        {
            return "Beverage1";
        }
    }
}
