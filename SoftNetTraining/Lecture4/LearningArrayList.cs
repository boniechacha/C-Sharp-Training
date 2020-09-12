using System;
using System.Collections;
using System.Collections.Generic;
using SoftNetTraining.Banking;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningArrayList
    {
        public static void Run()
        {
            // ArrayList data = new ArrayList() {2, 4, 6};
            ArrayList data = new ArrayList();
            data.Add(2);
            data.Add(4);
            data.Add(6);

            ConsoleUtil.Display(data);

            object d1 = data[0];
            int d11 = (int) data[0];


            List<string> d = new List<string>();
            d.Add("Chacha");
            d.Add("Juma");
            d.Add("Boniface");

            Console.WriteLine(d.IndexOf("Ferouz"));

            ConsoleUtil.Display(d);

            d.Insert(1, "Michael");
            // d[1] = "Michael";
            ConsoleUtil.Display(d);

            d.Remove("Chacha");
            // d.RemoveAt(2);
            ConsoleUtil.Display(d);

            d.RemoveAt(1);
            ConsoleUtil.Display(d);


            List<Account> accounts = new List<Account>();

            Current a1 = new Current(
                "Chacha",
                "123"
            );

            Current a2 = new Current("Michael", "876");
            Saving a3 = new Saving("Ferouz", "789", 1000);

            accounts.Add(
                a1
            );
            accounts.Add(a2);
            accounts.Add(a3);


            Account myAccount = accounts.Find(
                c => { return c.Number == "123"; }
            );


            List<int> x = new List<int>() {1, 2, 3, 4, 5, 6, 7};
            List<int> x1 = x.FindAll(
                i => { return i % 2 != 0; });

            x1.FindAll(
                i => { return i > 3; }
            );


            List<int> x2 = new List<int>() {2, 4, 6};


            Account ferouzAccount = accounts.Find(
                account => { return account.Name == "Ferouz"; }
            );


            // Account myAccount = accounts.Find(
            //     account =>
            //     {
            //         return account.Number == "123";
            //     }
            //  );

            // accounts.Find(
            //     account =>
            //     {
            //         if (account.Name == "Ferouz") return true;
            //         else return false;
            //     });
        }


        public static bool checkAccountName(List<Account> accounts, string nameToCheck)
        {
            foreach (Account account in accounts)
            {
                if (account.Name == nameToCheck)
                {
                    return true;
                }
            }

            return false;
        }

        public static Account findAccountOfName(List<Account> accounts, string nameToCheck)
        {
            foreach (Account account in accounts)
            {
                if (account.Name == nameToCheck)
                {
                    return account;
                }
            }

            return null;
        }

        private static List<Account> CreateAccountList()
        {
            List<Account> accounts = new List<Account>();

            Current a1 = new Current("Chacha", "123");
            Current a2 = new Current("Michael", "876");
            Saving a3 = new Saving("Ferouz", "789", 1000);

            accounts.Add(a1);
            accounts.Add(a2);
            accounts.Add(a3);

            return accounts;
        }


        private static void Finding()
        {
            // Predicate<Account> predicate =
            //     account =>
            //     {
            //         return account.Number == "123";
            //     };
            //
            // List<Account> accounts = CreateAccountList();
            // Account account = accounts.Find(predicate);
            
            
           
            List<Account> accounts = CreateAccountList();
            Account account = accounts.Find(
                account =>
                {
                    return account.Number == "123";
                }
           );
            
            
        }
    }
}