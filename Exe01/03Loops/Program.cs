using System;

namespace _03Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=10;

            // //WHILE loop example
            // while(counter < 5)
            // {
            //     Console.WriteLine($"Value right now = {counter} ");
            //     counter = counter+1;
            // }

            // Console.WriteLine("The WHILE loop has ended.");


            // counter = 10;
            // //DO WHILE loop example
            // do
            // {
            //     Console.WriteLine($"Value right now = {counter}");
            //     counter = counter +1;
            // } while (counter<5);

            //  Console.WriteLine("The DO WHILE loop has ended.");


            //FOR loop example
            //int i=1;
            for( int i = 10 ; i > 5; i-- )
            {
                Console.WriteLine($"Value right now: {i}");
            }

            string[] myArrayWithValues = new string[7];
            myArrayWithValues[0]= "The first value at position 0";
            myArrayWithValues[1]= "The value at position 1";
            myArrayWithValues[2]= "The value at position 2";
            myArrayWithValues[3]= "The value at position 3";
            myArrayWithValues[4]= "The value at position 4";
            myArrayWithValues[5]= "The value at position 5";
            myArrayWithValues[6]= "The value at position 6";

            for(int i =0; i< myArrayWithValues.Length; i++)
            {
                Console.WriteLine($"Value found at {i} : {myArrayWithValues[i]}");
            }

            Console.WriteLine("The FOR loop has ended.");

            //FOR EACH loop example
            foreach(string item in myArrayWithValues )
            {
                Console.WriteLine($"Value found: {item}");
            }

            foreach (var item in myArrayWithValues)
            {
                Console.WriteLine($"Value found with var: {item}");
            }
            
            Console.WriteLine("The FOR EACH loop has ended.");

        }
    }
}
