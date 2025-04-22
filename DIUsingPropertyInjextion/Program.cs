namespace DIUsingPropertyInjextion
{


    interface IAccount
    {
        void printDetails();
    }

    class SavingAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Print Details of Saving Account");
        }
    }
    class CurrentAccount : IAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Print Details of Current Account");
        }
    }

    class Account
    {
        private IAccount account { get; set; }

        public void PrintAccounts()
        {
            account.printDetails();
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                Account sa = new Account();
                sa.account = new SavingAccount();
                sa.PrintAccounts();

                Account ca = new Account();
                ca.account = new CurrentAccount();
                ca.PrintAccounts();

                Console.WriteLine("Hello, World!");
            }
        }
    }
}
