using System.ComponentModel.DataAnnotations;
using Kartoteka_Kontrachentow.Helpers;

namespace Kartoteka_Kontrachentow.ViewModels
{
    public class ContractorViewModel
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi sładać się z conajmniej dwóch znaków.")]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi się składać z conajmniej dwóch znaków.")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Numer NIP jest wymagany.")]
        [NIPValidation(ErrorMessage = "Nie poprawny numer NIP")]
        [Display(Name = "NIP")]
        public string NIP { get; set; }
        public AddressViewModel Address { get; set; }
        [Required(ErrorMessage = "Adres email jest wymagany.")]
        [EmailAddress(ErrorMessage = "Nie poprawny adres e-mail.")]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        [RegularExpression(@"^\+?([0-9]{11})$", ErrorMessage = "Nie poprawny numer telefonu np. +48509000111.")]
        [Display(Name = "Numer telefonu np. +48509000111")]
        public string PhoneNumber { get; set; }
    }
}