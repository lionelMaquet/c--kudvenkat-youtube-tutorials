using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name");
        string Username = Console.ReadLine();
        //Console.WriteLine("Hello " + Username); // Concaténation 
        Console.WriteLine("Please enter your age");
        string Age = Console.ReadLine();
        Console.WriteLine("Hello {0}, you are {1}.", Username, Age); // Avec placeholder syntax
            // Attention , écrire {0 1} ne fonctionne pas, il faudra {0} {1}

    }
}

