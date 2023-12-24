

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"Description: {coffee.GetDescription()}");
Console.WriteLine($"Cost: ${coffee.GetCost()}");

// Add Milk, Sugar, and Cream to the coffee
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);
coffee = new CreamDecorator(coffee);
Console.WriteLine($"Description: {coffee.GetDescription()}");
Console.WriteLine($"Cost: ${coffee.GetCost()}");

// Add Whipped Cream and Cinnamon to the coffee
coffee = new WhippedCreamDecorator(coffee);
coffee = new CinnamonDecorator(coffee);
Console.WriteLine($"Description: {coffee.GetDescription()}");
Console.WriteLine($"Cost: ${coffee.GetCost()}");



public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

public abstract class CoffeeDecorator : ICoffee
{
    private ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 1.0;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}
public class CreamDecorator : CoffeeDecorator
{
    public CreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Cream";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.75;
    }
}

public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Whipped Cream";
    }

    public override double GetCost()
    {
        return base.GetCost() + 1.25;
    }
}

public class CinnamonDecorator : CoffeeDecorator
{
    public CinnamonDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Cinnamon";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}