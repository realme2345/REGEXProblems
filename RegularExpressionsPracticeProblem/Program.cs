using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressionsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the REGEX Problems");
            RegularExpressions regularExpressions = new RegularExpressions();
            //creating an object for a class
            //regularExpressions.ValidateFirstName("Raja");
           //regularExpressions.ValidateLastName("Kongara");
           //regularExpressions.ValidateEmailAddress("kongara.raja8@gmail.com");
           //regularExpressions.ValidateMobileNum("+91 8919807887");
           //regularExpressions.ValidatePassWord("raja1234");
           //regularExpressions.ValidateUpperCase("Rajakongara");
          // regularExpressions.ValidateNumericNumber("Rajakonagara143");
            regularExpressions.ValidateSpecialChar("Rajakongara@43");

        }
    }
}
