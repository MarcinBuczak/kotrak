using System.Linq;

namespace Kartoteka_Kontrachentow.Helpers
{
    public class NipHelper
    {
        private static readonly int[] _weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };

        /// <summary>
        /// Walidacja numeru nip
        /// </summary>
        /// <param name="nip">Numer NIP</param>
        /// <returns>Zwraca true jeśli nip jest poprawny</returns>
        public static bool ValidateNip(string nip)
        {
            if (string.IsNullOrEmpty(nip)) return false;

            nip = nip.Replace(" ", string.Empty);
            nip = nip.Replace("-", string.Empty);

            try
            {
                if (nip.Count() == 10)
                {
                    int sum = 0;
                    for (int i = 0; i <= 8; i++)
                    {
                        sum += int.Parse(nip[i].ToString()) * _weights[i];
                    }

                    return (sum % 11) == int.Parse(nip[9].ToString());
                }

                return false;
            }
            catch { return false; }
        }
    }
}