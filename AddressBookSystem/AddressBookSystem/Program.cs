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
            Console.WriteLine("SelectNumber\n1)Add Contact\n2)Display\n3)EditContact\n4)DeleteContact\n5)AddMultipleContact\n6)Adding Unique Name\n7)DisplayUniqueNamen\n8)Search Person by city or State\n9)Count Persons by city or State\n10)View Person contacts By City\n11)View Person contacts By State\n12)Sorting alphabetically by Person’s name\n13)Sorting Persons Contacts By City \n14)Sorting Persons Contacts By State \n15)Sorting Persons Contacts By Zip\n16)Writing AddressBook Using File IO \n17)Reading AddressBook Using File IO\n18)Writing AddressBook Using File CSV \n19)Reading AddressBook Using File CSV\n20)Writing AddressBook Using File JSON \n21)Reading AddressBook Using File JSON\n22)End Of Program");
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
                        Console.WriteLine("How many no. of contacts to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        addContact.AddMultipleContacts(n);
                        break;
                    case 6:
                        addContact.AddUniqueName();
                        break;
                    case 7:
                        addContact.DisplayUniqueName();
                        break;
                    case 8:
                        addContact.SearchByCityState();
                        break;
                    case 9:
                        addContact.CountByCityState();
                        break;
                    case 10:
                        addContact.ContactByCityInDictionary();
                        addContact.DictionaryCity_Display();
                        break;
                    case 11:
                        addContact.ContactByStateInDictionary();
                        addContact.DictionaryState_Display();
                        break;
                    case 12:
                        addContact.SortingContactsByName();
                        break;
                    case 13:
                        Console.WriteLine("Sorting Persons Contacts by City");
                        addContact.SortingContactsByCity();
                        break;
                    case 14:
                        Console.WriteLine("Sorting Persons Contacts by State");
                        addContact.SortingContactsByState();
                        break;
                    case 15:
                        Console.WriteLine("Sorting Persons Contacts by Zip");
                        addContact.SortingContactsByZip();
                        break;
                    case 16:
                        addContact.WriteToTextFile();
                        break;
                    case 17:
                        addContact.ReadFileIO();
                        break;
                    case 18:
                        addContact.WriteFileCSV();
                        break;
                    case 19:
                        addContact.ReadFileCSV();
                        break;
                    case 20:
                        addContact.WriteJson();
                        break;
                    case 21:
                        addContact.ReadJsonFile();
                        break;
                    case 22:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
}