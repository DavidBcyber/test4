using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        IDictionary<string, string> contacts = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value 1. add name and phone number  2. remove contact, 3. search contact, 4. Display all contacts ");
            int contact = Convert.ToInt32(Console.ReadLine());
          
            switch (contact)
            {
                case 1:
                    Console.WriteLine("Add name to the info");
                    string name = Console.ReadLine();


                    Console.WriteLine("Add phone number");
                    string phone = Console.ReadLine();

                    Console.WriteLine("succefully added into contact");
                    AddContact();
                    break;
                case 2:
                    var contacts = new Dictionary<string, string>();
                    if (contacts.Remove(name);
                    RemoveContact();
                    break;
                case 3:
                    SearchContact();
                    break;

                case 4:
                    DisplayAllContacts();
                    break;

                default:
                    Console.WriteLine("Invalid options");
                        break;
            }



            

        }
        static void AddContact()
        { 
        //contacts.Add(name,phone);
        }
        static void RemoveContact()
        {

        }

        static void SearchContact()
        {

        }

        static void DisplayAllContacts()
        {

        }
    }
}
