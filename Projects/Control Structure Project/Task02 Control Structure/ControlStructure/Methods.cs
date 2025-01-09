using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public class Methods
    {
        // Name: Qais Ihab Nimer   Email: qaisihabnimer@gmail.com

        /* 1- Write a C# Sharp program to accept two integers and check whether they are equal or not */

        public void Question1()
        {
            int num1, num2;

            Console.WriteLine("To Check Your Numbers Equals Or Not\n Please Enter 1'st Number :");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Wrong format for the first number Try Again :");
                return;
            }

            Console.WriteLine("Please Enter 2'nd Number :");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Wrong format for the second number Try Again: ");
                return;
            }
            Console.WriteLine((num1 == num2) ? $"{num1},{num2} Equal" : $"{num1},{num2} Not Equal");

        }

        /* 2-Write a C# Sharp program to check whether a given number is even or odd */

        public void Question2()
        {
            Console.WriteLine("Please Enter The Number To Check Whether The Given Number Is Even Or Odd :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Wrong format for the number Try Again");
                return;
            }
            oddEven(num1);
        }
        public int oddEven(int num1)
        {
            Console.WriteLine((num1 % 2 == 0) ? $" {num1} is Even Number " : $" {num1} is Odd Number ");
            return num1;
        }

        /* 3-Write a C# Sharp program to find out whether a given year is a leap year or not*/

        public void Question3()
        {
            Console.WriteLine("Please Enter The Year To Know if It's Leap Or Not :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Wrong format for the number Try Again");
                return;
            }
            Console.WriteLine(num1 % 4 == 0 ? $"{num1} is a leap year" : $"{num1} is NOT a leap year");
        }

        /*4- Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote */

        public void Question4()
        {
            string userInput;
            Console.WriteLine("Please Enter Your Birthdate To Know If You Can Vote Or Not :");
            Console.Write("Day: ");
            if (!byte.TryParse(Console.ReadLine(), out byte day) || (day > 31 || day < 1))
            {
                Console.WriteLine("Wrong format for the days number Try Again");
                return;
            }
            Console.Write("Month *In Numbers From 1 - 12 * : ");
            if (!byte.TryParse(Console.ReadLine(), out byte month) || (month > 12 || month < 1))
            {
                Console.WriteLine("Wrong format for the months number Try Again");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" The Months Should Be In Numbers Like This 1,2,3,----,12 ");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Year: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Wrong format for the days number Try Again");
                return;
            }
            if (day < 10) {
                userInput = $"0{day}/{month}/{year}";
            }
            if (month < 10)
            {
                userInput = $"{day}/0{month}/{year}";
            }
            else
            {
                userInput = $"{day}/{month}/{year}";

            }
            if (DateTime.TryParse(userInput, out DateTime Date))
            {
                if ((DateTime.Now.Year - year) == 18 && month <= DateTime.Now.Month && day <= DateTime.Now.Day)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats You Can Vote");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((DateTime.Now.Year - year) > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats You Can Vote");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry You Can't Vote, You Must Be 18 Or Above");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (year % 4 == 0 && day == 29)
            {
                if ((DateTime.Now.Year - year) == 18 && month <= DateTime.Now.Month && day <= DateTime.Now.Day)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats You Can Vote");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if ((DateTime.Now.Year - year) > 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats You Can Vote");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry You Can't Vote, You Must Be 18 Or Above");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered date is invalid.");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        /* 5-Write a C# Sharp program to find the largest of three numbers */

        public void Question5()
        {
            Console.WriteLine("Please Enter The 3 Numbers To Find The Largest :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Wrong format for the number 1 Try Again");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Wrong format for the number 2 Try Again");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int num3))
            {
                Console.WriteLine("Wrong format for the number 3 Try Again");
                return;
            }
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The Largest Number is : " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Largest Number is : " + num2);
            }
            else
            {
                Console.WriteLine("The Largest Number is : " + num3);
            }
        }

        /* 6- Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:
        Marks in Maths >=65
        Marks in Phy >=55
        Marks in Chem>=50
        Total in all three subject >=180
        or
        Total in Math and Subjects >=140 */

        public void Question6()
        {
            Console.WriteLine("Please Enter The 3 Marks To Find If You Can Join This professional Course :");
            Console.Write("Math :");
            if (!byte.TryParse(Console.ReadLine(), out byte math) || math > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format for the first Mark Try Again :");
                return;
            }

            Console.Write("Physics:");
            if (!byte.TryParse(Console.ReadLine(), out byte phys) || phys > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format for the second number Try Again: ");
                return;
            }
            Console.Write("Chemistry :");
            if (!byte.TryParse(Console.ReadLine(), out byte chem) || chem > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format for the second number Try Again: ");
                return;
            }

            if ((math >= 65 && chem >= 50 && phys >= 55) && ((math + phys >= 140) || (math + phys + chem >= 180)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats You're Qualified :)");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry You're Not Qualified :( ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /* 7- Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
        Temp < 0 then Freezing weather
        Temp 0-10 then Very Cold weather
        Temp 10-20 then Cold weather
        Temp 20-30 then Normal in Temp
        Temp 30-40 then Its Hot
        Temp >=40 then Its Very Hot */

        public void Question7()
        {
            Console.WriteLine("Please Enter The Temperature In Centigrade:");
            if (!sbyte.TryParse(Console.ReadLine(), out sbyte temp))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format for the temperature, Try Again :");
                return;
            }
            if (temp < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("FREEZING WEATHER ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Very Cold Weather ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Cold Weather ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Normal Weather ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hot Weather ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("VERY HOT WEATHER ");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        /* 8-  Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
        Test Data :
        4
        Expected Output :
        Thursday */

        public void Question8()
        {
            Console.WriteLine(" give me any day number as an integer and display the name of the day as a word ");
            if (!byte.TryParse(Console.ReadLine(), out byte dayNum) || dayNum <= 0 || dayNum > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format Enter Number Please From 1-7");
                return;
            }
            switch (dayNum)
            {
                case 1:
                    { Console.WriteLine("Monday"); }
                    break;

                case 2:
                    { Console.WriteLine("Tuesday"); }
                    break;

                case 3:
                    { Console.WriteLine("Wednesday"); }
                    break;

                case 4:
                    { Console.WriteLine("Thursday"); }
                    break;

                case 5:
                    {
                        Console.WriteLine("Friday");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("Saturday");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Sunday");
                    }
                    break;
            }
        }

        /* 9- Write C# Sharp program to read any Month Number in integer and display Month name.
        Test Data :
        4
        Expected Output:
        April*/

        public void Question9()
        {
            Console.WriteLine(" give me any Month number as an integer and display the name of the day as a word ");
            if (!byte.TryParse(Console.ReadLine(), out byte monthNum) || monthNum <= 0 || monthNum > 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format Enter Number Please From 1-12");
                return;
            }
            swichMonths(monthNum);
        }
        public void swichMonths(byte monthNum)
        {
            switch (monthNum)
            {
                case 1:
                    { Console.WriteLine($"{monthNum} January"); }
                    break;
                case 2:
                    { Console.WriteLine($"{monthNum} February"); }
                    break;

                case 3:
                    { Console.WriteLine($"{monthNum} March"); }
                    break;

                case 4:
                    { Console.WriteLine($"{monthNum} April"); }
                    break;

                case 5:
                    {
                        { Console.WriteLine($"{monthNum} May"); }
                    }
                    break;

                case 6:
                    {
                        { Console.WriteLine($"{monthNum} June"); }
                    }                                    
                    break;                               
                case 7:                                  
                    {                                    
                        { Console.WriteLine($"{monthNum} July"); }
                    }                                    
                    break;                               
                case 8:                                  
                    {                                    
                        { Console.WriteLine($"{monthNum} Augest"); }
                    }                                    
                    break;                               
                case 9:                                  
                    {                                    
                        { Console.WriteLine($"{monthNum} September"); }
                    }                                    
                    break;                               
                case 10:                                 
                    {                                    
                        { Console.WriteLine($"{monthNum} October"); }
                    }                                    
                    break;                               
                case 11:                                 
                    {                                    
                        { Console.WriteLine($"{monthNum} November"); }
                    }                                    
                    break;                               
                case 12:                                 
                    {                                    
                        { Console.WriteLine($"{monthNum} December"); }
                    }
                    break;
            }

        }

        /* 10- The output Of The Code Is : Compile Error, because there's no bool result inside the condition of if statement */
        public void Question10() {
            Console.WriteLine("The output Of The Code Is : Compile Error, because there's no bool result inside the condition of if statement ");
        }

        /* 11- The Output Of The Code Is : Compile Error, because it's (if,else)
         *but the (else if) doesn't follow to them so it need another if above it*/
        public void Question11()
        {
            Console.WriteLine("Compile Error, because it's (if,else) " +
                "but the (else if) doesn't follow to them so it need another if above it");
        }

        /* 12- The Output Of The Code Is : x is greater than y */
        public void Question12()
        {
            Console.WriteLine("x is greater than y ");
        }

        /* 13-  Write a C# Sharp program that takes three letters and displays them in reverse order.
        Test Data
        Enter letter: b
        Enter letter: a
        Enter letter: t
        Expected Output :
        t a b*/

        public void Question13()
        {
            Console.Write("Please Enter The first letter ,if you put a number it will be considered as a letter : ");
            if (!char.TryParse(Console.ReadLine(), out char letter1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Characters, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Please Enter The second letter ,if you put a number it will be considered as a letter : ");
            if (!char.TryParse(Console.ReadLine(), out char letter2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Characters, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Please Enter The third letter ,if you put a number it will be considered as a letter : ");
            if (!char.TryParse(Console.ReadLine(), out char letter3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Characters, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"The Letters In Reversed Order => {letter3}, {letter2}, {letter1}");
        }

        /* 14-Write a C# Sharp program that takes two numbers as input and performs an
         * operation (+,-,*,x,/) on them and displays the result of that operation. 
         Test Data
        Input first number: 20
        Input operation: -
        Input second number: 12
        Expected Output :
        20 - 12 = 8
         */

        public void Question14()
        {
            Console.WriteLine("This program takes two numbers as input and performs an operation (+,-,*,x,/) on them ");
            Console.Write("Enter The First Number Please : ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("Enter The Second Number Please : ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine("Choose The Operation Number : \n1) + \n2) - \n3) * \n4) /\n5) %");
            if (!byte.TryParse(Console.ReadLine(), out byte operation) || operation < 1 || operation > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine($" {num1}+ {num2} = {num1 + num2} ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($" {num1}- {num2} = {num1 - num2} ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($" {num1}* {num2} = {num1 * num2} ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($" {num1}/ {num2} = {num1 / num2} ");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($" {num1}% {num2} = {num1 % num2} ");
                        break;
                    }
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Number Choose between 1-5 Only");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        /* 15- Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
        (using integer numbers for y, ranging from -5 to +5).*/

        public void Question15()
        {
            Console.WriteLine("x = y2 + 2y + 1");
            for (int i = -5; i < 6; i++)
            {
                double result = Math.Pow(i, 2) + (2 * i) + 1;

                Console.WriteLine($" When y={i} ,X={result}");
            }
        }

        /* 16- Write a C# Sharp program to swap two numbers.
        Test Data:
        Input the First Number : 5
        Input the Second Number : 6
        Expected Output:
        After Swapping :
        First Number : 6
        Second Number : 5
        */

        public void Question16()
        {
            Console.WriteLine("Enter The numbers To Swap Between Them");
            Console.Write("Enter The 1'st Number :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 2'nd Number :");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"Number1 = {num1}\nNumber2= {num2}");

        }

        /* 17-  Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
        Test Data:
        Input the first number to multiply: 2
        Input the second number to multiply: 3
        Input the third number to multiply: 6
        Expected Output:
        2 x 3 x 6 = 36*/

        public void Question17()
        {
            Console.WriteLine("Enter The numbers To Multiplicate Between Them");
            Console.Write("Enter The 1'st Number :");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 2'nd Number :");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 3'rd Number :");
            if (!double.TryParse(Console.ReadLine(), out double num3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"{num1}x{num2}x{num3} = {num1 * num2 * num3} ");

        }

        /* 18- Write a C# Sharp program to print on screen the output of 
         * adding, subtracting, multiplying and dividing two numbers entered by the user.
        Test Data:
        Input the first number: 25
        Input the second number: 4
        Expected Output:
        25 + 4 = 29
        25 - 4 = 21
        25 x 4 = 100
        25 / 4 = 6
        25 mod 4 = 1*/

        public void Question18()
        {
            Console.WriteLine(" Printing on screen the output of adding, subtracting, multiplying and dividing two numbers");
            Console.Write("Input the first number : ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Input the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"{num1}+ {num2} = {num1 + num2} ");
            Console.WriteLine($"{num1}- {num2} = {num1 - num2} ");
            Console.WriteLine($"{num1}* {num2} = {num1 * num2} ");
            Console.WriteLine($"{num1}/ {num2} = {num1 / num2} ");
            Console.WriteLine($"{num1}% {num2} = {num1 % num2} ");
        }

        /*19- Write a C# Sharp program that prints the multiplication table of a number as input.
        Test Data:
        Enter the number: 5
        Expected Output:
        5 * 0 = 0
        5 * 1 = 5
        5 * 2 = 10
        5 * 3 = 15
        ....
        5 * 10 = 50*/

        public void Question19()
        {
            Console.WriteLine(" multiplication table of a number ");
            Console.Write("Input the first number : ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{num1}*{i}= {num1 * i}");
            }
        }

        /*20- Write a C# Sharp program that takes four numbers as input to calculate and print the average.
        Test Data:
        Enter the First number: 10
        Enter the Second number: 15
        Enter the third number: 20
        Enter the four number: 30

        Expected Output:
        The average of 10 , 15 , 20 , 30 is: 18*/

        public void Question20()
        {
            Console.WriteLine("Enter The numbers To Find Avarage Between Them");
            Console.Write("Enter The 1'st Number :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 2'nd Number :");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 3'rd Number :");
            if (!int.TryParse(Console.ReadLine(), out int num3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 4th Number :");
            if (!int.TryParse(Console.ReadLine(), out int num4))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"The Avarage of {num1},{num2},{num3},{num4} is: {(num1 + num2 + num3 + num4) / 4} ");
        }

        /* 21- Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
        Test Data:
        Enter first number - 5
        Enter second number - 6
        Enter third number - 7

        Expected Output:
        Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72 */

        public void Question21()
        {
            Console.WriteLine("Enter The numbers To solve this equations (x+y).z and x.y + y.z");
            Console.Write("Enter The 1'st Number :");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 2'nd Number :");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Enter The 3'rd Number :");
            if (!int.TryParse(Console.ReadLine(), out int num3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3}, (x+y).z is {(num1 + num2) * num3} " +
                $"and x.y + y.z is {(num1 * num2) + (num2 * num3)} ");
        }

        /* 22- Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
        Test Data:
        Enter your age - 25
        Expected Output:
        You look older than 25*/

        public void Question22()
        {
            Console.Write("Enter your age - ");
            if (!byte.TryParse(Console.ReadLine(), out byte age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"You look older than {age}");
        }

        /* 23- Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
        Test Data:
        Enter the amount of celsius: 30
        Expected Output:
        Kelvin = 303
        Fahrenheit = 86 */

        public void Question23()
        {
            Console.Write("Enter the amount of celsius: ");
            if (!int.TryParse(Console.ReadLine(), out int temp))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"Kelvin = {temp + 273}\nFahrenheit = {(temp * 9 / 5) + 32}");
        }

        /* 24- Write a C# program that removes a specified character from a non-empty string using the index of a character.
        Test Data:
        w3resource
        Sample Output:
        wresource
        w3resourc
        3resource */

        public void Question24()
        {
            string theString = "Qais Ihab Mousa Nimer";
            Console.WriteLine("the String Is : " + theString);
            Console.Write("Enter the index of the letter that you want me to remove\nstart from 0 and spaces between letters are also concidered : ");
            if (!byte.TryParse(Console.ReadLine(), out byte num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (num > theString.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Number Try Again");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Hint : Q in Qais is 0, I in Ihab is 5 because the space is included as letter and you can remove it if you pressed 4");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($" The String after remove the letter number {num} ==> {theString.Remove(num, 1)}");
        }

        /* 25- Write a C# program to compute the sum of two given integers.
         * If two values are the same, return the triple of their sum. */

        public void Question25()
        {
            Console.WriteLine(" compute the sum of two given integers, If two values are the same, return the triple of their sum. ");
            Console.Write("First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (num1 == num2)
            {
                Console.WriteLine($"Because both numbers are similer The Sum Of {num1}+{num2} = {3 * num1}");
            }
            else
            {
                Console.WriteLine($"The Sum Of {num1}+{num2} = {num1 + num2}");

            }
        }

        /* 26-  Write a C# program to get the absolute value of the difference between two given numbers.
         * Return double the absolute value of the difference if the first number is greater than the second number.*/

        public void Question26()
        {
            Console.WriteLine(" Printing on screen absolute value of the difference between two given numbers," +
                "Return double the absolute value of the difference if the first number is greater than the second number\n");
            Console.Write("First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (num1 > num2)
            {
                Console.WriteLine($"Because {num1} > {num2} I'll double the absolute value of the difference between two given numbers :" +
                    $" Difference between {num1},{num2} = {num1 - num2}\nThe Double of Absolute Value of difference: {Math.Abs(num1 - num2) * 2}");
            }
            else
            {
                Console.WriteLine($"Difference between {num1},{num2} = {num1 - num2}\nThe Absolute Value of difference: {Math.Abs(num1 - num2)}");

            }
        }

        /* 27- Write a C# program to check the sum of the two given integers.
         * Return true if one of the integers is 20 or if their sum is 20.*/

        public void Question27()
        {
            Console.WriteLine("  check the sum of the two given integers, Return true if one of the integers is 20 or if their sum is 20\n");
            Console.Write("First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            int sum20 = num1 + num2;
            if (num1 == 20 || num2 == 20 || sum20 == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"True");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine($"The Sum Of {num1}+{num2} = {num1 + num2}");

            }
        }

        /* 28-  Write a C# program to check if the given integer is within 20 of 100 or 200.
        Sample Output:
        Input an integer:
        25
        False*/

        public void Question28()
        {
            Console.WriteLine("check if the given integer is within 20 of 100 or 200, answer in (TRUE,FALSE)\n");
            Console.Write("Enter Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (Math.Abs(100 - num1) <= 20 || Math.Abs(200 - num1) <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"True");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"False");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /* 29- Write a C# program to find the GCD (Greatest Common Divisor) of two numbers */

        public void Question29()
        {
            Console.WriteLine("Greatest Common Divisor Between two Numbers");
            int num1 = GCDInput("Enter Number 1: ");
            int num2 = GCDInput("Enter Number 2: ");
            int minVal = GCDQuestion29and50(num1, num2);
            Console.WriteLine($"The GCD Of {num1},{num2}= {minVal}");
        }
        public int GCDInput(string x)
        {
            int num = WrongFormat($"{x}");
            return num;
        }
        public int GCDQuestion29and50(int num1, int num2)
        {
            int minVal = Math.Min(num1, num2);
            while (minVal > 1)
            {
                if (num1 % minVal == 0 && num2 % minVal == 0)
                {
                    break;
                }
                minVal--;
            }

            return minVal;
        }

        /*30- Write a C# program to calculate the power of a number. */

        public void Question30()
        {
            Console.WriteLine(" calculate the power of a number.");

            Console.Write("First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine($"Power Of {num1} = {Math.Pow(num1, 2)}");
        }

        /*31- Write a C# program to find the ASCII value of a character. */

        public void Question31()
        {
            Console.WriteLine(" Enter The Character To Give You The Ascii Code Of It ");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()[0]));
        }

        /* 32- Write a C# program to check if a given year is a leap year */

        //Question3();     //Note: I've already solve it in question 3

        /* 33- Write a C# program to find the sum of digits of a given number*/
        public void Question33()
        {
            int sum = 0;
            Console.WriteLine("Find Sum of digits of given number");
            Console.Write("First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            num1 = Math.Abs(num1);
            while (num1 > 0)
            {
                sum += num1 % 10;
                num1 /= 10;
            }
            Console.WriteLine(sum);
        }

        /* 34-  Write a C# program to check if a given number is a perfect number */

        public void Question34()
        {
            int sum = 0;
            Console.WriteLine("Find if a given number is a perfect number");
            Console.Write("Number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1) || num1 < 0 || num1 == 0)
            {
                if (num1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry {num1} is NOT a perfect number");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            /*Note: I knew that this case Doesn't Handle the large numbers in a good performance,
             *so I saw on CHATGPT how to handle the large number in a better way but I'll not put chatgpt solution of cource */
            int tempNum = 1;
            while (tempNum != num1 && num1 != 0)
            {
                if (num1 % tempNum == 0)
                {
                    sum += tempNum;
                }

                tempNum++;
            }
            if (sum == num1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num1} is a perfect number");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry {num1} is NOT a perfect number");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        /* 35- Write a C# program to find the area of a triangle given its three sides. */

        public void Question35()
        {
            Console.WriteLine("program to find the area of a triangle given its three sides");
            while (true)
            {
                float s1 = TakeSides("First Side :");
                float s2 = TakeSides("Second Side :");
                float s3 = TakeSides("Third Side :");
                if (IsValidTriangle(s1, s2, s3))
                {
                    float s = (s1 + s2 + s3) / 2;
                    Console.WriteLine($"The Area Of Triangle = {Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3))}");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The given sides are NOT for a valid triangle, Try Again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public float TakeSides(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (float.TryParse(Console.ReadLine(), out float side) && side > 0)
                {
                    return side;
                }
                if (side <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Format it can NOT be 0 or negative number or words or symbols, Try Again:");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public bool IsValidTriangle(float a, float b, float c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /* Write a C# program that generates a random integer between 1 and 20 
         * then prints whether it is an even number,odd number, or a multiple of 5*/

        public void Question36()
        {
            Console.WriteLine(" Generate Number 1-20, Finds Odd,Even,Multiple of 5 ");
            Random rand = new Random();
            int saveRand = rand.Next(1, 21);
            if (saveRand % 5 == 0)
            {
                Console.WriteLine($"{saveRand} is a multiple of 5");
            }
            else if (saveRand % 2 == 0)
            {
                Console.WriteLine($"{saveRand} is an even number");
            }
            else
            {
                Console.WriteLine($"{saveRand} is an odd number");
            }
        }

        /* 37- Write a C# program that generates a random integer between 1 and 100 and then checks if it is a perfect square. */

        public int generateRand(string x = "sorry I forgot to write the title of task", int min = 1, int max = 101)
        {
            Console.WriteLine($"{x}");
            return new Random().Next(min, max);
        }

        public void Question37()
        {
            int saveRand = generateRand("Generate Number 1-100, Finds if it is a perfect square.", 1, 101);
            double saveRandSqrt = Math.Sqrt(saveRand);

            if (saveRandSqrt / (int)saveRandSqrt == 1)
            {
                Console.WriteLine($"{saveRand} Perfect Square");
            }
            else
            {
                Console.WriteLine($"{saveRand} NOT Perfect Square");

            }
        }

        /* 38- Write a C# program that generates a random integer between 1 and 100
         * and then checks if it is a multiple of 7.
         * If it is, print "Multiple of 7", otherwise print "Not a multiple of 7" */

        public void Question38()
        {
            // I used a generate function from question37
            int saveRand = generateRand("Generate Number 1-100, Finds if it is a multiple of 7 or not.", 1, 101);
            if (saveRand % 7 == 0)
            {
                Console.WriteLine($"{saveRand} Multiple of 7");
            }
            else
            {
                Console.WriteLine($"{saveRand} NOT Multiple of 7");
            }
        }

        /* 39- Write a C# program that generates a random integer between 1 and 100 
         * and then checks if it is a prime number. */

        public void Question39()
        {

            int saveRand = generateRand("Generate Number 1-100, Finds if it is a prime number.", 1, 101);
            for (int i = 2; i * i <= saveRand; i++)
            {
                if (saveRand % i == 0)
                {
                    Console.WriteLine($"{saveRand} Not Prime");
                    return;
                }

            }
            Console.WriteLine($"{saveRand} Prime");

        }

        /* 40- Write a C# program that generates a random integer between 1 and 100 
         * and then checks if it is divisible by both 3 and 5.
         * If it is, print "Divisible by both 3 and 5",
         * otherwise print "Not divisible by both 3 and 5 */

        public void Question40()
        {
            int saveRand = generateRand("Generate Number 1-100, Finds if it divisable to 3 & 5.", 1, 101);
            if (saveRand % 3 == 0 && saveRand % 5 == 0)
            {
                Console.WriteLine($"{saveRand} Divisable");
            }
            else
            {
                Console.WriteLine($"{saveRand} Not Divisable");

            }
        }

        /* 41- Write a C# program that generates a random integer between 1 and 10 and then checks 
         * if it is greater than 5. If it is, print "Greater than 5",
         * otherwise print "Less than or equal to 5*/

        public void Question41()
        {
            int saveRand = generateRand("Generate Number 1-10, Finds if it greater than 5 or not.", 1, 11);
            if (saveRand > 5)
            {
                Console.WriteLine($"{saveRand} greater than 5");
            }
            else if(saveRand==5)
            {
                Console.WriteLine($"{saveRand} equal than 5");
            }
            else
            {
                Console.WriteLine($"{saveRand} less than 5");

            }
        }

        /* 42-Write a C# program that generates two random numbers between 1 and 6
         * (representing dice rolls) and prints their sum */
        public void Question42()
        {
            int dice1 = generateRand("Dice 01", 1, 7);
            int dice2 = generateRand("Dice 02", 1, 7);
            Console.WriteLine($"Dice1= {dice1} , Dice2= {dice2} => Sum = {dice1} + {dice2} = {dice1 + dice2} ");
        }

        /* 43- Write a C# program that generates a random integer between 1 and 12 
         * and then prints the corresponding month name */

        public void Question43()
        {
            // swichMonth is a function I created in question 9
            byte month = Convert.ToByte(generateRand("generate 1-12 numbers by random to print the corresponding month ", 1, 13));
            swichMonths(month);
        }

        /* 44- Write a C# program that simulates a coin toss.
         * If the result is heads, print "Heads", otherwise print "Tails" */

        public void Question44()
        {
            byte coinToss = Convert.ToByte(generateRand("Heads Or tails", 1, 11));
            if (coinToss % 2 == 0)
            {
                Console.WriteLine(" Tails ");
            }
            else
            {
                Console.WriteLine(" Heads ");

            }
        }

        /* 45- Write a C# program that generates a random number between 1 and 100 
         * and then checks if it is even or odd. */

        public void Question45()
        {
            //oddEven in question2
            oddEven(generateRand("Generate 1-10 to guess it's odd or even", 1, 11));
        }

        /* 46- Write a C# program to check if a number is even or odd. */

        //Like question 2:

        public void Question46()
        {
            int num = WrongFormat(" Enter The Number To Find If It's Odd Or Even ");
            oddEven(num);
        }
        public int WrongFormat(string x)
        {
            Console.Write($"{x}");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int num1))
                {

                    return num1;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Format I Need Only Numbers, Try Again");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /* 47- Write a C# program to generate multiplication table of a given number */

        public void Question47()
        {
            int num = WrongFormat("Enter Num To Find Multiplications of Numbers: ");
            int i = 0;
            while (i.ToString().Length < 3)
            {
                Console.WriteLine($" {num} * {i} = {num * i} ");
                i++;

            }
        }

        /* 48- Write a C# program to calculate the power of a number */

        //I've already solve this question above but still I will solve it in another way
        public void Question48()
        {
            int num = WrongFormat("Enter Num To Find Power of The Number: ");

            Console.WriteLine($"Power Of {num} = {num * num} ");

        }

        /* 49- Write a C# program to find the GCD (Greatest Common Divisor) of two numbers*/

        // I've already solved this question so I will call the method
        //Question29();

        /* 50- Write a C# program to find the LCM (Least Common Multiple) of two numbers. */

        public void Question50()
        {
            Console.WriteLine(" finding the LCM (Least Common Multiple) of two numbers. ");
            int num1 = GCDInput(" Enter Number 01: ");
            int num2 = GCDInput(" Enter Number 02: ");

            Console.WriteLine($" LCM for {num1} , {num2} =  {(Math.Abs(num1 * num2) / GCDQuestion29and50(num1, num2))}");
        }

        /* 51- Write a C# program to calculate the sum of natural numbers up to a given number */
        public void Question51()
        {
            while (true)
            {
                Console.WriteLine("program to calculate the sum of natural numbers up to a given number");
                int num1 = WrongFormat("Enter Number That You Want Me To Calculate Natural Numbers up To It :");
                int sum = 0;
                if (num1 > 0)
                {
                    for (int i = 1; i <= num1; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"The Sum= {sum}");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Should Be positive number , Try Again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        /* 52- Write a C# program to find all factors of a number.  */
        public void Question52()
        {
            Console.WriteLine("program to find all factors of a given number");
            int num1 = WrongFormat("Enter Number :");
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {

                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        /* 53- Write a C# program to display the name of a shape
         * (triangle, square, pentagon, hexagon) based on the number of angles entered by the user. */

        public void Question53()
        {
            Console.WriteLine("program to display the name of a shape " +
                "(triangle, square, pentagon, hexagon) based on the number of angles\n");
            switch (Convert.ToByte(WrongFormat("Please Enter The Number Of Angels ")))
            {
                case 3:
                    {
                        Console.WriteLine("Triangle");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Square");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Pentagon");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Hexagon");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Wrong Input, {3,4,5,6} are the valid numbers");
                        break;
                    }
            }
        }

        /* 54- Write a C# program to calculate the factorial of a number using a do..while loop*/
        public void Question54()
        {
            int i = 1;
            int num = WrongFormat("Enter The Number to Calculate The Factorials: ");
            Console.WriteLine($"Factors of {num}: ");
            if (num > 0)
            {
                do
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                while (i <= num);
            }
            else
            {
                Console.WriteLine(" Number must be greater than 0 ");
            }
            Console.WriteLine();

        }

        /* 55- Write a C# program to calculate the sum of all even numbers between 1 and 100
         * using a do..while loop. */

        public void Question55()
        {
            int num = 2, sum = 0;
            do
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                num = num + 2;
            }
            while (num <= 100);
            Console.WriteLine($"Sum of all even numbers up to 100 = {sum}");

        }

        /* 56- Write a C# program to determine if a number entered by the user is a prime number
         * using a do..while loop. */

        public void Question56()
        {
            int num = WrongFormat("determine if a number entered by the user is a prime number: ");
            int i = 2;
            if (num > 0)
            {
                do
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} Not Prime");
                        return;
                    }
                    i += 1;
                }
                while (i * i <= num);
                Console.WriteLine($"{num} is prime number");
            }
            else
            {
                Console.WriteLine($"Enter Positive Values > 0 ");
            }

        }

        /* 57-Write a C# program to calculate the average of numbers entered by the user 
         * until they enter a negative number using a do..while loop */

        public void Question57()
        {
            double avg = 0, num = 0;
            Console.WriteLine("Enter Numbers To Calculate AVG, If you want to stop enter -1");
            do
            {
                if (num >= 0)
                {
                    avg += num;
                    num = WrongFormat("Number = ");
                }
            }
            while (num >= 0);
            Console.WriteLine($"Avg= {avg/2}");
        }

        /* 58-Write a C# program that prompts the user to input any number of doubles.
         * The program stops if the user enters -100 or counts more than 30  .
        find the total and counts of all items and the average */

        public void Question58()
        {
            double total = 0;
            int count = 0;

            Console.WriteLine("input any number of doubles," +
                " The program stops if the user enters -100 or counts more than 30," +
                " find the total and counts of all items and the average:");

            while (true)
            {
                Console.Write($"Enter number {count + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out double input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid double.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (input == -100 || count >= 30)
                    break;

                total += input;
                count++;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total of all items: {total}");
            Console.WriteLine($"Number of items entered: {count}");
            if (count > 0)
            {
                Console.WriteLine($"Average: {total / count}");
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        /* 59- Write a C# program to find the factorial of a given number */
        // Question54();

        /* 60- Write a C# program to calculate the power of a number  */
         //Question48();

        /* 61- Write a C# program to find the sum of all numbers divisible by 3 or 5 below a given number */
        public void Question61()
        {
            Console.WriteLine("find the sum of all numbers divisible by 3 or 5 below a given number ");
            int num = WrongFormat("Enter Number : ");
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The Sum= {sum + 1} ");
        }

    }
}
