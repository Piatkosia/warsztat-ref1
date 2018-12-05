using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

	internal class ConsoleProvider : IVisualProvider
	{
		public void Print(string text)
		{
			Console.WriteLine(text);
		}

		public string GetString(string text)
		{
			return ConsoleHelper.GetStringFromConsole(text);
		}

		public void PrintError(string error)
		{
			ConsoleHelper.WriteLineWithColor("ERROR!", ConsoleColor.Red);
			ConsoleHelper.WriteLineWithColor("ERROR!", ConsoleColor.Green);
			ConsoleHelper.WriteLineWithColor("ERROR!", ConsoleColor.Blue, true);
		}

		public void Print(Object objectToPrint)
		{
			Print(objectToPrint.ToString());
		}

		public int GetNumber()
		{
			return ConsoleHelper.GetNumberFromConsole();
		}
	}
}
