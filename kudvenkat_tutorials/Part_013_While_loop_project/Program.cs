using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your target number");

        int UserTarget = int.Parse(Console.ReadLine());
        int Start = 0;

        while (Start <= UserTarget) // The whole block below is executed UNTIL this expression is evaluated to false. 
        {
            Console.WriteLine(Start);
            Start ++;
        }
    }
}

