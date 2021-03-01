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

              int number ;






              Bank mybank = new Bank();
            // mybank.Transaction(Convert.ToInt32(Console.ReadLine()));
            Address s1 = new Address();
            Account i1 = new Account();


            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("What do you want to do?\n");
                Console.WriteLine("	1. Create an Account");
                Console.WriteLine("	2. Withdraw Balance");
                Console.WriteLine("	3. Deposit Balance");
                Console.WriteLine("	4. Transfer Balance");
                Console.WriteLine("	5. Delete Account");
                Console.WriteLine("	6. Show Account Details ");

                Console.WriteLine("Your Choice: ");
                 Convert.ToInt32(Console.ReadLine());




                

                Console.WriteLine("Please Give Your Name=");
                i1.AccountName = Console.ReadLine();
                Console.WriteLine("Please Give Your Road No=");
                s1.RoadNo = Console.ReadLine();
                Console.WriteLine("Please Give Your Houseno=");
                s1.HouseNo = Console.ReadLine();
                Console.WriteLine("Please Give Your City=");
                s1.City = Console.ReadLine();
                Console.WriteLine("Please Give Your Country=");
                s1.Country = Console.ReadLine();

                s1.GetAddress();
                i1.print();




                Console.WriteLine("Please Give Your Balance You Want to Deposite=");
                i1.deposit(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please Give Your Balance You Want to Withdraw=");
                i1.withdraw(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Please Give Your Balance You Want to Transfer=");
                i1.transfer(i1, Convert.ToDouble(Console.ReadLine()));


            }





           // Address s1 = new Address();
               // Account i1 = new Account();

                // Console.WriteLine("Please Give Your Name=");
                // i1.AccountName = Console.ReadLine();
                 //Console.WriteLine("Please Give Your Road No=");
               // s1.RoadNo = Console.ReadLine();
                //Console.WriteLine("Please Give Your Houseno=");
                //s1.HouseNo = Console.ReadLine();
               // Console.WriteLine("Please Give Your City=");
                //s1.City = Console.ReadLine();
                //Console.WriteLine("Please Give Your Country=");
               // s1.Country = Console.ReadLine();

               s1.GetAddress();
               i1.print();


            Console.WriteLine("Please Give Your Balance You Want to Deposite=");
            i1.deposit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please Give Your Balance You Want to Withdraw=");
            i1.withdraw(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Please Give Your Balance You Want to Transfer=");
            i1.transfer(i1,Convert.ToDouble(Console.ReadLine()));



        }
    }
}
