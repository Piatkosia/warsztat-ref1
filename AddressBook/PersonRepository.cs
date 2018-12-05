using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBook
{
	public class PersonRepository : IPersonRepository
	{
		List<DataInterface> people = new List<DataInterface>();

		public IEnumerator<DataInterface> GetEnumerator()
		{
			return people.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return people.GetEnumerator();
		}

		public DataInterface this[int number]
		{
			get
			{
				
				if (number >= 0 && number < people.Count)
				{
					return people[number];
				}

				throw new ArgumentOutOfRangeException();
			}
			set
			{
				if (number >= 0 && number < people.Count)
				{
					people[number] = value;
				}
			}
		}

		public void Add(DataInterface person)
		{
			people.Add(person);
		}
	}
}