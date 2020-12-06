using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1) // Condition
        {
            // This block is executed if the condition equals TRUE
            Console.WriteLine("Your number is one");
        }
        else if (UserNumber == 2) // Condition checked if first condition equals false
        {
            // this block is executed if the condition is checked and equals true
            Console.WriteLine("Your number is two");
        }
        else
        {
            // This block is only executed if all previous conditions are FALSE
            Console.WriteLine("Your number is not between one and two");
        }
    }


    // Difference between || and | (OR)
    // With ||, if the first condition is true, the second is not checked
    // With |, it will check both sides even if the first one is true

    // Difference between && and & (AND)
    // with &, if the first condition is false, the second is not checked
    // With &, it will check both sides even if the first one is false

    // In short, always use || and &&, offering a very slight speed boost.
}

