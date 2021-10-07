using System;

namespace _05StringConverts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Converting varible types to string");

            // int integerVariable=25;
            // Console.WriteLine($"integer variable {integerVariable} as a string: '{integerVariable.ToString()}'");
            // bool booleanVariable=false;
            // Console.WriteLine($"boolean variable {booleanVariable} as a string: '{booleanVariable.ToString()}'");
            // DateTime dateTimeVariable = DateTime.Now;
            // Console.WriteLine($"date time variable {dateTimeVariable} as a string: '{dateTimeVariable.ToString()}'");
            // dateTimeVariable = DateTime.UtcNow;
            // Console.WriteLine($"UTC date time variable {dateTimeVariable} as a string: '{dateTimeVariable.ToString()}'");
            

            // object objectVariable = new object();
            // Console.WriteLine($"Object variable {objectVariable} as a string: '{objectVariable.ToString()}'");


            // byte[] byteArray = new byte[64]; // "0000 1001" max value for a Byte is 255 = "1111 1111"
            // (new Random()).NextBytes(byteArray);

            // Console.WriteLine($"Byte array: {byteArray}");
            // for(int i=0; i< byteArray.Length; i++ )
            // {
            //     Console.Write($"[{i}]: {byteArray[i].ToString()}  ");
            //     if(i>0 && i%16==0)
            //     {
            //         Console.WriteLine();
            //     }
            // }

            // Console.WriteLine("");
            // Console.WriteLine("Hex values"); 
            // for(int i=0; i< byteArray.Length; i++ )
            // {
            //     Console.Write($"[{i}]: {byteArray[i]:X}  ");
            //     if(i>0 && i%16==0)
            //     {
            //         Console.WriteLine();
            //     }
            // }
            // Console.WriteLine("");
            // string stringVariable = Convert.ToBase64String(byteArray); 
            // Console.WriteLine($"Byte array converted to Base 64: {stringVariable}");

            // stringVariable = "79";
            // integerVariable = int.Parse(stringVariable);
            // Console.WriteLine($"Parsing a string to integer: {integerVariable}");

            // stringVariable = "10 10 2021 ";
            // dateTimeVariable = DateTime.Parse(stringVariable);
            

            // Console.WriteLine($"Parsing a string to DateTime: {dateTimeVariable}");
            // Console.WriteLine($"Parsing a string to DateTime: {dateTimeVariable:D}");

            // // ////Special case for the question of timestamp
            // // // Unix timestamp is seconds past epoch
            // // System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            // // dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            // // return dtDateTime;


            // stringVariable = "seventeen";

            
            // if(int.TryParse(stringVariable, out integerVariable))
            // {
            //     Console.WriteLine($"Successful parse of a string to integer: {integerVariable}");
            // }
            // else
            // {
            //     Console.WriteLine($"The string: {stringVariable} is not a valid integer.");
            // }


            //######################################
            //######################################
            // Example of exceptions
            Console.WriteLine("I'm going to control the errors on the application");
            Console.Write("Give me an integer: ");
            string valueProvided = Console.ReadLine();

            try
            {
                int imANumber = Int32.Parse(valueProvided);
                Console.WriteLine($"Thanks for sharing the number: {imANumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The value that you provided is not a number, verify the information is correct.");
            }
            catch (OverflowException)
            {
                 Console.WriteLine($"You provided a value too large or too small, you are able to use from: {int.MinValue:N} up to {int.MaxValue:N}");
            }
            catch (Exception genericException)
            {
                Console.WriteLine("The value that you provided is wrong.");
                Console.WriteLine($"Exception catched: {genericException.GetType()}, error message is: {genericException.Message}");
            }
        }
    }
}
