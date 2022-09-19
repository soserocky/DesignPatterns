using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Abstract_Classes
{
    internal abstract class Beverage
    {
        internal abstract int GetCost();

        internal abstract string GetDescription();
    }
}
