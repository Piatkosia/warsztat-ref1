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
        static Dictionary<int, List<string>> myPeople = new Dictionary<int, List<string>>();
        static int totalPeopleAmount;

        static void Main(string[] args)
        {

            while (consts.TRUE)
            {
                try
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("*********MENU*********");
                    Console.WriteLine("1. Show ALL");
                    Console.WriteLine("2. Add");
                    Console.WriteLine("3. Sync");
                    Console.WriteLine("4. Search By Name");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("!!!!TODO Edit and Delete");
                    Console.WriteLine("======================");

                    var x1 = Console.ReadLine();

                    switch (x1)
                    {
                        case "1":
                            Console.WriteLine("Whole book");

                            foreach (var p in myPeople)
                                Console.WriteLine("{0} {1} {2}", p.Value[0], p.Value[1], p.Value[2]);

                            break;
                        case "2":
                            Console.WriteLine("Adding....");

                            #region fixed memory preparation

                            myPeople.Add(totalPeopleAmount, new List<string>(10) {"", "", "", "", "", "", "", "", "", ""});
                            #endregion

                            Console.Write("First name: ");
                            myPeople[totalPeopleAmount][0] = Console.ReadLine();
                            Console.Write("Last name: ");
                            myPeople[totalPeopleAmount][1] = Console.ReadLine();
                            Console.Write("Phone: ");
                            myPeople[totalPeopleAmount][2] = Console.ReadLine();

                            totalPeopleAmount = totalPeopleAmount + 1;// First we add the new person to list and then increase. Keep it like that!

                            break;
                        case "3":
                            Console.WriteLine("Searching....");
                            Console.WriteLine("");
                            int theNumbr = Console.Read() - 48 /*we need to deduct the base 48*/;
                            myPeople[theNumbr][0] = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Search pattern: ");
                            string pattern  = Console.ReadLine();
                            Console.WriteLine("Searching");

                            foreach (var p in myPeople.Where(p => p.Value.Any(i => i.Contains(pattern))))
                                Console.WriteLine("{0} {1} {2}", p.Value[0], p.Value[1], p.Value[2]);

                            break;
                        case "0":
                            Console.WriteLine("Exiting....");
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception exc)
                {
                    var c = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ERROR!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("ERROR!");
                    Console.ForegroundColor = c;
                }
            }
        }
    }

    struct consts
    {
        public static bool TRUE = true;
    }
}
