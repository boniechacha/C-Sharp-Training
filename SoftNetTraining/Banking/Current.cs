using System;
using SoftNetTraining.Lecture2;

namespace SoftNetTraining.Banking
{
    public class Current : Account
    {
        public Current(string name, string number) 
            : base(name, number)
        {
        }


        public override double WithDraw(double amount)
        {
            this.Balance = this.Balance - amount;
            return this.Balance;
        }

        public override double Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            return this.Balance;
        }
    }
}