using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
	public class Person : DataInterface
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public float Latitude { get; set; }
		public float Longitude { get; set; }

		public override string ToString()
		{
			return $"{FirstName}, {LastName}, {MiddleName}, {Phone}";
		}

		public bool Contains(string pattern)
		{
			return FirstName.Contains(pattern) || 
			       LastName.Contains(pattern) || 
			       MiddleName.Contains(pattern) ||
			       Phone.Contains(pattern);
		}
	}
}
