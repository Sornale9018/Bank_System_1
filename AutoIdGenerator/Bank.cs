using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoIdGenerator
{
    class Bank
    {
        private Account[] myBank;
        private string name;
        

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }

        public void Deleteccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if(myBank[i].AccountNumber==accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted\n");
                    for(int j=i;j<myBank.Length-1;j++)
                    {myBank[j] = myBank[j + 1]; }
                }
            }
        }

        /*public void Transaction(int s)
        {
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
                 s = Convert.ToInt32(Console.ReadLine());
            }
        }*/

        public void PrintAllAccount()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].PrintAccount();
            }
        }

        







    }
}
