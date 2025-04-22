namespace DependencyInjectionDemo
{

    //Tight Coupling Example
    class SavingAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Saving Account");
        }
    }

    class CurrentAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account");
        }

    }
    class Account
    {
        CurrentAccount ca = new CurrentAccount();

        SavingAccount sa = new SavingAccount(); 

        public void PrintAccounts()
        {
            ca.PrintDetails();
            sa.PrintDetails();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.PrintAccounts();

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
