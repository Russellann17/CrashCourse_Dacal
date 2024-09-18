using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class L12_Bank
    {
        public static void Lesson12()
        {
            Console.WriteLine("\n\nSIMPLE BANK SYSTEM\n\n");

            Console.Write("\nAccount Holder Name : ");
            string accountHolderName = Console.ReadLine();
            
            Console.Write("Account Number      : ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Balance             : ");
            float balance = Convert.ToSingle(Console.ReadLine());

            L12_Bank bank = new L12_Bank(accountHolderName, accountNumber, balance);
            bank.DisplayAccountInfo();

            bool exit = true;

            while (exit)
            {
                Console.WriteLine("What Do you want to do? Choose 1 or 2" +
                                  "\n[1] Withdraw" +
                                  "\n[2] Deposit" +
                                  "\n[3] Exit");
                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("\nHow much do you want to withdraw?");
                    float Wamount = Convert.ToSingle(Console.ReadLine());
                    bank.Withdraw(Wamount);
                    bank.DisplayAccountInfo();
                }
                else if (choice == 2)
                {
                    Console.Write("How much do you want to deposit?");
                    float Damount = Convert.ToSingle(Console.ReadLine());
                    bank.Deposit(Damount);
                    bank.DisplayAccountInfo();
                }
                else
                {
                     exit = false;
                    Console.WriteLine("Exiting the Bank System.");
                }
            }
        }

        private string accountHolderName;
        private int accountNumber;
        private float balance;

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set {
                if (value >= 10000) accountNumber = value;
                else Console.WriteLine("Invalid Account Number");
            }
        }

        public float Balance
        {
            get { return balance; }
            set {
                if (value > 0.0f) balance = value;
                else Console.WriteLine("Balance cannot be negative."); }
        }
        public L12_Bank(string accountHolderName, int accountNumber, float balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(float amount)
        {
            if (amount <= 0) Console.WriteLine("Deposit amount must be positive.");
            else
            {
                Console.WriteLine("Deposited Successfully!");
                balance += amount;
            }
        }

        public void Withdraw(float amount)
        {
            if (amount <= 0) Console.WriteLine("Withdrawal amount must be positive.");
            else
            {
                Console.WriteLine("Sucess Withdrawal!");
                balance -= amount;
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("\n\nAccount Details:" +
                "\nAccount Holder : " + accountHolderName +
                "\nAccount Number : " + accountNumber +
                "\nBalance        : " + balance);
        }

    }
}
