using System;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Thinktecture.Extensions.Logging.Abstractions.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			var serilog = new LoggerConfiguration()
				.WriteTo.Console()
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
}
