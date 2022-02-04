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
            RegularExpressions regularExpressions = new RegularExpressions();//creating an object for a class
            regularExpressions.ValidateFirstName("Raja");
            regularExpressions.ValidateLastName("Kongara");
            regularExpressions.ValidateEmailAddress("kongara.raja8@gmail.com");
        }
    }
}
