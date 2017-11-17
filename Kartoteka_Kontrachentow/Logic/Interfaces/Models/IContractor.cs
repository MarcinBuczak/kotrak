using LiteDB;

namespace Logic.Interfaces.Models
{
    public interface IContractor
    {
        ObjectId ContractorId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NIP { get; set; }
        IAddress Address { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}