namespace Collections_Extension_Methods.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Egyptian Phone Numbers ===");
            var phoneTests = new (string phone, bool expected)[]
            {
                ("01012345678", true),
                ("+201512345678", true),
                ("01312345678", false),
                ("0101234567", false),
                ("0101234567a", false)
            };

            foreach (var test in phoneTests)
            {
                bool isValid = test.phone.IsValidEgyptianPhone();
                Console.WriteLine($"Phone: {test.phone,-15} | Valid: {isValid,-5} | Expected: {test.expected}");
            }

            Console.WriteLine("\n=== Testing Egyptian National IDs ===");
            var nationalIdTests = new (string NationalId, bool expected)[]
            {
                ("29901011234567", true),
                ("19901011234567", false),
                ("2990101123456", false),
                ("39901011234567", true),
            };

            foreach (var test in nationalIdTests)
            {
                bool isValid = test.NationalId.IsValidEgyptianNationalId();
                Console.WriteLine($"National ID: {test.NationalId,-15} | Valid: {isValid,-5} | Expected: {test.expected}");
            }
        }
    }
}

