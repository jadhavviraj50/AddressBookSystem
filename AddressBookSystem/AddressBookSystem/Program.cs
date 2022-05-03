using System;
using AddressBook;

namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------WelCome To Address Book Program------");
            bool end = true;
            Console.WriteLine("SelectNumber\n1.Add Contact\n2.Display\n3.EditContact\n4.DeleteContact\n5AddMultipleContact\n6.End Of Program");
            Contact contact = new Contact();
            AddressBookMain addContact = new AddressBookMain();
            while (end)
            {
                Console.WriteLine("choose program to exucute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.CreateContact();
                        break;
                    case 2:
                        addContact.Display();
                        break;
                    case 3:
                        addContact.EditContact();
                        break;
                    case 4:
                        addContact.DeleteContact();
                        break;
                    case 5:
                        addContact.AddMultipleContacts();
                        break;
                    case 6:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
}