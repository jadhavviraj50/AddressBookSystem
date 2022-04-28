using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        Contact contact = new Contact();
        public AddressBookMain()
        {
            Contact contact1 = new Contact()
            {
                ID = "1",
                FirstName = "Viraj",
                LastName = "Jadhav",
                Address = "Panvel",
                Email = "jadhavviraj50@gmail.com",
                PhoneNumber = "9527326437",
                City = "Panvel",
                State = "Maharastra",
                ZipCode = "410206"
            };
            Contact contact2 = new Contact()
            {
                ID = "2",
                FirstName = "Nitesh",
                LastName = "Gaikwad",
                Address = "Alibag",
                Email = "gaikwadnitesh@gmail.com",
                PhoneNumber = "8087324805",
                City = "Alibag",
                State = "Maharastra",
                ZipCode = "402201"
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
        }
        public void CreateContact()
        {
            Console.WriteLine("Enter Your ID: ");
            contact.ID = Console.ReadLine();
            Console.WriteLine("Enter Your First: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.PhoneNumber + "\n" + contact.City + "\n" + contact
                    .State + "\n" + contact.ZipCode);
                Console.WriteLine("\n");
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Edit a contact list enter ID");
            string id = Console.ReadLine();
            if (contact.ID.Equals(id))
            {
                Console.WriteLine("Edit a Contact\n1.FirstName\n2.LastName\n3.Address\n4.Email\n5.PhoneNumber\n6.City\n7.State\n8.ZipCode\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string firstName = Console.ReadLine();
                        contact.FirstName = firstName;
                        break;
                    case 2:
                        string lastName = Console.ReadLine();
                        contact.LastName = lastName;
                        break;
                    case 3:
                        string address = Console.ReadLine();
                        contact.Address = address;
                        break;
                    case 4:
                        string email = Console.ReadLine();
                        contact.Email = email;
                        break;
                    case 5:
                        string phoneNumber = Console.ReadLine();
                        contact.PhoneNumber = phoneNumber;
                        break;
                    case 6:
                        string city = Console.ReadLine();
                        contact.City = city;
                        break;
                    case 7:
                        string state = Console.ReadLine();
                        contact.State = state;
                        break;
                    case 8:
                        string zipCode = Console.ReadLine();
                        contact.ZipCode = zipCode;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name is Not Exist");
            }
        }
    }
}
    

