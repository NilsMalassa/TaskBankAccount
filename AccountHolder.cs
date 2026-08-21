namespace DefaultNamespace
{
    public class AccountHolder
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        //public List<Bankaccount> Bankaccounts;

        private AccountHolder(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
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
        }

        public void AddNewAccount()
        {
        }
    }
}