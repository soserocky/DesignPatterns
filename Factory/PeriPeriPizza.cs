using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class PeriPeriPizza : Pizza
    {
        public PeriPeriPizza()
        {
            Name = "PeriPeri";
            Description = "Thick crust, with mayonnaise burst, peri peri sauce, capsicum";
        }

        internal override void AddIngredients()
        {
            base.AddIngredients();
            Console.WriteLine("mayonnaise, peri peri sauce, capsicum");
        }
    }
}
