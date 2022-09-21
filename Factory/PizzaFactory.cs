using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PizzaFactory
    {
        internal static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "TexMex")
            {
                return new TexMexPizza();
            } 
            else if (type == "Italiano")
            {
                return new ItalianoPizza();
            }
            else if (type == "PeriPeri")
            {
                return new PeriPeriPizza();
            }
            return pizza;
        }
    }
}
