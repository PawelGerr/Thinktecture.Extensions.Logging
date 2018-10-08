using System;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Thinktecture.Extensions.Logging.Abstractions.Example
{
   class Program
   {
      static void Main(string[] args)
      {
         var serilog = new LoggerConfiguration()
                       .WriteTo.Console()
                       .WriteTo.Sink(new MySink())
                       .CreateLogger();
         var logger = new LoggerFactory()
                      .AddSerilog(serilog)
                      .CreateLogger<Program>();

         var a = "text";
         var b = 42;
         logger.LogInformation((string)$"Using standard extension method: a = {a}, b = {b}");
         logger.LogInformation($"Using new extension method: a = {a}, b = {b}");

         Console.WriteLine("Press ENTER to exit.");
         Console.ReadLine();
      }
   }

   internal class MySink : ILogEventSink
   {
      public void Emit(LogEvent logEvent)
      {
         Console.WriteLine();
         Console.WriteLine($"Template: {logEvent.MessageTemplate.Text}");
         Console.WriteLine("Properties:");

         foreach (var kvp in logEvent.Properties)
         {
            // Issue: formattable string does not capture the names of the placeholders
            // https://github.com/dotnet/roslyn/issues/142
            Console.WriteLine($"\t{kvp.Key} = {kvp.Value}");
         }
      }
   }
}
