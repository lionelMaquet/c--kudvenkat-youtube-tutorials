using System;


class Program
{
    static void Main()
    {
        int i = 100;
        // We want to convert it to a float
        float f = i; // Done ! 
        /*
        This is an IMPLICIT conversion 
        Converting an int to a float will not lose any data
        and no exception will be thrown, hence an IMPLICIT 
        conversion happens.
        */
        Console.WriteLine(f);

        // Now the other way around 

        float ff = 123.45f;
        // int ii = ff; // Error ! Cannot implicitly convert 
        // We need to do it EXPLICITLY

        // 1st option : with cast 
        int ii = (int)ff;
        Console.WriteLine(ii);

        // 2nd option : with the Convert class
        ii = Convert.ToInt32(ff);
        Console.WriteLine(ii);



        // What's the difference between both options ? 

        // Let's say we have a big float, too big for an int 
        float myBigFloat = 1273734343343.45f;
        int myInt = (int)myBigFloat;
        Console.WriteLine(myInt); // -2147483648
        // This DOES NOT throw an exception but since it can't hold it
        // it gets the min value of an int. 

        myInt = Convert.ToInt32(myBigFloat);
        // On the other hand, the convert class throws an exception. 


        // Finally, there is still another way to convert strings to numbers.
        // The parse method
        string strNumber = "100";
        int myNumber = int.Parse(strNumber);

        // The parse method exists as TryParse also, it returns a boolean
        int Result = 0;
        bool isConversionSuccessful = int.TryParse(strNumber, out Result);

        // use parse if you're sure there will be no error, tryparse 
        // if you're not.

    }
}

