using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LiteDB;
using Logic.Interfaces.Models;
using Logic.Interfaces.Repository;
using Logic.Models;

namespace Logic.Repository
{
    public class LiteDb : ILiteDb
    {
        private LiteDatabase _conection;
        private const string _contractor = "Contractor";
        private const string _address = "Address";
        private string pathDb = @"C:\db";

        public LiteDb()
        {
            if (!Directory.Exists(pathDb))
            {
                Directory.CreateDirectory(pathDb);
            }
            _conection = new LiteDatabase($"{pathDb}/DbNoSqlLiteDatabase.db");
        }
        /// <summary>
        /// Dodajemy lub edytujemy Kontrachenta 
        /// </summary>
        /// <param name="contractor">Dane kontrachenta</param>
        public void InsertOrUpdateContractor(IContractor contractor)
        {
            try
            {
                var colection = _conection.GetCollection<IContractor>(_contractor);
                if (colection.Find(x => x.NIP == contractor.NIP).Any())
                {
                    colection.Update(contractor);
                }
                else
                {
                    contractor.ContractorId = ObjectId.NewObjectId();
                    colection.Insert(contractor);
                    colection.EnsureIndex(x => x.NIP);
                }
            }
            catch (Exception ex)
            {
                //TODO implementacja logowania błędów
            }            
        }

        public void InsertOrUpdateAddress(IAddress address)
        {
            try
            {
                var colection = _conection.GetCollection<IAddress>(_address);
                if (colection.Find(x =>
                    x.Street == address.Street && x.City == address.City &&
                    x.ApartmentNumber == address.ApartmentNumber && x.HouseNumber == address.HouseNumber).Any())
                {
                    colection.Update(address);
                }
                else
                {
                    address.AddressId = ObjectId.NewObjectId();
                    colection.Insert(address);
                }
            }
            catch (Exception ex)
            {
                //TODO implementacja logowania błędów
            }
        }
        /// <summary>
        /// Zwracamy wszyskich zapisanych kontrachentów
        /// </summary>
        /// <returns>IEnumerable Kontrachenci</returns>
        public IEnumerable<IContractor> GetAll()
        {
            try
            {
                var colection = _conection.GetCollection<IContractor>(_contractor);
                return colection.FindAll();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}