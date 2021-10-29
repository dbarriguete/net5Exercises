using System;

namespace _01Methods
{
    class Program
    {
        static string _Input;

        static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage( DateTime.Now.Hour));

            while(GettingAValidCommand())
            {
                switch (_Input)
                {
                    case "time":
                        WhatTimeIsIt();
                        break;
                    case "date":
                        WhatDateIsIt();
                        break;
                    default:
                        Console.WriteLine("The command is unknown.");
                        break;
                }
            }

            Console.WriteLine("Thanks for using this application.");
            Console.WriteLine("Don't miss next examples at: twitch.tv/D1366er");
        }

        static string WelcomeMessage( int hour )
        {
            string greeting="";
            if(hour <= 5)
            {
                greeting = "Hello, ";
            }
            else if(hour > 5 && hour < 12)
            {
                greeting ="Good morning, ";
            }
            else if (hour >=12 && hour <=20)
            {
                greeting = "Good afternoon, ";
            }
            else if (hour <20)
            {
                greeting = "Hello there, ";
            }

            string result = greeting + "what I could do for you?\r\nYou may write up a command from the following list.\r\ntime - WhatTimeIsIt method\r\ndate - WhatDateIsIt method";

            return result;
        }

        static void WhatTimeIsIt()
        {
            DateTime now = DateTime.Now;
            //DateTime now =new DateTime(2021,10,29, 17,23,15);
            Console.WriteLine($"Hello there!\r\nRight now the time is: {now.ToString("HH:mm:ss")} hrs or {now.ToString("hh:mm:ss tt")}" );
        } 

        static void WhatDateIsIt()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Hello there!\r\nToday is {now.ToString("MMMM dd yy")}");
        }

        static bool GettingAValidCommand()
        { 
            _Input = Console.ReadLine();
            
            return !_Input.Equals("exit");
        }

        
    }
}
