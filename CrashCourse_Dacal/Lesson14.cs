using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    internal class Lesson14
    {
        public static void L14_Payment()
        {
            PaymentMethod ewallet = new EwalletPayment();
            PaymentMethod creditCard = new CreditCardPayment();
            PaymentMethod cash = new CashPayment();

            Console.WriteLine("\nPayment Method: " +
                "\n[1] E-wallet" +
                "\n[2] Credit Card" +
                "\n[3] Cash");
            Console.Write("Choose: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Amount: ");
                float amount = Convert.ToSingle(Console.ReadLine());
                ewallet.ProcessPayment(amount);
            }
            else if (choice == 2)
            {
                Console.Write("Amount: ");
                float amount = Convert.ToSingle((Console.ReadLine()));
                creditCard.ProcessPayment(amount);
            }
            else if (choice == 3)
            {
                Console.Write("Amount: ");
                float amount = Convert.ToSingle(((Console.ReadLine())));
                cash.ProcessPayment(amount);
            }
            else Console.WriteLine("Invalid Input!");
        }
    }
    abstract class PaymentMethod
    {
        public abstract void ProcessPayment(float amount);
    }

    class EwalletPayment : PaymentMethod
    {
        public override void ProcessPayment(float amount)
        {
            Console.WriteLine("Processing e-wallet payment with the amount of " +  amount + " pesos.\n\n");
        }
    }

    class CreditCardPayment : PaymentMethod
    {
        public override void ProcessPayment(float amount)
        {
            Console.WriteLine("Processing credit card payment with the amount of " + amount + " pesos.\n\n");
        }
    }

    class CashPayment : PaymentMethod
    {
        public override void ProcessPayment(float amount)
        {
            Console.WriteLine("Processing cash payment with the amount of " + amount + " pesos.\n\n");
        }
    }
}
