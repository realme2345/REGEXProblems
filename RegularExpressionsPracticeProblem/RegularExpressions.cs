using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionsPracticeProblem
{/// <summary>
/// RegularExpressions
/// </summary>
    class RegularExpressions
    {
        public static string FirstName = "^[A-Z][A-Z a-z]{3,}$"; // this pattern used for validate the name
        public void ValidateFirstName(string firstName) // this method is used for validating first name
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is valid", firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
            //The End
        }
    }
}
