using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class AbstractFactoryDemo
    {
        public static void Start()
        {
            IFactory factory = FactoryManager.GetFactory("samsung");

            if (factory == null)
            {
                Console.WriteLine("Sorry, could not find a factory");
                return;
            }

            Console.WriteLine(factory.GetDescription());
        }
    }
}