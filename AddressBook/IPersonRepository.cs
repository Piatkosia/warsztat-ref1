using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

	public interface IPersonRepository : IEnumerable<DataInterface>
	{
		DataInterface this[int number] { get; set; }
		void Add(DataInterface person);
		 
	}
}
