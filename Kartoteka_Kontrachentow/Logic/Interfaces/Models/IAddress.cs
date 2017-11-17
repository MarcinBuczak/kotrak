using LiteDB;

namespace Logic.Interfaces.Models
{
    public interface IAddress
    {
        ObjectId AddressId { get; set; }
        string State { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string HouseNumber { get; set; }
        string ApartmentNumber { get; set; }
    }
}