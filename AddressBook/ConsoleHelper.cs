using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
	static class ConsoleHelper
	{
		public static int GetNumberFromConsole()
		{
			return Console.Read() - '0'; //ascii 48
		}

		public static void WriteLineWithColor(string message, ConsoleColor color, bool resetColor = false)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			if (resetColor)
			{
				Console.ResetColor();
			}
		}

		public static string GetStringFromConsole(string text)
		{
			Console.WriteLine(text);
			return Console.ReadLine();
		}
	}
}
