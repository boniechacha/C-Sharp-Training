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
            this.balance = this.balance - amount;
            return this.balance;
        }

        public override double Deposit(double amount)
        {
            this.balance = this.balance + amount;
            return this.balance;
        }
    }
}