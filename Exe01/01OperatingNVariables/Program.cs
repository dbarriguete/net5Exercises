using System;

namespace _01OperatingNVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int sumResult = 2 + 3;
            //int operationResult = 2 * 3;
            //operationResult = 10/5; // example with binary operators
            //operationResult = 3-2;
            //operationResult = 26 % 4;
            //operationResult = sumResult++; //example with unary operators
            //Console.WriteLine("Variables' values:");
            //Console.WriteLine($"Sum Result: {sumResult}");
            //Console.WriteLine($"Operation Result: {operationResult}");

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

            // bool boolVariableA = true;
            // bool boolVariableB = false;

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

            //// Logical operators AND Conditional logical operators.
            //Console.WriteLine($" A & AdditionalFunction() = {boolVariableA & AdditionalFunction()} ");
            //Console.WriteLine($" B & AdditionalFunction() = {boolVariableB & AdditionalFunction()} ");

            //Console.WriteLine($" A && AdditionalFunction() = {boolVariableA && AdditionalFunction()} ");
            //Console.WriteLine($" B && AdditionalFunction() = {boolVariableB && AdditionalFunction()} ");

            //Console.WriteLine($" A | AdditionalFunction() = {boolVariableA | AdditionalFunction()} ");
            //Console.WriteLine($" B | AdditionalFunction() = {boolVariableB | AdditionalFunction()} ");

            //Console.WriteLine($" A || AdditionalFunction() = {boolVariableA || AdditionalFunction()} ");
            //Console.WriteLine($" B || AdditionalFunction() = {boolVariableB || AdditionalFunction()} ");
            

            // Shift operators
            int number01 = 7;  // 0000 0000 0000 0000 0000 0000 0000 0111 
            int number02 = 12; // 0000 0000 0000 0000 0000 0000 0000 1100 
            int number03 = 1;// 0000 0000 0000 0000 0000 0000 0000 0001 
            
            //Console.WriteLine($"Value of number01: {number01}");
            //Console.WriteLine($"Value of number02: {number02}");
            //Console.WriteLine($"number01 & number02 = {number01&number02}"); // 4 = 0100
            //Console.WriteLine($"number01 | number02 = {number01|number02}"); // 15 = 1111
            //Console.WriteLine($"number01 ^ number02 = {number01^number02}"); // 11 = 1011


            // 1010
            // XWRP

            // Admin=000001, Manager=000010, SuperUser=000100, Contributor=001000, Reader=010000, Public=1000000, Country= 10000000, State = 100000000
            // CountryAdmin = 10000001, StateAdmin = 100000001, CountryStateAdmin = 110000001

            // var MyUser = 000111
            // var AnonymousUser = 1000000
            // var Writer = 011000


            //// example for user permissions as Linux
            //int userrole = 000111;
            //int permissionAccess = 000010 ;// Manager

            //if( (permissionAccess&userrole) == permissionAccess)
            //{
            //    //allow the user to access this section
            //}


            //Binary shift operators "<<" ">>" 
            Console.WriteLine($"number03 = {number03}"); // 0001    
            Console.WriteLine($"<< applied to number03 twice: {number03<<2}"); // 4 0100
            
            Console.WriteLine($"number02 = {number02}");// 1100
            Console.WriteLine($">> applied to number02 once: {number02>>1}"); // 6 0110

            number01 = 1073741825; // 0100 0000 0000 0000 0000 0000 0000 0001
            Console.WriteLine($"number01 = {number01}"); // 1000 0000 0000 0000 0000 0000 0000 0010
            Console.WriteLine($"<< applied to number01 twice: {number01<<1}");
            Console.WriteLine($">> applied to number01 30: {number01>>30}"); 

            //nameof sizeof
            Console.WriteLine($"nameof number01: {nameof(number01)}");
            Console.WriteLine($"nameof number01: {nameof(System.Text.StringBuilder)}");
            Console.WriteLine($"sizeof int: {sizeof(int)} bytes");
            Console.WriteLine($"1 byte = 8 bit ");
        }


        private static bool AdditionalFunction()
        {
            Console.WriteLine("");
            Console.WriteLine("I'm doing something here, just give me a second.");
            return true;
        }
    }
}
