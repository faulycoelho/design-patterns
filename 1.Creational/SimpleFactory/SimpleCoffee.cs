namespace SimpleFactory
{
    public class SimpleCoffee : Beverages
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing a Simple coffee...");
        }

        public override void Serve()
        {
            Console.WriteLine("Simple coffee is ready, serving...");
        }
    }
}
