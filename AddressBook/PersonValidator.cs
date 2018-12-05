namespace AddressBook
{
	public class PersonValidator : IPersonValidator
	{
		public bool IsValid(DataInterface person)
		{
			return true;
		}
	}
}