using System.Threading.Tasks;
using GenericHelper_Password_Validation_;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to the Password Validation Program, I Will Check If Your Pass Is Acceptable ");
Console.ForegroundColor = ConsoleColor.White;

string pass = await "".GenerateRandomPassword(8);
Console.WriteLine($"Final valid password: {pass}");