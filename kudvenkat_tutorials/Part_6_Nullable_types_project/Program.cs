using System;


class Program
{
    static void Main()
    {

        /**************
        2 broad categories of variables 
            - Value types : int, float, double, strucs, etc 
                > default value of value types : 0, false, etc
            - Reference types : strings, interface, Class, delegates, arrays, etc
                > default value of reference types : NULL
        ***************/


        /**************
        By default, value types are NON NULLABLE
        int i = null; // ERROR
        string d = null; // No problem
        **************/

        // to make a non nullable nullable, use a ? 
        int? i = null; // no problem, it is now a nullable data type

        bool? AreYouMajor = null; // IE : User didn't select anything in the form

        if (AreYouMajor == true)
        {
            Console.WriteLine("User is Major.");
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("User is not Major");
        }
        else
        {
            Console.WriteLine("User did not fill the field.");
        }


        // THE NULL COALESCING OPERATOR
        int? TicketsOnSale = null;
        int AvailableTickets;

        // Without null coalescing operator
        if (TicketsOnSale == null)
        {
            AvailableTickets = 0;
        }
        else
        {
            // AvailableTickets = TicketsOnSale; // Error -> int? is not int // It must be converted

            // 1st way
            AvailableTickets = TicketsOnSale.Value; // .Value returns an int type, not int?

            // 2nd way -- USUAL WAY
            AvailableTickets = (int)TicketsOnSale; // We CAST the int type on the int?

        }

        // With null coalescing operator
        AvailableTickets = TicketsOnSale ?? 0; // If TicketsOnSale is null, use 0, otherwise use TicketsOnSale
        Console.WriteLine("Available Tickets = {0}", AvailableTickets);

    }
}

