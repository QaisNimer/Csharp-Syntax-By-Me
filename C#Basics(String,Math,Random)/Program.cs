/* String Methods */
Console.WriteLine("1) The String Methods :");
String name = "Qais Ihab Nimer";
Console.WriteLine($"The String : {name}");
Console.WriteLine("_____________________ 1.a)Formating ___________________");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"To Upper : {name.ToUpper()}");
Console.WriteLine($"To Lower : {name.ToLower()}");
Console.WriteLine($"Replace : {name.Replace("Q","Q Has Been Replaced ")}");
Console.WriteLine($"Remove From Index X to Index Y : {name.Remove(2, 5)}"); //Expected Output: Qaab Nimer
Console.WriteLine($"Remove From Index X to the last Index : {name.Remove(2)}");
Console.WriteLine($"Substring From Index X , Y is Length(Not index ((start count at 1)) and Remove the rest : {name.Substring(0,6)}");//Expected Output: Qais Ih
Console.WriteLine($"Substring and remove everything until Index X: {name.Substring(2)}"); //Expected Output: is Ihab Nimer
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
string trimDemo = "         string       ";
Console.WriteLine($"The String : {trimDemo}");
Console.WriteLine($"Trim : {trimDemo.Trim()}");
Console.WriteLine($"Trim Start: {trimDemo.TrimStart()}");
Console.WriteLine($"Trim End: {trimDemo.TrimEnd()}");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Reverse : {name.Reverse()}"); //Will not give me an output
//To Solve this issue we have to add a newString = new String(name.Reverse().ToArray());
string reversedName = new string(name.Reverse().ToArray());
Console.WriteLine($"Reverse : {reversedName}"); //Will not give me an output
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Red;
string nameBeforeSplit = "Qais Ihab Nimer";
string[] nameAfterSplitInArr=nameBeforeSplit.Split('i');
string result=String.Join(", ", nameAfterSplitInArr);
Console.WriteLine($"Split: Split String into substrings based on the char that you put it inside the Split(' char '): {result}");

string nameBeforeToCharArr = "Qais Ihab Nimer";
char[] nameAfterToCharArray = nameBeforeToCharArr.ToCharArray();
string resultCharArr = string.Join(", ", nameAfterToCharArray);
Console.WriteLine($"ToCharArray: Copies the Char in this instance to a unicode char array: {resultCharArr}");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("_____________________ 1.b) Comparing___________________");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Equals: {name.Equals("Qais Ihab Nimer",StringComparison.OrdinalIgnoreCase)}"); //Expected Output: True
Console.WriteLine($"Contains: {name.Contains("sr")}"); //Expected Output: False
Console.WriteLine($"Start With: {name.StartsWith("qa")}"); //Expected Output: False
Console.WriteLine($"End With: {name.EndsWith("er")}"); //Expected Output: True
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("_____________________ 1.c) Searching ___________________");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Element At: {name.ElementAt(0)}"); //Expected Output: Q
Console.WriteLine($"Index Of: {name.IndexOf("ais")}"); //Expected Output: 1
Console.WriteLine($"Last Index Of: {name.LastIndexOf("a")}"); //Expected Output: 7
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("_____________________ 1.d) Validation ___________________");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Is Null Or Empty: {string.IsNullOrEmpty(name)}"); //Expected Output: False
Console.WriteLine($"Is Null Or White Space: {string.IsNullOrWhiteSpace(name)}"); //Expected Output: False
Console.ForegroundColor = ConsoleColor.White;

/* Math */
Console.WriteLine("____________________ 2) The Math Methods : _________________");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($" Power (2,5)= {Math.Pow(2,5)} ");
Console.WriteLine($" Square Root (9) = {Math.Sqrt(9)} ");
Console.WriteLine($"Ceiling (9.95336) = { Math.Ceiling(9.95336)}"); // greater number
Console.WriteLine($"Rounding (9.95336) = {Math.Round(9.95336,3)}"); //Rounding up to 3
Console.WriteLine($"Floor (9.95336) = {Math.Floor(9.95336)}"); // lower number
Console.ForegroundColor = ConsoleColor.White;

/* Random */
Console.WriteLine("____________________ 3) The Random Methods : _________________");
Console.ForegroundColor = ConsoleColor.Cyan;
Random r1;//Null => Not in heap
Random r2 = new Random();

Console.WriteLine();
Console.WriteLine($" Next : generate a random int number in each time => {r2.Next()}");
Console.WriteLine($" Next : generate a random int number in each time up to 99=> {r2.Next(100)}");
Console.WriteLine($" Next : generate a random int number in each time from 15 up to 99=> {r2.Next(15, 100)}");
Console.WriteLine($" Next : generate a random floating point number in each time between 0,1 => {r2.NextDouble()}"); //ex:0.6533245 
Console.ForegroundColor = ConsoleColor.White;
