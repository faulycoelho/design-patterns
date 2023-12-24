namespace SimpleFactory
{
    internal class Macchiato : Beverages
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing a Macchiato...");
        }

        public override void Serve()
        {
            Console.WriteLine("Macchiato is ready, serving...");
        }
    }
}
