using System;

namespace _06Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference for numerical types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            Console.WriteLine("Control the Overflow!!!");


            try
            {
                checked
                {
                    // Remember, for short: short values go from -32,768 to 32,767
                    short myShortVariable = 32765;
                    string binary = Convert.ToString(myShortVariable, 2);

                    Console.WriteLine($"myShortVariable value is: {myShortVariable:N}, binary value is: {binary}");
                    myShortVariable++;
                    binary = Convert.ToString(myShortVariable, 2);
                    Console.WriteLine($"after +1, myShortVariable value is: {myShortVariable:N}, binary value is: {binary}");
                    myShortVariable++;
                    binary = Convert.ToString(myShortVariable, 2);
                    Console.WriteLine($"after +1, myShortVariable value is: {myShortVariable:N}, binary value is: {binary}"); // 0111 1111 1111 1111 + 1 =  1000 0000 0000 0000
                    myShortVariable++; 
                    binary = Convert.ToString(myShortVariable, 2);
                    Console.WriteLine($"!!!!!! after +1 the limit, myShortVariable value is: {myShortVariable:N}, binary value is: {binary}"); // 1000 0000 0000 0000 + 1 = 1000 0000 0000 0001
                    myShortVariable++;
                    binary = Convert.ToString(myShortVariable, 2);
                    Console.WriteLine($"!!!!!! after +1 the limit, myShortVariable value is: {myShortVariable:N}, binary value is: {binary}"); // 1000 0000 0000 0000 + 1 = 1000 0000 0000 0002

                    myShortVariable= -1;
                    binary = Convert.ToString(myShortVariable, 2);
                    Console.WriteLine($"myShortVariable value is: {myShortVariable:N}, binary value is: {binary}"); // 1000 0000 0000 0000 + 1 = 1000 0000 0000 0002
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow is under control.");                
            }

            unchecked
            {
                int myIntVariable = int.MaxValue+1;
                
                string binary = Convert.ToString(myIntVariable, 2);
                Console.WriteLine($"myShortVariable value is: {myIntVariable:N}, binary value is: {binary}"); // 1000 0000 0000 0000 + 1 = 1000 0000 0000 0002
            }
        }
    }
}
