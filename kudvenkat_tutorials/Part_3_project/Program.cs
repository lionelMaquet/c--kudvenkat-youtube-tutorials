using System;


class Program
{
    static void Main(string[] args)
    {
        /***      BOOLEAN TYPE     ***/

        // A boolean can ONLY be true or false
        bool myBoolean = true;





        /***      INTEGRAL TYPES     ***/

        // sbyte is between -128 & 127
        // it is a SIGNED 8bit integer
        sbyte mySbyte = 127;

        // byte is between 0 & 255
        // it is an UNSIGNED 8bit integer
        byte myByte = 255;

        // short is between -32,768 & 32,767
        // it is a SIGNED 16bit integer
        short myShort = 32_767;

        // ushort is between 0 & 65535
        // it is an UNSIGNED 16bit integer
        ushort myUshort = 65_535;

        // int is between -2,147,483,648 & 2,147,483,647
        // it is a SIGNED 32bit integer
        int myInt = 2_147_483_647;

        // uint is between 0 & 4,294,967,295
        // it is an UNSIGNED 32bit integer
        uint myUint = 4_294_967_295;

        // long is between -9,223,372,036,854,775,808 & -9,223,372,036,854,775,807
        // it is a SIGNED 64bit integer
        long myLong = 9_223_372_036_854_775_807;

        // ulong is between 0 & 18,446,744,073,709,551,615
        // it is an UNSIGNED 64bit integer
        ulong myUlong = 18_446_744_073_709_551_615;





        /***      FLOATING TYPES     ***/

        float myFloat = 1.22241111111f; // important de mettre le f en suffixe
            // a float has a 7 decimal digits precision. It is 32bits
        double myDouble = 123.1213131; // un Double fait le double de la taille d'un float
            // a double has a 15 decimal digits precision. It is 64bits
        decimal myDecimal = 300.5m; // important de mettre le m en suffixe 
            // 128 bits mais TRES lent, utilisé pour les calculs d'argent.


        // EXEMPLES
        float testFloat = 1f / 16514981984159845f;
        double testDouble = 1.0 / 16514981984159845.0;
        Console.WriteLine("Precision avec un float : {0}", testFloat);
        Console.WriteLine("Precision avec un double: {0}", testDouble);

        // Double is for speed, decimal for precision 
        // Decimal takes much more time to compute, because it uses base-10 math.
        // Decimal is used for money calculations for example.

        // RESUME 
        // Use double for non-integer math where the most precise answer isn't necessary.
        // Use decimal for non-integer math where precision is needed (e.g. money and currency).

        /********/


        // How do i know the min and max of this type ? 
        Console.WriteLine("Min of int is {0}, max is {1}", int.MinValue, int.MaxValue);
    }
}

