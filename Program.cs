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
        }
    }
}