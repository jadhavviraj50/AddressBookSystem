using System;
using AddressBook;

namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------WelCome To Address Book Program------");
            Contacts contact = new Contacts();
            AddAddressBook book = new AddAddressBook();
            book.AddContacts();
            book.Display();

        }
    }
}