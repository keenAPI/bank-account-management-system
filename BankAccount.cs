using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        private CultureInfo culture = new CultureInfo("en-ZA"); //SA Culture

        //Constructor to initialize the account holder's name and set an initial balance
        public BankAccount(string accountHolder, decimal initialBalance = 0)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        //Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount.ToString("C", culture)}. New balance: {Balance.ToString("C", culture)}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }

        //Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrew: {amount.ToString("C", culture)}. New balance: {Balance.ToString("C", culture)}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawel amount must be greater than 0.");
            }
        }

        //Method to check the account balance
        public void CheckBalance()
        {
            Console.WriteLine($"Account balance: {Balance.ToString("C", culture)}");
        }
    }
}
