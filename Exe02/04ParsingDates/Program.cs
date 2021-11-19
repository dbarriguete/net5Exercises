using System;
using System.Globalization;

namespace _04ParsingDates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Documentation on internet: 
            // DateTime.Parse examples
            // https://docs.microsoft.com/en-us/samples/dotnet/samples/datetime-parse/

            string dateFormatOther = "2021/02/13 12:15:12";

            // Date is: February 12nd 2008 // 13th
            string dateFormatUS = "2/13/2021 12:15:12 PM";
            
            // Date is: December 2nd // 13th
            string dateFormatMX = "13/12/2021 19:25:00";

            // Date is: December 2nd // 13th
            string dateFormatFR = "13/12/2021";

            Console.WriteLine("Parsing different strings to DateTime");
            try
            {
                DateTime dateConverted = DateTime.Parse(dateFormatOther);
                Console.WriteLine($"Original string: {dateFormatOther}, converted date: {dateConverted}");
                
                dateConverted = DateTime.Parse(dateFormatUS);
                Console.WriteLine($"Original string: {dateFormatUS}, converted date: {dateConverted}");

                dateConverted = DateTime.Parse(dateFormatMX);
                Console.WriteLine($"Original string: {dateFormatMX}, converted date: {dateConverted}");

                dateConverted = DateTime.Parse(dateFormatFR);
                Console.WriteLine($"Original string: {dateFormatFR}, converted date: {dateConverted}");
            }
            catch(Exception fault)
            {
                Console.WriteLine($"There was an error when executing the application: {fault.Message} ");
                Console.WriteLine($"More details: {fault.StackTrace}");
            }


            // documentation about cultures:
            // https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-5.0
            // Reference to get all cultures: 
            // http://www.codedigest.com/CodeDigest/207-Get-All-Language-Country-Code-List-for-all-Culture-in-C---ASP-Net.aspx

            try
            {
                DateTime dateConverted;
                CultureInfo[] cultures = {
                    CultureInfo.CreateSpecificCulture("en-US"), //UnitedStates
                    CultureInfo.CreateSpecificCulture("fr-FR"), //France
                    CultureInfo.CreateSpecificCulture("de-DE"), //Germany or Deutschland
                    CultureInfo.CreateSpecificCulture("es-MX"), //Mexico
                    CultureInfo.CreateSpecificCulture("es-ES"), //Spain
                };

                string[] dateStrings = {
                    dateFormatOther,
                    dateFormatUS,
                    dateFormatFR,
                    dateFormatMX
                };

Console.WriteLine("**************************************");
Console.WriteLine("**************************************");
Console.WriteLine("**************************************");
Console.WriteLine("");

                foreach (var culture in cultures)
                {
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"Date parsing using the culture configuration: {culture.DisplayName} {culture.Name}");
                    foreach (var stringToConvert in dateStrings)
                    {
                        try
                        {
                        dateConverted = DateTime.Parse(stringToConvert, culture);
                        Console.WriteLine($"Original string: {stringToConvert}, converted date: {dateConverted} ");
                        }
                        catch(Exception otherFault)
                        {
                            Console.WriteLine($"Unable to convert: {stringToConvert}, using culture: {culture}");
                            Console.WriteLine($"{otherFault.Message}");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            catch(Exception fault)
            {
                Console.WriteLine($"There was an error when executing the application: {fault.Message} ");
                Console.WriteLine($"More details: {fault.StackTrace}");
            }

        }
    }
}
