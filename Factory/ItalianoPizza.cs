using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class ItalianoPizza : Pizza
    {
        public ItalianoPizza()
        {
            Name = "Italiano";
            Description = "Thin crust, with mayonnaise, olives, tomato";
        }

        internal override void AddIngredients()
        {
            base.AddIngredients();
            Console.WriteLine("mayonnaise, olives, tomato");
        }
    }
}
