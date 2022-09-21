using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FactoryManager
    {
        internal static IFactory GetFactory(string type)
        {
            IFactory factory = null;

            if (type == "apple")
            {
                return new AppleFactory();
            }
            else if (type == "samsung")
            {
                return new AppleFactory();
            }
            return factory;
        }
    }
}
