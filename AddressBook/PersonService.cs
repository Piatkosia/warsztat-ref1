using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

	internal class PersonService
	{
		private IPersonRepository myPeople;
		private IPersonValidator validator;

		public PersonService(IPersonRepository myPeople, IPersonValidator validator)
		{
			this.myPeople = myPeople;
			this.validator = validator;
		}

		public IEnumerable<DataInterface> Search(string pattern)
		{
			return myPeople.Where(q => q.Contains(pattern));
		}

		public DataInterface Get(int index)
		{
			return myPeople[index];
		}

		public IEnumerable<DataInterface> GetAll()
		{
			return myPeople;
		}

		public void Add(DataInterface person)
		{
			if (validator.IsValid(person))
			{
				myPeople.Add(person);
			}
		}
	}
}
