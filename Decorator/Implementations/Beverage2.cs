using Decorator.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    internal class Beverage2 : Beverage
    {
        internal override int GetCost()
        {
            return 3;
        }

        internal override string GetDescription()
        {
            return "Beverage2";
        }
    }
}
