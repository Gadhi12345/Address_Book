using System;

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

            Contact contact = new Contact();

            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone: ");
            contact.Phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("\nContact Added Successfully:");
            Console.WriteLine(contact.FirstName + " " + contact.LastName);
        }
    }
}