namespace AbstractFactory.Factory
{
    public class SedanCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new SedanEngine();
        }

        public IChassis CreateChassis()
        {
            return new SedanChassis();
        }

        public IInterior CreateInterior()
        {
            return new SedanInterior();
        }
    }


    public class SedanEngine : IEngine
    {
        public string Start()
        {
            return "Sedan Engine started";
        }
    }

    public class SedanChassis : IChassis
    {
        public string Assemble()
        {
            return "Sedan Chassis assembled";
        }
    }

    public class SedanInterior : IInterior
    {
        public string Install()
        {
            return "Sedan Interior installed";
        }
    }
}
