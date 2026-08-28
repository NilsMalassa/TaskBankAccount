namespace TaskBankAccount;

/// <summary>
/// manages AccountHolders and attributes of a bank
/// </summary>
public class Bank
{
    #region attributes

    public string Name { get; }
    private readonly List<AccountHolder> _accountHolders;

    #endregion


    #region constructor

    /// <summary>
    /// initializes a new AccountHolder list when constructing
    /// </summary>
    public Bank(string name)
    {
        Name = name;
        _accountHolders = new();
    }

    #endregion

    
    #region methods

    public void AddNewAccountHolder(AccountHolder accountHolder)
    {
        _accountHolders.Add(accountHolder);
    }

    public void RemoveAccountHolder(AccountHolder accountHolder)
    {
        _accountHolders.Remove(accountHolder);
    }

    #endregion
}