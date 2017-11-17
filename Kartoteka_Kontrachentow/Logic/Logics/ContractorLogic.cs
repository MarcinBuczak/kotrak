using System.Collections.Generic;
using LiteDB;
using Logic.Interfaces.Logics;
using Logic.Interfaces.Models;
using Logic.Interfaces.Repository;
using Logic.Models;
using Logic.Repository;

namespace Logic.Logics
{
    public class ContractorLogic: IContractorLogic
    {
        private ILiteDb _db;
        private IAddressLogic _adresLogic;

        public ContractorLogic(ILiteDb db, IAddressLogic adresLogic)
        {
            _db=db;
            _adresLogic = adresLogic;
        }
        public void Add(IContractor contractor)
        {
            //var _contractor = MapedContractor(contractor);

            _db.InsertOrUpdateContractor(contractor);
        }

        public void Edit(IContractor contractor)
        {
            throw new System.NotImplementedException();
        }

        public IContractor Get(ObjectId contractorId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IContractor> GetAll()
        {
            return _db.GetAll();
        }

        private Contractor MapedContractor(IContractor contractor)
        {
            var _contractor = new Contractor();
            _contractor.NIP = contractor.NIP;
            _contractor.Address = new Address
            {
                AddressId = contractor.Address.AddressId,
                ApartmentNumber = contractor.Address.ApartmentNumber,
                City = contractor.Address.City,
                HouseNumber = contractor.Address.HouseNumber,
                State = contractor.Address.State,
                Street = contractor.Address.Street
            };
            _contractor.Email = contractor.Email;
            _contractor.FirstName = contractor.FirstName;
            _contractor.ContractorId = contractor.ContractorId;
            _contractor.PhoneNumber = contractor.PhoneNumber;
            _contractor.LastName = contractor.LastName;

            return _contractor;
        }


    }
}