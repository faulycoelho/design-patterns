namespace SimpleFactory
{
    public sealed class CoffeeFactory
    {
        public static Beverages CreateBeverage(string type)
        {
            switch (type)
            {
                case "1":
                    return new SimpleCoffee();

                case "2":
                    return new Capuccino();

                case "3":
                    return new Macchiato();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
