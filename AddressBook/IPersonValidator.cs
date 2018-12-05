using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

	public interface IPersonValidator
	{
		bool IsValid(DataInterface person);
	}
}
