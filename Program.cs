using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string Phone;
        public string City;
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

                Console.Write("Enter City: ");
                c.City = Console.ReadLine();

                contacts.Add(c);
            }

            Console.Write("\nEnter First Name to Search: ");
            string name = Console.ReadLine();

            bool found = false;

            foreach (var c in contacts)
            {
                if (c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContact Found:");
                    Console.WriteLine(c.FirstName + " " + c.LastName + " | " + c.Phone + " | " + c.City);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact Not Found!");
            }
        }
    }
}