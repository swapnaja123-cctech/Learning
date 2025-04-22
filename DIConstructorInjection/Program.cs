namespace DIConstructorInjection
{

    //********Loose Coupling using Constructor*********

    interface IAccount
    {
        void PrintDetails();
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Print Details of CurrentAccount");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Print Details of Saving Account");
        }
    }
    
    class Account
    {
        private IAccount account;

        public Account(IAccount account)//Parameterized Constructor
        {
            this.account = account;
        }

        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account account = new Account(ca);
            account.PrintAccounts();

            IAccount sa = new SavingAccount();
            Account account1 = new Account(sa);
            account.PrintAccounts();
            Console.WriteLine("Hello, World!");
        }
    }
}
