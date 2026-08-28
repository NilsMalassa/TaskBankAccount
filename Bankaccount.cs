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
    #region fields

    private readonly AccountType _type;
    private readonly int _accountNumber;
    private decimal _balance;

    #endregion


    #region constructors

    /// <summary>
    /// assigns a random 9-digit number to Account Number when constructing
    /// </summary>
    public Bankaccount(AccountType type)
    {
        _type = type;
        Random random = new Random();
        _accountNumber = random.Next(100000000, 999999999);
    }

    #endregion

    #region methods

    /// <summary>
    /// validates if the amount is positive and less or equal to balance before decreasing balance
    /// </summary>
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

    #endregion
}