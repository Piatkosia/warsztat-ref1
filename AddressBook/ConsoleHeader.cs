using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
	[AttributeUsage(AttributeTargets.Method)]
	public class ConsoleHeader : Attribute
	{
		private string v;

		public ConsoleHeader(string v)
		{
			this.v = v;
		}
	}
}
