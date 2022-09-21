using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PizzaStore
    {
        internal Pizza OrderPizza(string type)
        {
            var pizza = PizzaFactory.CreatePizza(type);

            if (pizza == null) return null;

            pizza.AddIngredients();
            pizza.Bake();
            pizza.Box();

            return pizza;
        }
    }
}
