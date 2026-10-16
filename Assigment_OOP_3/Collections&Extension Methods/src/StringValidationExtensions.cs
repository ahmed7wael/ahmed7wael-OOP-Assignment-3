using System.Text.RegularExpressions;

namespace Collections_Extension_Methods.src
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phone)
        {
            if(string.IsNullOrWhiteSpace(phone))
                return false;

            bool isValid = Regex.IsMatch(phone, @"^(01[0125]\d{8}|\+201[0125]\d{8})$");
            return isValid;
        }

        public static bool IsValidEgyptianNationalId(this string NationalId)
        {
            if (string.IsNullOrWhiteSpace(NationalId))
                return false;

            bool isValid = Regex.IsMatch(NationalId, @"^[23]\d{13}$");
            return isValid;
        }


    }
}
