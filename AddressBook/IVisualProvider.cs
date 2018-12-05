using System.Collections.Generic;

namespace AddressBook
{
	internal interface IVisualProvider
	{
		void Print(string exiting);
		string GetString(string pattern);
		void PrintError(string error);
		void Print(object objectToPrint);
		int GetNumber();
	}
}