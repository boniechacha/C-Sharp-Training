using System;

namespace SoftNetTraining.Banking
{
    public class Fixed : Account
    {
        private DateTime MinWithdrawDate;

        public Fixed(string name, string number, DateTime minWithdrawDate) 
            : base(name, number)
        {
            MinWithdrawDate = minWithdrawDate;
        }

        public override double WithDraw(double amount)
        {
            if (DateTime.Today > MinWithdrawDate)
            {
                this.Balance = this.Balance - amount;
                return this.Balance;
            }
            else throw new ArgumentException();
        }

        public override double Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            return this.Balance;
        }
    }
}