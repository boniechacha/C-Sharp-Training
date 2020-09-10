using System;
using System.Text;
using SoftNetTraining.Banking;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class BankingApp
    {
        private static Bank _bank = new Bank();

        public static void Run()
        {
            Console.Clear();
            int option = CaptureOption();
            switch (option)
            {
                case 1:
                    CreateAccount();
                    Run();
                    break;
                case 2: 
                    ListAccounts();
                    Run();
                    break;
                case 3:
                    Deposit();
                    Run();
                    break;
                
                default:
                    Run();
                    break;
            }
        }

        private static void Deposit()
        {
            string number = ConsoleUtil.CaptureInputString("Enter account number");
            Account account = _bank.FindAccount(number);
            if (account != null)
            {
                double amount = ConsoleUtil.CaptureInputDouble("Enter amount to deposit");
                double newBalance = account.Deposit(amount);
                Console.WriteLine("Your new balance is {0}",newBalance);
            }
            else
            {
                Console.WriteLine("No account with number {0}",number);
            }
        }

        private static void ListAccounts()
        {
            foreach (Account account in _bank.Accounts)
            {
                Console.WriteLine(account.getInfo());
            }
            
        }

        private static void CreateAccount()
        {
            string name = ConsoleUtil.CaptureInputString("Account Name");
            string number = ConsoleUtil.CaptureInputString("Account Number");

            Current current = new Current(name, number);
            _bank.AddAccount(current);

        }

        private static int CaptureOption()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("Select Your Option:");
            menu.AppendLine("1. Create current account");
            menu.AppendLine("2. List all account");
            menu.AppendLine("3. Deposit");
            menu.AppendLine("4. WithDraw");
            menu.AppendLine("5. Find Account");

            return ConsoleUtil.CaptureInputInt(menu.ToString());
        }
    }
}