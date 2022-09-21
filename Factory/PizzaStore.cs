using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PizzaStore
    {
        internal static Pizza OrderPizza(string type)
        {
            var pizza = PizzaFactory.CreatePizza(type);

            pizza.AddIngredients();
            pizza.Bake();
            pizza.Box();

            return pizza;
        }
    }
}
