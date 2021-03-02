using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoIdGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank ourBank = new Bank("Mawa's Bank", 5);
            for (int i = 0; i < 5; i++)
            {
                ourBank.AddAccount(new Account("Jannatul", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));
                ourBank.AddAccount(new Account("Mawa", 3000, new Address("40", "30", "Barishal", "Bangladesh")));
                ourBank.AddAccount(new Account("Sornale", 4000, new Address("40", "30", "Dhaka", "Bangladesh")));
                
            }

            Console.WriteLine("   \n ");

            Console.WriteLine("Welcome to the " + ourBank.BankName);

            Console.WriteLine("Choose from the Below Option");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Withdraw Balance");
            Console.WriteLine("3. Deposit Balance");
            Console.WriteLine("4. Transfer Balance");
            Console.WriteLine("5. Delete Account");
            Console.WriteLine("6. Show Account Details ");

            Console.WriteLine("You have choosed to create Account");
            Console.WriteLine("\n");

            ourBank.AddAccount(new Account("Mawa", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));

            Console.WriteLine("Account Created");


            Console.WriteLine("You have Choosed to Deposit Money\n");

            ourBank.Transaction(3);

            ourBank.Transaction(2);

            Console.WriteLine("You have Choosed to Transfer Balance \n");
            ourBank.Transaction(4);

            Console.WriteLine("You have Choosed to Delete Your Account\n");

            ourBank.Deleteccount(2002);


            Console.WriteLine("Here is the All of the Accounts of the Bank\n");
            ourBank.PrintAllAccount();




        }
    }
}
