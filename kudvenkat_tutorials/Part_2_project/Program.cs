using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name");
        string Username = Console.ReadLine();
        //Console.WriteLine("Hello " + Username); // Concatenation 
        Console.WriteLine("Please enter your age");
        string Age = Console.ReadLine();
        Console.WriteLine("Hello {0}, you are {1}.", Username, Age); // With placeholder syntax
            // ! Writing {0 1} doesn't work. You must write {0} {1} !

    }
}

