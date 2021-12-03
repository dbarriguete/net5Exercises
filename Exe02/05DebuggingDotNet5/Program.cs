using System;

namespace _05DebuggingDotNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I calculate the Yearly amount if you have the monthly amount.");
            Console.Write ("What is the monthly amount? ");
            // string input = Console.ReadLine();

            string input = "2.1";
            decimal monthlyAmount=0;
            if (decimal.TryParse(input, out monthlyAmount ))
            {
                if(monthlyAmount<=0)
                {
                    Console.WriteLine("The number is invalid, only use a number greater than 0.");
                }
                else
                {
                    Console.WriteLine($"The yearly amount of {monthlyAmount:C} is: {GetYearlyAmount(monthlyAmount):C}");
                }
            }
            else 
            {
                Console.WriteLine("The information provided is not a decimal, only provide decimal values greater than 0.");
            }
        }


        static decimal GetYearlyAmount (decimal monthlyAmount)
        {
            return (monthlyAmount*12);
        }
    }
}
