using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GenericHelper_Password_Validation_;

namespace GenericHelper_Password_Validation_
{
    public static class ValidationHelper
    {

        public async static Task<bool> IsPasswordValid(string pass, int length)
        {
            if (length >= 8)
            {
                bool isDigitValid = await IsContainDigit(pass);
                bool isSymbolValid = await IsContainSymbol(pass);
                bool isSmallLetterValid = await IsContainSmallLetter(pass);
                bool isCapitalLetterValid = await IsContainCapitalLetter(pass);
                return isDigitValid && isSymbolValid && isSmallLetterValid && isCapitalLetterValid;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Password must be at least 8 characters");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        public async static Task<bool> IsContainDigit(string pass)
        {
            var regexItem = new Regex(@"\d+");
            if (regexItem.IsMatch(pass))
            {
                RemoveMustAbove();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Contains Digit");
                Console.ForegroundColor= ConsoleColor.White;
                return true;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                RemoveMustAbove();
                Console.WriteLine("Doesn't Contain a Digit");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        public async static Task<bool> IsContainCapitalLetter(string pass)
        {
            var regexItem = new Regex("[A-Z]");
            if (regexItem.IsMatch(pass))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contains Capital Letter");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Doesn't Contain a Capital Letter");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

        }
        public async static Task<bool> IsContainSymbol(string pass)
        {
            var regexItem = new Regex(@"[\|!#$%&/()=?»«@£§€{}.\-;:'<>_,]");
            if (regexItem.IsMatch(pass))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contains Symbol");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Doesn't Contain a Symbols");
                Console.ForegroundColor = ConsoleColor.White;
                return false;

            }

        }
        public async static Task<bool> IsContainSmallLetter(string pass)
        {
            var regexItem = new Regex("[a-z]");
            if (regexItem.IsMatch(pass))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contains Small Letter");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Doesn't Contain a Small Letter");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        async public static void RemoveMustAbove()
        {
            for (int i = 1; i <= 4; i++)
            {
                if (i<=2)
                {
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(0, Console.CursorTop - i);// Move to the previous line
                    Console.WriteLine(new string(' ', 29));
                }
                else
                {
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(0, Console.CursorTop - 2);// Move to the previous line
                    Console.WriteLine(new string(' ', 29));
                }
            }

        }
    }
}
 