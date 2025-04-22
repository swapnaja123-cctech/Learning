namespace DIUsingMethodInjection
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
            Console.WriteLine("Print Details of CurrentAccount");
        }
    }
    class Account
    {
        public void PrintAccount(IAccount account)
        {
            account.printDetails();
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                Account sa = new Account();
                sa.PrintAccount(new SavingAccount());


                Account ca = new Account();
                ca.PrintAccount(new CurrentAccount());


                // Console.WriteLine("Hello, World!");
            }
        }
    }
}
