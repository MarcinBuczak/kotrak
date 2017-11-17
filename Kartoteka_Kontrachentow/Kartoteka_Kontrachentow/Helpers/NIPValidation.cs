using System.ComponentModel.DataAnnotations;

namespace Kartoteka_Kontrachentow.Helpers
{
    public class NIPValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var nip = value.ToString();
                var result = NipHelper.ValidateNip(nip);
                return result;
            }
            return false;
        }
    }
}