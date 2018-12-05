using System;

namespace AddressBook
{
    class Program
    {
	    private static IPersonRepository myPeople = new PersonRepository();
	    static IVisualProvider provider = new ConsoleProvider();
		static IPersonValidator validator = new PersonValidator();
		private static PersonService personService= new PersonService(myPeople, validator);

        static void Main(string[] args)
        {
			while (true)
            {
                try
                {
                    PrintMenu();
	                var command = provider.GetString();
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
		    foreach (var p in personService.Search(pattern))
			    provider.Print(p);
	    }
	    private static void GetOnePerson()
	    {
		    provider.Print("Get....\n");
		    int index = provider.GetNumber();
		    provider.Print(personService.Get(index));
	    }
	    private static void GetAll()
	    {
		    provider.Print("Whole book");
		    foreach (var p in personService.GetAll())
		    {
			    provider.Print(p);
		    }
	    }

	    private static void CreateNewPerson()
		{
			provider.Print("Adding....");
			personService.Add(new Person
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
		    provider.Print("======================");
		    provider.Print("*********MENU*********");
		    provider.Print("1. Show ALL");
		    provider.Print("2. Add");
		    provider.Print("3. Get contact by ID");
		    provider.Print("4. Search");
		    provider.Print("0. Exit");
		    provider.Print("!!!!TODO Edit and Delete");
			provider.Print("======================");
	    }
    }
}
