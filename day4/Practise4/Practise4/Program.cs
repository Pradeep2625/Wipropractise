using System;

class Account
{
    // Define properties
    // Complete Step 1:............
    public string AccountNumber;
    public decimal Balance;
    public string OwnerName;

    // Define methods
    // Complete Step 2:............
    public decimal Depositing(decimal amount)
    {
        return Balance += amount;
    }
    public decimal Withdrawing(decimal amount)
    {
        return Balance -= amount;

    }
    public decimal AccountBalance()
    {
        return Balance;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Account ac = new Account();
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        ac.AccountNumber = Console.ReadLine();
        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        ac.OwnerName = Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............

        Console.Write("Deposited: $");
        ac.Depositing(Convert.ToDecimal(Console.ReadLine()));
        Console.WriteLine("Account Balance: $"+ac.AccountBalance());
        Console.Write("Withdrew: $");
        ac.Withdrawing(Convert.ToDecimal(Console.ReadLine()));
        Console.Write("Account Balance: $"+ac.AccountBalance());
       

        // Perform transactions
        // Complete Step 6:............
    }
}