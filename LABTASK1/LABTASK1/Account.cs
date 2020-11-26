using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK1
{
    class Account
    {
        private string accountName;
        private string accountId;
        double balance;
        double deposite;
        double withdraw;
        public string Accountname
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public string AccountID
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Deposite
        {
            get { return deposite; }
            set { deposite = value + balance; }
        }
        public double Withdraw
        {
            get { return withdraw; }
            set { withdraw = value - balance ; }
        }
        public void ShowDetails()
        {
            Console.WriteLine(" ACCOUNT NAME : "+ accountName);
            Console.WriteLine(" ACCOUNT ID   : "+ accountId);
            Console.WriteLine("   BALANCE    : "+ balance);
            Console.WriteLine("   DEPOSITE   : "+ deposite);
            Console.WriteLine("   WITHDRAW   : "+ withdraw);
        }



    }
}
