using LiteDB;
using Logic.Interfaces.Models;

namespace Logic.Models
{
    public class Address: IAddress
    {
        public ObjectId AddressId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
    }
}