using System;


class Program
{
    static void Main()
    {
        // Integer array
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        //EvenNumbers[2] = "hello"; // Error, array is of type int!

        // An array is of fixed length

        int[] myArray = { 1, 2, 3 }; // Same as saying that the size is 3
        Console.WriteLine(myArray.Length);
        // myArray[3] = 4; // Error ! Index out of range.
    }
}

