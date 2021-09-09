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


            // Console.WriteLine("Variables' values:");
            // Console.WriteLine($"Sum Result: {sumResult}");
            // Console.WriteLine($"Operation Result: {operationResult}");

            ////Using unary operators
            //int autoSum = 1;
            //Console.WriteLine($"Using unary operators: {autoSum}");
            //autoSum++;
            //Console.WriteLine($"after using ++ {autoSum}");
            //autoSum--;
            //Console.WriteLine($"after using -- {autoSum}");
            //Console.WriteLine("");
            //Console.WriteLine("########################################################");
            //Console.WriteLine("");
            //autoSum=20;
            //Console.WriteLine($"After set to {autoSum} using ++ in the end {autoSum++}");
            //Console.WriteLine($"After the writeline {autoSum}");


            //Console.WriteLine($"Current value {autoSum} using ++ in the beginning {++autoSum}");
            //Console.WriteLine($"After the writeline {autoSum}");

            //autoSum=20;
            //Console.WriteLine($"After set to {autoSum} using -- in the end {autoSum--}");
            //Console.WriteLine($"After the writeline {autoSum}");


            //Console.WriteLine($"Current value {autoSum} using -- in the beginning {--autoSum}");
            //Console.WriteLine($"After the writeline {autoSum}");

            //// Assignment operators
            //int operand01 = 20;
            //Console.WriteLine($"Operand value {operand01}");
            //operand01 += 5;
            //Console.WriteLine($"after += 5 : {operand01}");
            //operand01 -= 3;
            //Console.WriteLine($"after -= 3 : {operand01}");
            //operand01 *= 2;
            //Console.WriteLine($"after *= 2 : {operand01}");
            //operand01 /= 2;     
            //Console.WriteLine($"after /= 2 : {operand01}");

            bool boolVariableA = true;
            bool boolVariableB = false;

            // Logical operators
            //Console.WriteLine($"AND |      A |      B");
            //Console.WriteLine($"A   | {boolVariableA & boolVariableA}   | {boolVariableA&         boolVariableB}");
            //Console.WriteLine($"B   | {boolVariableB & boolVariableA}  | {boolVariableB&         boolVariableB}");
            //Console.WriteLine("");
            //Console.WriteLine($"OR  |      A |      B");
            //Console.WriteLine($"A   | {boolVariableA | boolVariableA}   | {boolVariableA|boolVariableB}");
            //Console.WriteLine($"B   | {boolVariableB | boolVariableA}   | {boolVariableB|boolVariableB}");
            //Console.WriteLine("");
            //Console.WriteLine($"XOR |      A |      B");
            //Console.WriteLine($"A   | {boolVariableA ^ boolVariableA}  | {boolVariableA^boolVariableB}");
            //Console.WriteLine($"B   | {boolVariableB ^ boolVariableA}   | {boolVariableB^boolVariableB}");

            // Logical operators AND Conditional logical operators.
            Console.WriteLine($" A & AdditionalFunction() = {boolVariableA & AdditionalFunction()} ");
            Console.WriteLine($" B & AdditionalFunction() = {boolVariableB & AdditionalFunction()} ");

            Console.WriteLine($" A && AdditionalFunction() = {boolVariableA && AdditionalFunction()} ");
            Console.WriteLine($" B && AdditionalFunction() = {boolVariableB && AdditionalFunction()} ");

            Console.WriteLine($" A | AdditionalFunction() = {boolVariableA | AdditionalFunction()} ");
            Console.WriteLine($" B | AdditionalFunction() = {boolVariableB | AdditionalFunction()} ");

            Console.WriteLine($" A || AdditionalFunction() = {boolVariableA || AdditionalFunction()} ");
            Console.WriteLine($" B || AdditionalFunction() = {boolVariableB || AdditionalFunction()} ");
            
        }


        private static bool AdditionalFunction()
        {
            Console.WriteLine("");
            Console.WriteLine("I'm doing something here, just give me a second.");
            return true;
        }
    }
}
