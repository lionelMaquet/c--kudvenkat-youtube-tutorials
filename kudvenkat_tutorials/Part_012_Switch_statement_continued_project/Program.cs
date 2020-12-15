using System;


class Program
{
    static void Main(string[] args)
    {
        int TotalCoffeeCost = 0;

        // LABEL BELOW, used with goto.
        // NOT RECOMMENDED AT ALL
        Start:
        // Choose a coffee !
        Console.WriteLine("What coffee do you want ?");
        Console.WriteLine("1. Small, 2. Medium, 3. Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                goto Start;
        }


        BuyAgain:
        Console.WriteLine("Do you want to buy another coffee - Yes or No?");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start; // Defined by the label above
            case "NO":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
                goto BuyAgain;
        }

        Console.WriteLine("Thanks for shopping with us");
        Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
    }
}

