using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreading
{
    internal class Program
    {
        static void User1()
        {
            BankingSystem user1 = new BankingSystem("123456789", "John Doe");
            user1.Deposit(1000);
            Console.WriteLine($"Final balance for after deposit {user1.AccountHolderName}: {user1.Balance:C}");
            user1.Withdraw(500);
            Console.WriteLine($"Final balance for after withdrawal {user1.AccountHolderName}: {user1.Balance:C}");
        }
        static void User2()
        {
            Thread.Sleep(2000); // Ensure User2 starts after User1
            BankingSystem user2 = new BankingSystem("1234565559", "Johny walker");
            user2.Deposit(2000);
            Console.WriteLine($"Final balance for after deposit {user2.AccountHolderName}: {user2.Balance:C}");
            user2.Withdraw(500);
            Console.WriteLine($"Final balance for after withdrawal {user2.AccountHolderName}: {user2.Balance:C}");
        }
        
           

        static void Main(string[] args)
        {
            
            
            ThreadStart user1 = new ThreadStart(User1);
            ThreadStart user2 = new ThreadStart(User2);

            Thread thread1 = new Thread(user1);
            Thread thread2 = new Thread(user2);
            thread1.Start();
            //thread1.Join();
            thread2.Start();
            //thread2.Join();


        }
    }
}
