using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using CsvHelper;
using System.Globalization;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        public Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> dictcity = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> dictstate = new Dictionary<string, List<Contact>>();
        Contact contact = new Contact();


        public void CreateContact()
        {
            Contact contact = new Contact();

            int Flag = 0;
            Console.WriteLine("Enter the First name :");
            contact.FirstName = Console.ReadLine();
            string FirstNameToBeAdded = contact.FirstName;
            foreach (var data in addressBook)
            {
                if (addressBook.Exists(data => data.FirstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Flag == 0)
            {
                Console.WriteLine("Enter Your ID: ");
                contact.ID = Console.ReadLine();
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

            }
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
                    default:
                        Console.WriteLine("Enter Correct option");
                        break;
                }
            }
            Console.WriteLine("\nEdit Successfully\n");
            Display();
        }
        public void DeleteContact()
        {
            Contact delete = new Contact();
            Console.WriteLine("To Delete Contact List Enter FirstName");
            string FirstName = Console.ReadLine();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(FirstName))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Console.WriteLine("\nContact Deleted SuccessFully\n");
            Display();
        }
        public void AddMultipleContacts(int n)
        {

            while (n > 0)
            {
                CreateContact();
                n--;
            }
        }

        public void AddUniqueName()
        {
            Console.WriteLine("Enter the Firstname to Add Unique Name");
            string name = Console.ReadLine();
            foreach (var data in addressBook)
            {
                if (addressBook.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("Please Enter an Unique Name");
                        string uniquename = Console.ReadLine();
                        if (dict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dict.Add(uniquename, addressBook);
                        return;
                    }
                }
            }
            Console.WriteLine("This Contact doesn't Exist");
            return;

        }


        public void DisplayUniqueName()
        {
            Console.WriteLine("Enter the Uniquename of your contacts");
            string name = Console.ReadLine();

            foreach (var Contact in dict)
            {
                if (Contact.Key.Contains(name))
                {
                    foreach (var contact in Contact.Value)
                    {
                        Console.WriteLine("Enter ID : " + contact.ID);
                        Console.WriteLine("Enter First Name: " + contact.FirstName);
                        Console.WriteLine("Enter Last Name: " + contact.LastName);
                        Console.WriteLine("Enter Address: " + contact.Address);
                        Console.WriteLine("Enter Email: " + contact.Email);
                        Console.WriteLine("Enter Phone Number: " + contact.PhoneNumber);
                        Console.WriteLine("Enter City: " + contact.City);
                        Console.WriteLine("Enter State: " + contact.State);
                        Console.WriteLine("Enter Zip: " + contact.ZipCode);
                        return;
                    }
                }
            }
        }

        public void SearchByCityState()
        {
            Console.WriteLine("Please Enter the name of City or State:");
            string SearchCityOrState = Console.ReadLine();
            foreach (var data in addressBook)
            {
                if (addressBook.Exists(data => (data.City == SearchCityOrState) || (data.State == SearchCityOrState)))
                {
                    if ((data.City == SearchCityOrState) || (data.State == SearchCityOrState))
                    {
                        Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                        Console.WriteLine("Address of person is : " + data.Address);
                        Console.WriteLine("City : " + data.City);
                        Console.WriteLine("State :" + data.State);
                        Console.WriteLine("Zip :" + data.ZipCode);
                        Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                        Console.WriteLine("Email of person : " + data.Email);
                        Console.WriteLine();


                    }
                }
            }
        }

      
        public void CountByCityState()
        {
            Console.WriteLine("Please enter the name of City or State:");
            string NameOfCityOrState = Console.ReadLine();

            int count = 0;
            foreach (var data in addressBook)
            {
                string actualcity = data.City;
                string actualState = data.State;
                if (addressBook.Exists(data => (actualcity == NameOfCityOrState || actualState == NameOfCityOrState)))
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} Persons in {1}:", count, NameOfCityOrState);
        }

        public void ContactByCityInDictionary()
        {

            try
            {
                var data = addressBook.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<Contact> cityList = new List<Contact>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    dictcity.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DictionaryCity_Display()
        {
            if (dictcity.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictcity.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contact>> addressBooks in dictcity)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (Contact contact in addressBooks.Value)
                    {
                        Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                        Console.WriteLine("Address of person is : " + contact.Address);
                        Console.WriteLine("City : " + contact.City);
                        Console.WriteLine("State :" + contact.State);
                        Console.WriteLine("ZipCode :" + contact.ZipCode);
                        Console.WriteLine("Phone Number of person: " + contact.PhoneNumber);
                        Console.WriteLine("Email of person : " + contact.Email);
                        Console.WriteLine();

                    }
                }
            }
        }

        public void ContactByStateInDictionary()
        {

            try
            {
                var data = addressBook.GroupBy(x => x.State);
                foreach (var states in data)
                {
                    List<Contact> stateList = new List<Contact>();
                    foreach (var state in states)
                    {
                        stateList.Add(state);
                    }
                    dictstate.Add(states.Key, stateList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DictionaryState_Display()
        {
            if (dictstate.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictstate.Count >= 1)
            {
                foreach (KeyValuePair<string, List<Contact>> addressBooks in dictstate)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (Contact contact in addressBooks.Value)
                    {
                        Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                        Console.WriteLine("Address of person is : " + contact.Address);
                        Console.WriteLine("City : " + contact.City);
                        Console.WriteLine("State :" + contact.State);
                        Console.WriteLine("ZipCode :" + contact.ZipCode);
                        Console.WriteLine("Phone Number of person: " + contact.PhoneNumber);
                        Console.WriteLine("Email of person : " + contact.Email);
                        Console.WriteLine();
                    }
                }
            }
        }

        public void SortingContactsByName()
        {
            foreach (var data in addressBook.OrderBy(s => s.FirstName).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("ZipCode : " + data.ZipCode);
                    Console.WriteLine("\n");
                }

            }
        }

        public void SortingContactsByCity()
        {

            foreach (var data in addressBook.OrderBy(s => s.City).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByState()
        {

            foreach (var data in addressBook.OrderBy(s => s.State).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByZip()
        {

            foreach (var data in addressBook.OrderBy(s => s.ZipCode).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        string path = @"C:\Users\HP\AddressBookSystem\AddressBookSystem\AddressBookSystem\FileUsingInputOutput.txt";
        public void WriteToTextFile()
        {
            using (TextWriter Tw = File.AppendText(path))
            {
                foreach (Contact item in addressBook)
                {
                    Tw.WriteLine("First Name:" + item.FirstName.ToString());
                    Tw.WriteLine("Last Name:" + item.LastName.ToString());
                    Tw.WriteLine("Address:" + item.Address.ToString());
                    Tw.WriteLine("City:" + item.City.ToString());
                    Tw.WriteLine("State:" + item.State.ToString());
                    Tw.WriteLine("ZipCode:" + item.ZipCode.ToString());
                    Tw.WriteLine("PhoneNumber:" + item.PhoneNumber.ToString());
                    Tw.WriteLine("EmailId:" + item.Email.ToString());

                }
            }
        }
        public void ReadFileIO()
        {
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Reading All the Text\n" + lines);
        }


        public void WriteFileCSV()
        {
            string path = @"C:\Users\HP\AddressBookSystem\AddressBookSystem\AddressBookSystem\UsingCsvFile.csv";
            StreamWriter sw = new StreamWriter(path);

            using (var csvExport = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                {
                    csvExport.WriteRecords(addressBook);
                }
                Console.WriteLine("Persons Contacts saved in Csv file");

            }

        }
        public void ReadFileCSV()
        {
            string path = @"C:\Users\HP\AddressBookSystem\AddressBookSystem\AddressBookSystem\UsingCSVFile.csv";
            StreamReader sr = new StreamReader(path);

            CsvReader cr = new(sr, CultureInfo.InvariantCulture);
            List<Contact> readResult = cr.GetRecords<Contact>().ToList();
            Console.WriteLine("Reading from CSV file");
            foreach (var item in readResult)
            {
                Console.WriteLine(item.FirstName.ToString());
                Console.WriteLine(item.LastName.ToString());
                Console.WriteLine(item.Address.ToString());
                Console.WriteLine(item.City.ToString());
                Console.WriteLine(item.State.ToString());
                Console.WriteLine(item.ZipCode.ToString());
                Console.WriteLine(item.PhoneNumber.ToString());
                Console.WriteLine(item.Email.ToString());
            }
            sr.Close();
        }

        public void WriteJson()
        {
            string json = @"C:\Users\HP\AddressBookSystem\AddressBookSystem\AddressBookSystem\TextFile1json";
            foreach (Contact item in addressBook)
            {
                string json1 = JsonConvert.SerializeObject(addressBook);
                File.WriteAllText(json, json1);

            }
            Console.WriteLine("copied all data");

        }
        public void ReadJsonFile()
        {
            string json = @"C:\Users\HP\AddressBookSystem\AddressBookSystem\AddressBookSystem\TextFile1json";
            string jsonData = File.ReadAllText(json);
            var jsonResult = JsonConvert.DeserializeObject<List<Contact>>(jsonData).ToList();
            Console.WriteLine("Reading from Json file");
            foreach (var data in jsonResult)
            {

                Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Address of person is : " + data.Address);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("State :" + data.State);
                Console.WriteLine("ZipCode :" + data.ZipCode);
                Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                Console.WriteLine("Email of person : " + data.Email);
                Console.WriteLine("\n");

            }
        }


    }
}

    

