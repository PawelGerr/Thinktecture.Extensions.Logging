using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Thinktecture.Extensions.ILoggerExtensionsTests
{
	public class LogInformation : LoggerExtensionsTestBase
	{
		public LogInformation()
			: base(LogLevel.Information)
		{
		}

		[Fact]
		public void Should_throw_argnullexception_if_logger_is_null()
		{
			Action action = () => ILoggerExtensions.LogInformation(null, $"");
			action.Should().Throw<ArgumentNullException>();
		}

		[Fact]
		public void Should_throw_argnullexception_if_message_is_null()
		{
			Action action = () => ILoggerExtensions.LogInformation(LoggerMock.Object, null);
			action.Should().Throw<ArgumentNullException>();
		}

		[Fact]
		public void Should_call_log_with_message_only()
		{
			Setup("message");

			ILoggerExtensions.LogInformation(LoggerMock.Object, $"message");
			LoggerMock.VerifyAll();
		}

		[Fact]
		public void Should_call_log_with_message_and_arguments()
		{
			var a = "text";
			var b = 42;
			Setup("message: {0}, {1}", a, b);

			ILoggerExtensions.LogInformation(LoggerMock.Object, $"message: {a}, {b}");
			LoggerMock.VerifyAll();
		}

		[Fact]
		public void Should_call_log_with_correct_eventId()
		{
			EventId eventId = 2;
			Setup(eventId, "message");

			ILoggerExtensions.LogInformation(LoggerMock.Object, eventId, $"message");
			LoggerMock.VerifyAll();
		}

		[Fact]
		public void Should_call_log_with_correct_exception()
		{
			var exception = new Exception("Text");
			Setup(exception, "message");

			ILoggerExtensions.LogInformation(LoggerMock.Object, exception, $"message");
			LoggerMock.VerifyAll();
		}
	}
}
