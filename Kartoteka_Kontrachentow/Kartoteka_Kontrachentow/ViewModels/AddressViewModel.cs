using System.ComponentModel.DataAnnotations;

namespace Kartoteka_Kontrachentow.ViewModels
{
    public class AddressViewModel
    {
        
        public string State { get; set; }
        [Required(ErrorMessage = "Miasto jest wymagane.")]
        [MinLength(2, ErrorMessage = "Miasto musi sładać się z conajmniej dwóch znaków.")]
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Required(ErrorMessage = "Ulica jest wymagana.")]
        [MinLength(2, ErrorMessage = "Ulica musi sładać się z conajmniej dwóch znaków.")]
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
    }
}