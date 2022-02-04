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
        //validatingFirst Name
        public static string FirstName = "^[A-Z][A-Z a-z]{3,}$"; // this pattern used for validate the name
        public void ValidateFirstName(string firstName) // this method is used for validating first name
        {
            if (Regex.IsMatch(firstName, FirstName))
            {
                Console.WriteLine("{0} is valid", firstName);
                Console.WriteLine("First Name :"+firstName);
            }
            else
            {
                Console.WriteLine("{0} is not valid", firstName);
            }
            //The End
        }
        //Validating The LastName
        public static string LastName = "^[A-Z][A-Z a-z]{3,}$";// pattern used for checking as per use case
        public void ValidateLastName(string lastName) // this method is used for validating last name
        {
            if (Regex.IsMatch(lastName, LastName))
            {
                Console.WriteLine("{0} is valid", lastName);
                Console.WriteLine("Last Name :"+lastName);

            }
            else
            {
                Console.WriteLine("{0} is not valid", lastName);
            }
            //The End
        }
        // Validating Email
        public static string EmailAddress = @"^([A-Za-z0-9]*\.[A-Za-z0-9]*)@([A-Za-z0-9]*)((\.(\w){2,3})+)$";
        public void ValidateEmailAddress(string email)//-Validating the EmailAddres
        {
            if (Regex.IsMatch(email, EmailAddress))
            {
                Console.WriteLine("{0} is valid", email);
                Console.WriteLine("Email :"+ email);

            }
            else
            {
                Console.WriteLine("{0} is not valid", email);
            }
            //The End
        }
        // Validating Mobile Number
        public static string MobileNum = @"^([\+][0-9]{2}\s*[0-9]{10})$";
        public void ValidateMobileNum(string mobile) // this method used for the validating Mobile Number
        {
            if (Regex.IsMatch(mobile, MobileNum))
            {
                Console.WriteLine("{0} is valid", mobile);
                Console.WriteLine("Mobile Number :"+ mobile);
            }
            else
            {
                Console.WriteLine("{0} is not valid", mobile);
            }
            //The End
        }
        // Validating Password
        public static string Password = @"^[A-Za-z0-9]{8,}$";
        public void ValidatePassWord(string password) // this method used for the validating password
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("{0} is valid", password);
                Console.WriteLine("Password :"+ password);
            }
            else
            {
                Console.WriteLine("{0} is not valid", password);
            }
            //The End
        }
        // Validating Password with one Upper case
        public static string UpperCase = @"^(?=.*[A-Z])[A-Za-z0-9]{8,}$";
        public void ValidateUpperCase(string password) // this method used for the validating password atleast one upper acase
        {
            if (Regex.IsMatch(password, UpperCase))
            {
                Console.WriteLine("{0} is valid", password);
                Console.WriteLine("Password :"+ password);
            }
            else
            {
                Console.WriteLine("{0} is not valid", password);
            }
            //The End
        }
    }
}
