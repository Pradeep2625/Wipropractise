using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class BankingSystem
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }
        public string AccountHolderName { get; set; }


        public BankingSystem(string accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = 0.0m; // Initialize balance to zero

        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0) { 
                Console.WriteLine("Deposit amount must be positive.");
            }
            lock (this)
            {
                Balance += amount;
                Thread.Sleep(1000); // Simulate some delay for the deposit operation 
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                Console.WriteLine("Withdrawal amount must be positive or Insufficient funds .");
            }
            lock (this)
            {
                Balance -= amount;
                Thread.Sleep(1000); // Simulate some delay for the withdrawal operation 
            }
        }

    }
}
    
    