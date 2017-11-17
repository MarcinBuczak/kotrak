using System.Collections.Generic;
using Logic.Interfaces.Models;

namespace Logic.Interfaces.Repository
{
    public interface ILiteDb
    {
        void InsertOrUpdateContractor(IContractor contractor);
        void InsertOrUpdateAddress(IAddress address);
        IEnumerable<IContractor> GetAll();
    }
}