using System;


class Program
{
    static void Main()
    {
        String Name = "Lionel";
        Console.WriteLine(Name);

        // If we want to print the double quotes, we've got to ESCAPE them
        Name = "\"Lionel\"";
        Console.WriteLine("With escape character : {0}", Name);

        // All the escape sequences : https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-160

        // EXAMPLES 
        // IE : The new line escape sequence
        Console.WriteLine("One\nTwo\nThree");

        // IE : THe backslash escape sequence 
        Console.WriteLine("C:\\Users\\desktop");

        // "C:\\Users\\desktop" is not easy to read
        // To be easier to read : Verbatim Literal 
        string Path = @"C:\Users\desktop";
        // With an @, all escape sequences are NOT treated as escape sequences
        Console.WriteLine("Path with verbatim literal : {0}", Path);
        Console.WriteLine("New line with verbatim literal : {0} ",@"One\nTwo\nThree");
    }
}

