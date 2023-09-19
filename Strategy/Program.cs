var cart = new ShoppingCart();

cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9012-3456", "Fauly Coelho"));
cart.Checkout(100);

cart.SetPaymentStrategy(new PayPalPayment("fauly.coelho@example.com"));
cart.Checkout(50);


public interface IPaymentStrategy
{
    void Pay(int amount);
}


public class CreditCardPayment : IPaymentStrategy
{
    private string cardNumber;
    private string name;

    public CreditCardPayment(string cardNumber, string name)
    {
        this.cardNumber = cardNumber;
        this.name = name;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with Credit Card ({cardNumber})");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private string email;

    public PayPalPayment(string email)
    {
        this.email = email;
    }

    public void Pay(int amount)
    {
        Console.WriteLine($"Paid ${amount} with PayPal ({email})");
    }
}

// Step 3: Create the Context class
public class ShoppingCart
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void Checkout(int amount)
    {
        paymentStrategy.Pay(amount);
    }
}