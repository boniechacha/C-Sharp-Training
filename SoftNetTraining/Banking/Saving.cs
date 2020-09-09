using System;

namespace SoftNetTraining.Banking
{
    public class Saving : Account
    {
        public double MinBalance;

        public Saving(string name, string number, double minBalance)
            : base(name, number)
        {
            this.MinBalance = minBalance;
        }

        public override double WithDraw(double amount)
        {
            if (balance > MinBalance)
            {
                balance = balance - amount;
                return balance;
            }
            else throw new ArgumentException();
        }

        public override double Deposit(double amount)
        {
            balance = balance + amount;
            return balance;
        }
    }
}