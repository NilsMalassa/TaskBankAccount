namespace TaskBankAccount;

public enum AccountType
{
    Checking,
    Saving,
}

/// <summary>
/// manages attributes and behavior of a Bankaccount
/// </summary>
public class Bankaccount
{
    private readonly AccountType _type;
    private readonly int _accountNumber;
    private decimal _balance;


    /// <summary>
    /// constructs an object of that class and assigns a random 9-digit number to Account Number
    /// </summary>
    /// <param name="type"></param>
    public Bankaccount(AccountType type)
    {
        _type = type;
        Random random = new Random();
        _accountNumber = random.Next(100000000, 999999999);
    }


    /// <summary>
    /// validates if the amount is positive and less or equal to balance before decreasing balance
    /// </summary>
    /// <param name="amount"></param>
    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("The amount cannot be negative.");
            return;
        }

        if (_balance < amount)
        {
            Console.WriteLine("The amount cannot be greater than the balance.");
            return;
        }

        this._balance -= amount;
    }

    /// <summary>
    /// validates if amount is positive before increasing balance
    /// </summary>
    /// <param name="amount"></param>
    private void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("The amount cannot be negative");
            return;
        }

        this._balance += amount;
    }

    public void ShowAccountInfo()
    {
        Console.WriteLine($"Account Type: {_type}\nAccount Number: {_accountNumber}\nBalance: {_balance}");
    }

    /// <summary>
    /// validates if amount is positive and not greater than balance before
    /// decreasing own and increasing target balance
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="targetAccount"></param>
    public void TransferMoney(decimal amount, Bankaccount targetAccount)
    {
        if (amount < 0)
        {
            Console.WriteLine("The amount cannot be negative.");
            return;
        }

        if (_balance < amount)
        {
            Console.WriteLine("The amount cannot be greater than the balance.");
            return;
        }

        this._balance -= amount;
        targetAccount.Deposit(amount);
    }
}