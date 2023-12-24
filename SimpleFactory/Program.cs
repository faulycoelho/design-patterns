using SimpleFactory;

Console.WriteLine("Which one:");
Console.WriteLine("1) Simples Coffee");
Console.WriteLine("2) Cappuccino");
Console.WriteLine("3) Macchiato");

var beverage = CoffeeFactory.CreateBeverage(Console.ReadLine());
beverage.Prepare();
beverage.Serve();
Console.ReadKey();