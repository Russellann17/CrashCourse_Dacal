using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    internal class L13_Notification
    {
        public static void L13_Polymorphism()
        {
            Console.WriteLine("Simple Email Notification");
            Console.Write("Email     : ");
            string email = Console.ReadLine();
            Console.Write("Phone No. : ");
            string number = Console.ReadLine();

            Notification emailNotif = new EmailNotification(email);
            emailNotif.Send();

            Notification smsNotif = new SMSNotification(number);
            smsNotif.Send();

        }
    }

    class Notification
    {
        virtual public void Send()
        {
            Console.WriteLine("Sending notification.");
        }
    }

    class EmailNotification : Notification
    {
        private string email;

        public EmailNotification (string email)
        {
            this.email = email;
        }

        override public void Send() 
        {
            Console.WriteLine("Sending email to " + email);
        }
    }

    class SMSNotification : Notification
    {
        private string number;

        public SMSNotification (string number)
        {
            this.number = number;
        }

        override public void Send()
        {
            Console.WriteLine ("Sending SMS to " + number);
        }
    }


}
