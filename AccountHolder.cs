namespace TaskBankAccount
{
    public class AccountHolder
    {
        public string Name { get; }
        public string Surname { get; private set; }
        public int Age { get; }
        readonly List<Bankaccount>_bankaccounts;

        private AccountHolder(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            _bankaccounts = new();
        }

        public static AccountHolder? TryCreateNewAccountHolder(string surname, string name, int age,
            out string errorMessage)
        {
            if (age < 18)
            {
                errorMessage = "You are not old enough for Registration.";
                return null;
            }

            errorMessage = string.Empty;
            return new AccountHolder(name, surname, age);
        }

        public void ShowOwnBankAccounts()
        {
            foreach (var bankAccount in _bankaccounts)
            {
                bankAccount.ShowAccountInfo();
            }
        }

        public void AddNewAccount(Bankaccount newAccount)
        {
            if (_bankaccounts.Contains(newAccount))
            {
                Console.WriteLine("Account already exists.");
                return;
            }
            
            _bankaccounts.Add(newAccount);
            Console.WriteLine("New account added.");
        }
    }
}