using System.Collections;
using System.Collections.Generic;

namespace SoftNetTraining.Banking
{
    public class Bank : IEnumerable<Account>
    {
        public List<Account> Accounts { get; set; }

        public Bank()
        {
            Accounts = new List<Account>();
        }

        public void CreateCurrentAccount(string name, string number)
        {
            Current acc = new Current(name, number);
            Accounts.Add(acc);
        }

        public IEnumerator<Account> GetEnumerator()
        {
            return Accounts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public Account FindAccount(string number)
        {
            Account account = this.Accounts.Find(
                a =>
                {
                    return a.Number == number;
                }
             );

            return account;
        }
    }
}