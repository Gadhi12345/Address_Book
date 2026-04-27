using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string Phone;
        public string Email;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            List<Contact> contacts = new List<Contact>();

            Console.Write("Enter number of contacts: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Contact c = new Contact();

                Console.Write("\nEnter First Name: ");
                c.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                c.LastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                c.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                c.City = Console.ReadLine();

                Console.Write("Enter State: ");
                c.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                c.Zip = Console.ReadLine();

                Console.Write("Enter Phone: ");
                c.Phone = Console.ReadLine();

                Console.Write("Enter Email: ");
                c.Email = Console.ReadLine();

                contacts.Add(c);
            }

            Console.Write("\nEnter First Name to Edit: ");
            string name = Console.ReadLine();

            foreach (var c in contacts)
            {
                if (c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Editing Contact...");

                    Console.Write("Enter New Address: ");
                    c.Address = Console.ReadLine();

                    Console.Write("Enter New City: ");
                    c.City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    c.State = Console.ReadLine();

                    Console.Write("Enter New Zip: ");
                    c.Zip = Console.ReadLine();

                    Console.Write("Enter New Phone: ");
                    c.Phone = Console.ReadLine();

                    Console.Write("Enter New Email: ");
                    c.Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully!");
                    break;
                }
            }

            Console.WriteLine("\nAll Contacts:");

            foreach (var c in contacts)
            {
                Console.WriteLine(c.FirstName + " " + c.LastName + " | " + c.Phone);
            }
        }
    }
}