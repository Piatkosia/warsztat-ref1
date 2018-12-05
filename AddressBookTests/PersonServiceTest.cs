using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook;
using Moq;
using Xunit;

namespace AddressBookTests
{ 
    public class PersonServiceTests
    {
		[Fact]
	    public void ServiceCanAddElement()
		{
			Mock<IPersonRepository> mockedrepo = new Mock<IPersonRepository>();
			mockedrepo.Setup(x => x.Add(It.IsAny<Person>()));
			PersonService service = new PersonService(mockedrepo.Object, new AlwaysTrueValidator());
			service.Add(new Person());
			mockedrepo.Verify(x => x.Add(It.IsAny<Person>()), Times.Once);
		}

	    [Fact]
	    public void ServiceCannotAddInvalidElement()
	    {
			Mock<IPersonRepository> mockedrepo = new Mock<IPersonRepository>();
		    mockedrepo.Setup(x => x.Add(It.IsAny<Person>()));
		    PersonService service = new PersonService(mockedrepo.Object, new AlwaysFalseValidator());
		    service.Add(new Person());
			mockedrepo.Verify(x => x.Add(It.IsAny<Person>()), Times.Never);
		}

		class AlwaysTrueValidator : IPersonValidator
	    {
		    public bool IsValid(DataInterface person)
		    {
			    return true;
		    }
	    }

	   
	    class AlwaysFalseValidator : IPersonValidator
	    {
		    public bool IsValid(DataInterface person)
		    {
			    return false;
		    }
	    }
	}
}
