using System;

namespace _01OperatingNVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sumResult = 2 + 3;
            int operationResult = 2 * 3;
            operationResult = 10/5; // example with binary operators
            operationResult = 3-2;

            operationResult = 26 % 4;

            operationResult = sumResult++; //example with unary operators

            // var sumResult = $"2 + 3 = {2+3}";
            // int sumResult;

            // Console.WriteLine("The result of the operation is: ");
            // Console.WriteLine($"2 + 3 = {sumResult}");
            // Console.WriteLine($"The value of other operation: {operationResult}");
            Console.WriteLine("Variables' values:");
            Console.WriteLine("");
        }
    }
}
