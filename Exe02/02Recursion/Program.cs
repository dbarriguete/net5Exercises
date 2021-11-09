using System;

namespace _02Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I do calculation of Fibonacci numbers. ");
            Console.WriteLine($"Remember the max value: {int.MaxValue:N}");
            // For more information go to: 
            // https://en.wikipedia.org/wiki/Fibonacci_number
            
            int fibNumberToGet=AskForNumber();

            while (fibNumberToGet>=0)
            {   
                try
                {             
                int resultNoRecursion = FibonacciWithoutRecursion(fibNumberToGet);
                Console.WriteLine($"The fibonacci (using NoRecursion) of {fibNumberToGet} is: {resultNoRecursion:N}");

                int resultRecursion = FibonacciWithRecursion(fibNumberToGet);
                Console.WriteLine($"The fibonacci (using Recursion) of {fibNumberToGet} is: {resultRecursion:N}");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"The fibonacci of {fibNumberToGet} is greater than {int.MaxValue}");
                }

                Console.WriteLine("************************");
                Console.WriteLine("");
                fibNumberToGet=AskForNumber();
            }

            Console.WriteLine("Thanks for using Fibonacci calculator.");
        }

        static int AskForNumber()
        {
            Console.WriteLine("What Fibonacci number do you want to get?");
            string initialNumber = Console.ReadLine();
            int fibNumberToGet=0;
            if ( !int.TryParse(initialNumber, out fibNumberToGet))
            {
                Console.WriteLine($"The provided value \"{initialNumber}\" is not a number");
                return -1;
            }
            return fibNumberToGet;
        }

        //fib(0) = 0
        //fib(1) = 1
        static int FibonacciWithoutRecursion(int number)
        {
            checked
            {
                int previousFibValue =1;
                int previousNumber =1;
                int prePreviousFibValue=0;
                int prePreviousNumber=0;
                int cacheValue;

                if(number==0)
                {
                    return 0;
                } 
                else if(number == 1)
                {
                    return 1;
                }

                while (previousNumber<number)
                {
                    cacheValue = previousFibValue;
                    previousFibValue = previousFibValue + prePreviousFibValue;
                    previousNumber++;
                    prePreviousFibValue = cacheValue;
                    prePreviousNumber++;
                }

                return previousFibValue;
            }
        }

        //Fib(0)=0
        //Fib(1)=1
        static int FibonacciWithRecursion(int number)
        {   
            checked
            {
                if(number==0)
                {
                    return 0;
                }
                else if (number==1)
                {
                    return 1;
                }
                else
                {
                    return FibonacciWithRecursion(number-1) + FibonacciWithRecursion(number-2);
                }
            }
        }

    }
}
