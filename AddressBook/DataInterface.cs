using System;

namespace AddressBook
{
    public interface DataInterface
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        float Latitude { get; set; }
        float Longitude { get; set; }
    }
}