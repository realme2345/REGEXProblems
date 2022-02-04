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
            regularExpressions.ValidateFirstName("Raja");
        }
    }
}
