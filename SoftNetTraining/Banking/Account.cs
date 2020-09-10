using System;

namespace SoftNetTraining.Banking
{
    public abstract class Account : IComparable<Account>
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public double Balance { protected set; get; }


        protected Account(string name, string number)
        {
            this.Name = name;
            this.Number = number;
            this.Balance = 0.0;
        }

        public string this[string key]
        {
            get
            {
                if (key == "Name") return Name;
                else if (key == "Number") return Number;
                else
                {
                    throw new ArgumentException();
                }
            }

            set
            {
                if (key == "Name")
                {
                    Name = value;
                }
                else if (key == "Number")
                {
                    Number = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string getInfo()
        {
            return $"{Number,-10} {Name,-10} | {Balance,10}";
        }


        public abstract double WithDraw(double amount);

        public abstract double Deposit(double amount);

        public int CompareTo(Account other)
        {
            if (this.Balance > other.Balance) return +1;
            else if (this.Balance < other.Balance) return -1;
            else return 0;
        }
        
    }
}