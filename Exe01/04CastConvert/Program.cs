using System;

namespace _04CastConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting and Convert examples.");

            // // integral numeric types in C# https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            // sbyte signedByteVariable=0; //7 bits number with sign 1000 0000 : -128 to 127
            // short shortVariable=0;
            int integerVariable =0; // 32 bits integer number with sign
            // // floating point numeric types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            long longVariable=0; //64 bits long number with sign
            // decimal decimalVariable=0; // to store exact numbers for money, measures or something else us this one
            // float floatVariable=0; // 9,000,000.00 in float = (9.000001999*10^6) -0.001
            double doubleVariable=0;
            
            // byte byteVariable=0; // 8 bits number without sign 0000 0000 : 0 to 255
            // uint uIntegerVariable =0;
            // ulong uLongVariable=0;
            // ushort uShortVariable=0;

            // // implicit conversion
            // integerVariable = 10;
            // doubleVariable = integerVariable;
            // Console.WriteLine("values of: ");
            // Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable}");

            // // explicit cast (conversion)
            // doubleVariable = 10.5;
            // integerVariable = (int)doubleVariable; // 10.5 -> 10 // the .5 information is lost
            // Console.WriteLine("Values of: ");
            // Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable}");

            longVariable=25;
            integerVariable = (int) longVariable;
            Console.WriteLine("Values of: ");
            Console.WriteLine($"integerVariable: {integerVariable}, longVariable: {longVariable} ");

            //using the MinValue or MaxValue
            longVariable = long.MinValue;
            integerVariable = (int) longVariable; // 1000 0000 0000 0000 0000 0000 0000 0001
            Console.WriteLine($"integerVariable: {integerVariable:C}, longVariable: {longVariable:C} ");
            longVariable = long.MaxValue;
            integerVariable = (int) longVariable;
            Console.WriteLine($"integerVariable: {integerVariable:N0}, longVariable: {longVariable:N0} ");

            longVariable = 9_000_000; // 9000000
            integerVariable = (int) longVariable;
            Console.WriteLine($"integerVariable: {integerVariable}, longVariable: {longVariable} ");

            //Using convert instead of cast, remember convert usually rounds the number
            longVariable=25;
            integerVariable = Convert.ToInt32(longVariable);
            Console.WriteLine("############################################################");
            Console.WriteLine("Converting values: ");
            Console.WriteLine($"integerVariable: {integerVariable}, longVariable: {longVariable} ");

            doubleVariable=25.9;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");

            doubleVariable=25.5;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");

            doubleVariable=25.4;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");

            Console.WriteLine("#####");
            Console.WriteLine("#####");
            doubleVariable=25.5;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");
            doubleVariable=26.5;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");
            doubleVariable=27.5;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");
            doubleVariable=28.5;
            integerVariable = Convert.ToInt32(doubleVariable);
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");
            Console.WriteLine("#####");
            Console.WriteLine("#####");

            // testing round on Cast 
            Console.WriteLine("############################################################");
            Console.WriteLine("Test cast round");
            doubleVariable=25.9;
            integerVariable = (int)doubleVariable;
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");

            doubleVariable=25.4;
            integerVariable = (int)doubleVariable;
            Console.WriteLine($"integerVariable: {integerVariable}, doubleVariable: {doubleVariable} ");

            doubleVariable=25.4;
            while (doubleVariable<26.7)
            {
                Console.WriteLine($"Double value: {doubleVariable} is rounded: {Math.Round(doubleVariable,0, MidpointRounding.AwayFromZero )} ") ;

                doubleVariable += .1;
                if(doubleVariable >= 25.7 && doubleVariable<26 )
                {
                    doubleVariable = 26.4;
                }
            }
        }
    }
}
