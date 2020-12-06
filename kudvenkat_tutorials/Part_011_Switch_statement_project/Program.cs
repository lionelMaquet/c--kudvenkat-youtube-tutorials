using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 30");
                break;
            case 40: // Joining multiple case statements
            case 50:
            case 60:
                Console.WriteLine("Your number is 40, 50 or 60 and is {0}", UserNumber);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }
    }
}

