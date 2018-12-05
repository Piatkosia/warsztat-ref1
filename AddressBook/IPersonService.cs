using System.Collections.Generic;

namespace AddressBook
{
	public interface IPersonService
	{
		bool Add(DataInterface person);
		DataInterface Get(int index);
		IEnumerable<DataInterface> GetAll();
		IEnumerable<DataInterface> Search(string pattern);
	}
}