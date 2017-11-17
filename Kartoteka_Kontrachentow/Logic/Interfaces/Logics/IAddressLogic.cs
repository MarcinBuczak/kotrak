using LiteDB;
using Logic.Interfaces.Models;

namespace Logic.Interfaces.Logics
{
    public interface IAddressLogic
    {
        void InsertUpdate(IAddress address);
        IAddress Get(ObjectId addressId);
    }
}