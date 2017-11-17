using LiteDB;
using Logic.Interfaces.Logics;
using Logic.Interfaces.Models;
using Logic.Interfaces.Repository;
using Logic.Models;

namespace Logic.Logics
{
    public class AddressLogic: IAddressLogic
    {
        private ILiteDb _db;
        public AddressLogic(ILiteDb db)
        {
            _db = db;
        }

        public void InsertUpdate(IAddress address)
        {
            _db.InsertOrUpdateAddress(address);
        }

        public IAddress Get(ObjectId addressId)
        {
            throw new System.NotImplementedException();
        }

        private Address MapedAddress(IAddress address)
        {
            return new Address
            {
                AddressId = address.AddressId,
                ApartmentNumber = address.ApartmentNumber,
                City = address.City,
                HouseNumber = address.HouseNumber,
                State = address.State,
                Street = address.Street
            };
        }
    }
}