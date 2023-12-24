namespace SimpleFactory
{
    public class Capuccino : Beverages
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing a Capuccino...");
        }

        public override void Serve()
        {
            Console.WriteLine("Capuccino is ready, serving...");
        }
    }
}
