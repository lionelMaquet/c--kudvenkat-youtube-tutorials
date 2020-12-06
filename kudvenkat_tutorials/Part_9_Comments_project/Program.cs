using System;


class Program
{
    static void Main()
    {
        // Single line comment

        /*
        MULTI
        LINE
        COMMENT 
         */

        SampleClass MySampleClass = new SampleClass();
        // -> hover over SampleClass, it shows information because of the XML Documentation Comment below
    }
}

// Xml Document comment below 
/// <summary>
/// This is a sample class and a sample documentation
/// </summary>
public class SampleClass
{
}

