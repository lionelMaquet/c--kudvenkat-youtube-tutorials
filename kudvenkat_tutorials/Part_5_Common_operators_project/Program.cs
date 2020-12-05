using System;


class Program
{
    static void Main()
    {
        // Assignment operator ( = )
        int i = 10;
        bool b = true;

        // Arithmetic operators ( +, -, *, /, % )
        i = 4 + 2; // 6
        i = 4 - 2; // 2
        i = 4 * 2; // 8
        i = 4 / 2; // 2
        i = 5 % 2; // Reminder operator -> 1

        // Comparison operators ( ==, !=, >, >=, <, <= ) 
        b = 4 == 2; // false
        b = 4 != 2; // true
        b = 2 > 2; // false
        b = 2 >= 2; // true
        b = 4 < 2; // false
        b = 4 <= 2; // false

        // Conditional operators ( &&, || )
        b = (2 == 2 && 4 == 2); // false
        b = (2 == 2 || 4 == 2); // true

        // Ternary operator ( ? : )
        i = (2 == 2) ? 4 : 3; // i gets 4 because 2 == 2 is true
        i = (4 == 2) ? 4 : 3; // i gets 3 because 4 == 2 is false
        b = (4 == 2) ? false : true; // b gets true because 4 == 2 is false
        
        // Null Coalescing Operator ( ?? ) is seen later
    }
}

