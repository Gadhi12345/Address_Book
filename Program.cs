using System;
using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string Phone;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            Console.Write("Enter number of contacts: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Contact c = new Contact();

                Console.Write("Enter First Name: ");
                c.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                c.LastName = Console.ReadLine();

                Console.Write("Enter Phone: ");
                c.Phone = Console.ReadLine();

                contacts.Add(c);
            }

            Console.Write("\nEnter First Name to Delete: ");
            string name = Console.ReadLine();

            Contact found = null;

            foreach (var c in contacts)
            {
                if (c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    found = c;
                    break;
                }
            }

            if (found != null)
            {
                contacts.Remove(found);
                Console.WriteLine("Contact Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Contact Not Found!");
            }

            Console.WriteLine("\nRemaining Contacts:");
            foreach (var c in contacts)
            {
                Console.WriteLine(c.FirstName + " " + c.LastName + " | " + c.Phone);
            }
        }
    }
}