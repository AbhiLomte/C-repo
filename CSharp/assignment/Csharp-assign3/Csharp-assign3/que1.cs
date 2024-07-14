using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assign3
{
    public class Accounts
    {
        private String account_No;
        private String Customer_name;
        private String Account_type;
        private Char Transaction_type;
        private int Amount;
        private int Balance = 0;

        public Accounts(string account_No, string Customer_name, string Account_type)
        {
            this.account_No = account_No;
            this.Customer_name = Customer_name;
            this.Account_type = Account_type;

        }

        public void Credit(int Amount)
        {
            Balance += Amount;
        }

        public void Debit(int Amount)
        {
            if (Balance >= Amount)
            {
                Balance -= Amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("Account Number:{0}", account_No);
            Console.WriteLine("Customer Name:{0}", Customer_name);
            Console.WriteLine("Account type:{0}", Account_type);
            Console.WriteLine("Balance:{0}", Balance);


        }
        public void PerformTransaction(char transactionType, int Amount)
        {
            if (transactionType == 'D')
            {
                Credit(Amount);
            }
            else if (transactionType == 'W')
            {
                Debit(Amount);
            }
            else
            {
                Console.WriteLine("Invalid transactiontype");
            }
        }
        public static void Main(string[] args)
        {
            Accounts accountobj = new Accounts("123456", "Abhishek", "Savings");

            accountobj.PerformTransaction('D', 50000);
            accountobj.ShowData();
            Console.WriteLine("---------------------------------------------------");
            accountobj.PerformTransaction('W', 20000);

            accountobj.ShowData();
            Console.WriteLine("---------------------------------------------------");
            accountobj.PerformTransaction('a', 50000);
            accountobj.ShowData();
            Console.WriteLine("---------------------------------------------------");
            accountobj.PerformTransaction('W', 100000);
            accountobj.ShowData();
            Console.WriteLine("---------------------------------------------------");
            Console.Read();






        }
    }
}
