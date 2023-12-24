namespace AbstractFactory.Factory
{
    public interface ICarFactory
    {
        IEngine CreateEngine();
        IChassis CreateChassis();
        IInterior CreateInterior();
    }
}
