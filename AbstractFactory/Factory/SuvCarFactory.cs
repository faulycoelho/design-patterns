namespace AbstractFactory.Factory
{
    public class SuvCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new SuvEngine();
        }

        public IChassis CreateChassis()
        {
            return new SuvChassis();
        }

        public IInterior CreateInterior()
        {
            return new SuvInterior();
        }
    }

    public class SuvEngine : IEngine
    {
        public string Start()
        {
            return "SUV Engine started";
        }
    }

    public class SuvChassis : IChassis
    {
        public string Assemble()
        {
            return "SUV Chassis assembled";
        }
    }

    public class SuvInterior : IInterior
    {
        public string Install()
        {
            return "SUV Interior installed";
        }
    }

}
