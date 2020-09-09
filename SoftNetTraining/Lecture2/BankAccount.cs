using System;

namespace SoftNetTraining.Lecture2
{
    public class BankAccount
    {
        protected int balance = 0;
        private readonly string bankName = "CRDB";
        protected string accountName;
        
        public BankAccount()
        {
        }

        public BankAccount(string bankName, string accountName)
        {
            this.bankName = bankName;
            this.accountName = accountName;
        }

        public string AccountName
        {
            get
            {
                return accountName;
            }
            
            set
            {
                accountName = value;
            }
        }

        public  virtual void changeBalance(int newBalance, string username, string password)
        {
            balance = newBalance;
            Console.WriteLine("Changing balance for " + accountName);
        }

        public void SendMonthlyReport()
        {
            Console.WriteLine("Sending monthly report for " + accountName);
        }
    }
}