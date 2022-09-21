namespace Factory
{
    public class FactoryDemo
    {
        public static void Start()
        {
            PizzaStore store = new PizzaStore();
            store.OrderPizza("PeriPeri");
        }
    }
}