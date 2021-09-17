using System;
using System.Text;

namespace _02SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //// if-else statement
            // int counter = 5;
            // //something processes counter and changes its value 
            // counter=3;

            // if ( counter == 3 )
            // {
            //     Console.WriteLine("Counter value is 3");
            //     Console.WriteLine("Counter has not its initial value");
            // }
            // else if (counter == 5)
            // {
            //     Console.WriteLine("Counter value is not 3");
            //     Console.WriteLine($"Counter value is {counter}");
            // }
            // else if (counter ==6)
            // {
            //     Console.WriteLine("Counter is neither 3 nor 5.");
            // }
            // else
            // {
            //     Console.WriteLine("Counter value is different than 3");
            //     Console.WriteLine($"Counter value is {counter}");
            // }

            // // if statement using Pattern matching
            // Object imAnInteger = 7;
            // Object imAFloat = (float)7.756;
            // int threeTimes=3;
            
            // if( imAnInteger is int myInt)
            // {
            //     Console.WriteLine($"imAnInteger is a number and 3 times it is: {myInt*threeTimes}");
            // }
            // else
            // {
            //     Console.WriteLine("imAnInteger is not a number, it's something else");
            // }

            // if(imAFloat is float myFloat)
            // {
            //     Console.WriteLine($"imAfloat is a number and its value is: {myFloat}");
            // }
            // else
            // {
            //     Console.WriteLine("imAFloat is not a number, it's something else");
            // }

            //// switch statement
            // int executionTimes =1; 
            // int numericCondition = 77;
            // // int conditionValue =10;

            
            // MyLabel: 
            // Console.WriteLine($"Executing application: {executionTimes++} time(s)");

            // switch(numericCondition)
            // {
            //     case 1:
            //         Console.WriteLine("Numeric condition allows me to print the firstline");
            //         Console.WriteLine("This is the second line");
            //         goto case 8;
            //     case 2:
            //         Console.WriteLine("It's the second case.");
            //         break;
            //     case 7:
            //         Console.WriteLine("Its value is 7");
            //         break;
            //     case 9:
            //     case 8:
            //         Console.WriteLine("Case 8 has been executed.");
            //         break;
            //     case 10:
            //         Console.WriteLine("Its value is 10");
            //         break;
            //     case 11:
            //         Console.WriteLine("Condition with a label");
            //         numericCondition =1;
            //         goto MyLabel;                
            //     default:
            //         Console.WriteLine("Writing up the default line, the value is not a special value");
            //         goto case 9;
            // }

            // Switch statement with using patter matching
            Object myObject = null;
            myObject = "my original string";
            myObject = new StringBuilder ("my original string");

            // switch(myObject)
            // {
            //     case String myString:
            //         Console.WriteLine($"myObject is a string with the value: {myString}");
            //         break;
            //     case StringBuilder myBuilder:
            //         Console.WriteLine("myObject is a StringBuilder");
            //         break;
            //     default:
            //         Console.WriteLine("myObject is an Object, I don't know what type of");
            //         break;
            //     case null:
            //         Console.WriteLine("myObject is null");
            //         break;
            // }


            /// simplified switch syntax
            string message;

            message = myObject switch
            {
                String myString => $"myObject is a string with the value: {myString}",

                StringBuilder => "myObject is a StringBuilder",

                null => "myObject is null",
                
                _ => "myObject is an Object, I don't know what type of"
            };

            Console.WriteLine(message);
        }
    }
}
