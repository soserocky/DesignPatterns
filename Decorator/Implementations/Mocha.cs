using Decorator.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    internal class Mocha : Beverage
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }
        internal override int GetCost()
        {
            return this._beverage.GetCost() + 2;
        }

        internal override string GetDescription()
        {
            return this._beverage.GetDescription() + ", Mocha";
        }
    }
}
