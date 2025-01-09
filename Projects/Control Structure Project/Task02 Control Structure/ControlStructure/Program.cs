using ControlStructure;
Methods m = new Methods();
int userChoice=0;

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Please enter the number of the case (1-61) or press 0 to exit:");
    Console.ForegroundColor = ConsoleColor.White;

    bool validInput = false;

    while (!validInput)
    {
        if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > 61)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a number between 0 and 61.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            validInput = true; 
        }
    }

    switch (userChoice)
    {
        case 1:
            m.Question1();
            break;
        case 2:
            m.Question2();
            break;
        case 3:
            m.Question3();
            break;
        case 4:
            m.Question4();
            break;
        case 5:
            m.Question5();
            break;
        case 6:
            m.Question6();
            break;
        case 7:
            m.Question7();
            break;
        case 8:
            m.Question8();
            break;
        case 9:
            m.Question9();
            break;
        case 10:
            m.Question10();
            break;
        case 11:
            m.Question11();
            break;
        case 12:
            m.Question12();
            break;
        case 13:
            m.Question13();
            break;
        case 14:
            m.Question14();
            break;
        case 15:
            m.Question15();
            break;
        case 16:
            m.Question16();
            break;
        case 17:
            m.Question17();
            break;
        case 18:
            m.Question18();
            break;
        case 19:
            m.Question19();
            break;
        case 20:
            m.Question20();
            break;
        case 21:
            m.Question21();
            break;
        case 22:
            m.Question22();
            break;
        case 23:
            m.Question23();
            break;
        case 24:
            m.Question24();
            break;
        case 25:
            m.Question25();
            break;
        case 26:
            m.Question26();
            break;
        case 27:
            m.Question27();
            break;
        case 28:
            m.Question28();
            break;
        case 29:
            m.Question29();
            break;
        case 30:
            m.Question30();
            break;
        case 31:
            m.Question31();
            break;
        case 32:
            m.Question3();
            break;
        case 33:
            m.Question33();
            break;
        case 34:
            m.Question34();
            break;
        case 35:
            m.Question35();
            break;
        case 36:
            m.Question36();
            break;
        case 37:
            m.Question37();
            break;
        case 38:
            m.Question38();
            break;
        case 39:
            m.Question39();
            break;
        case 40:
            m.Question40();
            break;
        case 41:
            m.Question41();
            break;
        case 42:
            m.Question42();
            break;
        case 43:
            m.Question43();
            break;
        case 44:
            m.Question44();
            break;
        case 45:
            m.Question45();
            break;
        case 46:
            m.Question46();
            break;
        case 47:
            m.Question47();
            break;
        case 48:
            m.Question48();
            break;
        case 49:
            m.Question29();
            break;
        case 50:
            m.Question50();
            break;
        case 51:
            m.Question51();
            break;
        case 52:
            m.Question52();
            break;
        case 53:
            m.Question53();
            break;
        case 54:
            m.Question54();
            break;
        case 55:
            m.Question55();
            break;
        case 56:
            m.Question56();
            break;
        case 57:
            m.Question57();
            break;
        case 58:
            m.Question58();
            break;
        case 59:
            m.Question54();
            break;
        case 60:
            m.Question48();
            break;
        case 61:
            m.Question61();
            break;
        case 0:
            Console.WriteLine("Exiting the program...");
            break;
        default:
            Console.WriteLine("Invalid case. Please choose a valid case number between 1 and 61.");
            break;
    }

} while (userChoice != 0);
