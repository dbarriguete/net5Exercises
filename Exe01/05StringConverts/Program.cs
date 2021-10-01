using System;

namespace _05StringConverts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting varible types to string");

            int integerVariable=25;
            Console.WriteLine($"integer variable {integerVariable} as a string: '{integerVariable.ToString()}'");
            bool booleanVariable=false;
            Console.WriteLine($"boolean variable {booleanVariable} as a string: '{booleanVariable.ToString()}'");
            DateTime dateTimeVariable = DateTime.Now;
            Console.WriteLine($"date time variable {dateTimeVariable} as a string: '{dateTimeVariable.ToString()}'");
            dateTimeVariable = DateTime.UtcNow;
            Console.WriteLine($"UTC date time variable {dateTimeVariable} as a string: '{dateTimeVariable.ToString()}'");
            

            object objectVariable = new object();
            Console.WriteLine($"Object variable {objectVariable} as a string: '{objectVariable.ToString()}'");


            byte[] byteArray = new byte[64]; // "0000 1001" max value for a Byte is 255 = "1111 1111"
            (new Random()).NextBytes(byteArray);

            Console.WriteLine($"Byte array: {byteArray}");
            for(int i=0; i< byteArray.Length; i++ )
            {
                Console.Write($"[{i}]: {byteArray[i].ToString()}  ");
                if(i>0 && i%16==0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Hex values"); 
            for(int i=0; i< byteArray.Length; i++ )
            {
                Console.Write($"[{i}]: {byteArray[i]:X}  ");
                if(i>0 && i%16==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("");
            string stringVariable = Convert.ToBase64String(byteArray); 
            Console.WriteLine($"Byte array converted to Base 64: {stringVariable}");

            stringVariable = "79";
            integerVariable = int.Parse(stringVariable);
            Console.WriteLine($"Parsing a string to integer: {integerVariable}");

            stringVariable = "10 10 2021 ";
            dateTimeVariable = DateTime.Parse(stringVariable);
            

            Console.WriteLine($"Parsing a string to DateTime: {dateTimeVariable}");
            Console.WriteLine($"Parsing a string to DateTime: {dateTimeVariable:D}");

            // ////Special case for the question of timestamp
            // // Unix timestamp is seconds past epoch
            // System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
            // dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
            // return dtDateTime;


            stringVariable = "seventeen";

            
            if(int.TryParse(stringVariable, out integerVariable))
            {
                Console.WriteLine($"Successful parse of a string to integer: {integerVariable}");
            }
            else
            {
                Console.WriteLine($"The string: {stringVariable} is not a valid integer.");
            }
        }
    }
}
