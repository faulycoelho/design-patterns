using Builder.Builders;
using Builder;

ICarBuilder sedanBuilder = new SedanCarBuilder();
CarDirector sedanDirector = new CarDirector(sedanBuilder);
sedanDirector.Construct();
CarConcrete sedanCar = sedanBuilder.Build();
Console.WriteLine("Sedan Car: " + sedanCar);
Console.WriteLine();


ICarBuilder suvBuilder = new SuvCarBuilder();
CarDirector suvDirector = new CarDirector(suvBuilder);
suvDirector.Construct();
CarConcrete suvCar = suvBuilder.Build();
Console.WriteLine("SUV Car: " + suvCar);
Console.WriteLine();

ICarBuilder sportsCarBuilder = new SportsCarBuilder();
CarDirector sportsCarDirector = new CarDirector(sportsCarBuilder);
sportsCarDirector.Construct();
CarConcrete sportsCar = sportsCarBuilder.Build();
Console.WriteLine("Sports Car: " + sportsCar);