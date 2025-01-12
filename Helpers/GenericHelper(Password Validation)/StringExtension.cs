using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenericHelper_Password_Validation_
{
    internal static class StringExtension
    {

        async internal static Task<string> GenerateRandomPassword(this string x, int length)
        {
            bool isValid=false;
            bool guidPassMessage=true;
            do
            {
                Console.Write("Please Enter your Password: ");
                string pass = Console.ReadLine();
                if (guidPassMessage)
                {
                    Console.WriteLine("Must Contain a Digit");
                    Console.WriteLine("Must Contain a Capital Letter");
                    Console.WriteLine("Must Contain a Symbols");
                    Console.WriteLine("Must Contain a Small Letter");
                }
                int passLength = pass.Length;
                 isValid = await ValidationHelper.IsPasswordValid(pass, passLength);
                if (isValid)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password is Valid");
                    Console.ForegroundColor = ConsoleColor.White;
                    guidPassMessage = false;
                    return pass;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password is invalid. Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return await GenerateRandomPassword(x, length);
                }
            } while (!isValid);

        }
    }
}
