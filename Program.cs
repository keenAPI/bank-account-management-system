using System.Threading.Channels;

namespace BankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Account Management");

            // Create an account
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();
            var account = new BankAccount(name);

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case "2":
                        Console.Write("Enter withdrawel amount: ");
                        decimal withdrawelAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawelAmount);
                        break;

                    case "3":
                        account.CheckBalance();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
