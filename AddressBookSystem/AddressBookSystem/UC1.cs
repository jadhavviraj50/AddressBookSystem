using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddAddressBook
    {
        Contacts contact = new Contacts();
        public void AddContacts()
        {

            Console.WriteLine("Enter Your First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("--------Details--------");
            Console.WriteLine("First Name:" + contact.FirstName);
            Console.WriteLine("Last Name:" + contact.LastName);
            Console.WriteLine("Address:" + contact.Address);
            Console.WriteLine("Email:" + contact.Email);
            Console.WriteLine("Phone Number:" + contact.PhoneNumber);
            Console.WriteLine("City:" + contact.City);
            Console.WriteLine("State:" + contact.State);
            Console.WriteLine("ZipCode:" + contact.ZipCode);
        }

    }
}