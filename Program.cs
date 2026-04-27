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
            Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();

            Console.Write("Enter number of address books: ");
            int bookCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < bookCount; i++)
            {
                Console.Write("\nEnter Address Book Name: ");
                string bookName = Console.ReadLine();

                List<Contact> contacts = new List<Contact>();

                Console.Write("Enter number of contacts: ");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < n; j++)
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

                addressBooks[bookName] = contacts;
            }

            Console.WriteLine("\nAll Address Books:");

            foreach (var book in addressBooks)
            {
                Console.WriteLine("\nBook: " + book.Key);

                foreach (var c in book.Value)
                {
                    Console.WriteLine(c.FirstName + " " + c.LastName + " | " + c.Phone);
                }
            }
        }
    }
}