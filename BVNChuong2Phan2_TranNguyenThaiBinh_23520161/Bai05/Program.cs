// Abstract class

namespace Bai05;

public abstract class ABankAccount(string _id, string _owner)
{
    public string ID { get; protected set; } = _id ?? "";
    public string Owner { get; protected set; } = _owner ?? "";
    public decimal Balance { get; protected set; } = 0;

    public void Deposit(decimal Amount)
    {
        Balance += Amount;
    }

    public void Withdraw(decimal Amount)
    {
        Balance -= Amount;
    }

    public abstract bool IsSufficientFund(decimal Amount);

    public abstract void AddInterest();
};

public class BankAccount(string _id, string _owner) : ABankAccount(_id, _owner)
{
    public override bool IsSufficientFund(decimal Amount)
    {
        return Balance >= Amount;
    }

    public override void AddInterest()
    {
        Balance *= 1.05M;
    }
};

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAcct = new("100120023003", "Nguyen Van An");
        myAcct.Deposit(1000);
        myAcct.Withdraw(100);
        Console.WriteLine($"Balance: {myAcct.Balance}");
        Console.WriteLine($"Ability to paid 5000: {myAcct.IsSufficientFund(5000)}");
        myAcct.AddInterest();
        Console.WriteLine($"Balance after add interest: {myAcct.Balance}");
    }
}
