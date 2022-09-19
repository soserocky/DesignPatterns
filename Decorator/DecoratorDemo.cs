using Decorator.Abstract_Classes;
using Decorator.Implementations;

namespace Decorator
{
    public class DecoratorDemo
    {
        public static void Start()
        {
            Beverage beverage1 = new Beverage1();
            Beverage soy1 = new Soy(beverage1);
            Beverage mocha1 = new Mocha(soy1);

            var cost1 = mocha1.GetCost();
            var description1 = mocha1.GetDescription();

            Beverage beverage2 = new Beverage2();
            Beverage mocha2 = new Mocha(beverage2);

            var cost2 = mocha2.GetCost();
            var description2 = mocha2.GetDescription();
        }
    }
}