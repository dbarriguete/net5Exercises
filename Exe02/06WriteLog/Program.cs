using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace _06WriteLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remember to search nuggets packages at: https://www.nuget.org/
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            TraceSwitch tswitch = new TraceSwitch(displayName: "MyLogger", description: "an example of trace configuratin with JSON appsettings file.");
            configuration.GetSection("TraceLevelConfig").Bind(tswitch);

            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("logNET.txt")));
            Trace.AutoFlush = true;

            Debug.WriteLine($"Hello I'm the debugger, I'm ready to write a log. {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
            Trace.WriteLine($"Hello I'm the tracer, I'm ready to write a log. {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");

            // Values for Level at appsettings:
            // Error
            // Warning
            // Info
            // Verbose
            // Depending on that configuration is the type of messages that are going to be saved at the logNET.txt file

            Trace.WriteLineIf(tswitch.TraceError, "This is a trace error");
            Trace.WriteLineIf(tswitch.TraceWarning, "This is a trace warning");
            Trace.WriteLineIf(tswitch.TraceInfo, "This is a trace info");
            Trace.WriteLineIf(tswitch.TraceVerbose, "This is a trace verbose");
        }
    }
}
