using LiteDB;
using Logic.Interfaces.Models;

namespace Logic.Models
{
    public class Contractor: IContractor
    {
        public ObjectId ContractorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIP { get; set; }
        public IAddress Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}