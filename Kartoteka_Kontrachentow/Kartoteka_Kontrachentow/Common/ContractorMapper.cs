using System.Collections.Generic;
using System.Linq;
using Kartoteka_Kontrachentow.ViewModels;

namespace Kartoteka_Kontrachentow.Common
{
    public static class ContractorMapper
    {
        public static List<ContractorViewModel> MapContractor(IEnumerable<Logic.Interfaces.Models.IContractor> model)
        {
            return model.Select(m => new ContractorViewModel
                {
                    Email = m.Email,
                    FirstName = m.FirstName,
                    LastName = m.LastName,
                    NIP = m.NIP,
                    PhoneNumber = m.PhoneNumber,
                    Address = new AddressViewModel
                    {
                        ApartmentNumber = m.Address.ApartmentNumber,
                        City = m.Address.City,
                        HouseNumber = m.Address.HouseNumber,
                        State = m.Address.State,
                        Street = m.Address.Street
                    }
                })
                .ToList();
        }

        public static Logic.Models.Contractor MapContractor(ContractorViewModel model)
        {
            var result = new Logic.Models.Contractor();
            result.Email = model.Email;
            result.FirstName = model.FirstName;
            result.LastName = model.LastName;
            result.NIP = model.NIP;
            result.PhoneNumber = model.PhoneNumber;
            result.Address = MapAddress(model.Address);

            return result;
        }

        public static Logic.Models.Address MapAddress(AddressViewModel model)
        {
            return  new Logic.Models.Address
            {
                ApartmentNumber = model.ApartmentNumber,
                City = model.City,
                HouseNumber = model.HouseNumber,
                State = model.State,
                Street = model.Street
            };
        }
    }
}