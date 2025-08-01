using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableConcept
{
    internal class Example2
    {
        // Example of a bank account class with nullable properties
        // This class demonstrates the use of nullable types for transaction history.
        // It allows for deposits and withdrawals, and tracks the last transaction amount.
        // The ShowTransaction property is nullable, indicating that there may not always be a transaction to show.
        
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public Nullable<decimal> ShowTransaction { get; private set; }

        public Example2(string accountNumber, string accountHolderName)
        {
            AccountName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = 0.0m;
            ShowTransaction = null; // No transaction yet
        }
        public void  Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            Balance += amount;
            ShowTransaction = amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
                return;
            }
            Balance -= amount;
            ShowTransaction = amount;
        }




        public void ShowTransactionHistory()
        {
            if (ShowTransaction.HasValue)
            {
                Console.WriteLine($"{AccountName}'s last transaction: {ShowTransaction:C}");
            }
            else
            {
                Console.WriteLine($"{AccountName}'s last transaction: ");
            }
        }

        public static void Main()
        {
            Example2 example = new Example2("123456789","Deepu");
            example.Deposit(1000);
            example.Withdraw(500);
            example.ShowTransactionHistory();
            Example2 example1 = new Example2("1234569", "pradeep");
            example1.Deposit(2000);
            example1.Withdraw(400);
            example1.ShowTransactionHistory();

        }
    }
}
