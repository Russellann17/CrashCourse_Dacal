using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson19
    {
        static List<Contact> contacts = new List<Contact>();
        public static void RunContact()
        {
            while (true)
            {
                Console.WriteLine("\n\"CONTACT MANAGEMENT SYSTEM\"" +
                    "\n[1] Add Contact" +
                    "\n[2] Display Contacts" +
                    "\n[3] Search Contact" +
                    "\n[0] Exit ");
                Console.Write("Choose an option:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        DisplayContacts();
                        break;
                    case 3:
                        SearchContact();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Name  : ");
            string name = Console.ReadLine();

            Console.Write("Email : ");
            string email = Console.ReadLine();
            
            if (email.Equals(null))
            {
                Console.WriteLine("Please enter an email.");
            }
            else
            {
                contacts.Add(new Contact(name,email));
                Console.WriteLine("Contact added Successfully!");
            }
        }

        static void DisplayContacts()
        {
            Console.WriteLine("\nContacts List:");
            foreach (var contact in contacts)
            {
                Console.WriteLine("\nName  : " + contact.Name + "\nEmail : " + contact.Email);
            }
        }

        static void SearchContact()
        {
            Console.WriteLine("\nEnter name to search: ");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (var contact in contacts)
            {
                if (contact.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("FOUND! \nName  : " + contact.Name + "\nEmail : " + contact.Email);
                    found = true;
                }

                else if (!found)
                {
                    Console.WriteLine("Contact not found.");
                }
                }
        }
    }

    class Contact
    {
        public string Name { get; }
        public string Email { get; }

        public Contact(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
