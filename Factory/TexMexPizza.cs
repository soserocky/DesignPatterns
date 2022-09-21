namespace Factory
{
    internal class TexMexPizza : Pizza
    {
        public TexMexPizza()
        {
            Name = "TexMex";
            Description = "Thin crust, with cheese, white sauce";
        }
        internal override void AddIngredients()
        {
            base.AddIngredients();
            Console.WriteLine("cheese, white sauce");
        }
    }
}