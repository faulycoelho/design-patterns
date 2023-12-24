using AbstractFactory.Factory;


BuildCar(new SedanCarFactory());
BuildCar(new SuvCarFactory());



void BuildCar(ICarFactory factory)
{
    var engine = factory.CreateEngine();
    var chassis = factory.CreateChassis();
    var interior = factory.CreateInterior();

    Console.WriteLine(engine.Start());
    Console.WriteLine(chassis.Assemble());
    Console.WriteLine(interior.Install());
}
