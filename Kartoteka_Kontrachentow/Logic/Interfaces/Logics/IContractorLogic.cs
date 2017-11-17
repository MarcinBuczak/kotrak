using System.Collections.Generic;
using LiteDB;
using Logic.Interfaces.Models;

namespace Logic.Interfaces.Logics
{
    public interface IContractorLogic
    {
        void Add(IContractor contractor);
        void Edit(IContractor contractor);
        IContractor Get(ObjectId contractorId);
        IEnumerable<IContractor> GetAll();
    }
}