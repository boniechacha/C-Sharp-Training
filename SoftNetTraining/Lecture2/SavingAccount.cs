using System;

namespace SoftNetTraining.Lecture2
{
    public class SavingAccount : BankAccount
    {
        public SavingAccount()
        {
        }

        public SavingAccount(string bankName, string accountName)
            : base(bankName, accountName)
        {
        }

        public void doSomething()
        {
        }

        public void SendMonthlyReport()
        {
            Console.WriteLine("Sending monthly report for saving account " + accountName);
        }

        public override void changeBalance(int newBalance, string username, string password)
        {
            if (newBalance < 1_000_000)
            {
                throw new ArgumentException();
            }
            else
            {
                base.changeBalance(newBalance, username, password);
            }
        }
    }
}