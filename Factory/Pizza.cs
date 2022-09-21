using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal abstract class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }

        internal virtual void AddIngredients()
        {
            Console.WriteLine("Ingredients added");
        }

        internal virtual void Box()
        {
            Console.WriteLine("Pizza boxed");
        }

        internal virtual void Bake()
        {
            Console.WriteLine("Pizza baked");
        }
    }
}
