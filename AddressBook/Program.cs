using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static List<Person> myPeople = new List<Person>();
	    static IVisualProvider provider = new ConsoleProvider();

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    PrintMenu();
	                var command = Console.ReadLine();
                    switch (command)
                    {
                        case "1":
                            GetAll();
	                        break;
                        case "2":
							CreateNewPerson();
	                        break;
                        case "3":
                            GetOnePerson();
	                        break;
                        case "4":
	                        SearchPerson();
	                        break;
                        case "0":
                            Exit();
	                        break;
                        default:
                            break;
                    }
                }
                catch(Exception exc)
                {
	                PrintErrorMessage();
                }
            }
        }

	    private static void Exit()
	    {
		    provider.Print("Exiting....");
		    Environment.Exit(0);
	    }

	    private static void SearchPerson()
	    {
		    string pattern = provider.GetString("Pattern : ");
		    provider.Print("Searching");
		    foreach (var p in myPeople.Where(q => q.Contains(pattern)))
			    provider.Print(p);
	    }
	    private static void GetOnePerson()
	    {
		    provider.Print("Get....\n");
		    int index = provider.GetNumber();
		    provider.Print(myPeople[index]);
	    }
	    private static void GetAll()
	    {
		    provider.Print("Whole book");
		    foreach (var p in myPeople)
		    {
			    provider.Print(p);
		    }
	    }

	    private static void CreateNewPerson()
		{
			provider.Print("Adding....");
			myPeople.Add(new Person
				{
					FirstName = provider.GetString("First name : "),
					MiddleName = provider.GetString("Middle name : "),
					LastName = provider.GetString("Last name: "),
					Phone = provider.GetString("Phone: ")
				});
		}

		private static void PrintErrorMessage()
	    {
		    provider.PrintError("ERROR!");
	    }

	    private static void PrintMenu()
	    {
		    Console.WriteLine("======================");
		    Console.WriteLine("*********MENU*********");
		    Console.WriteLine("1. Show ALL");
		    Console.WriteLine("2. Add");
		    Console.WriteLine("3. Get contact by ID");
		    Console.WriteLine("4. Search");
		    Console.WriteLine("0. Exit");
		    Console.WriteLine("!!!!TODO Edit and Delete");
		    Console.WriteLine("======================");
	    }
    }
}
