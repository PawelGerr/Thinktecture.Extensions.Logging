using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Internal;
using Moq;

namespace Thinktecture.Extensions.ILoggerExtensionsTests
{
	public abstract class LoggerExtensionsTestBase
	{
		protected readonly Mock<ILogger> LoggerMock;
		protected readonly LogLevel ExpectedLogLevel;

		protected LoggerExtensionsTestBase(LogLevel expectedLogLevel)
		{
			ExpectedLogLevel = expectedLogLevel;
			LoggerMock = new Mock<ILogger>(MockBehavior.Strict);
		}

		protected void Setup(string message, params object[] parameters)
		{
			Setup(0, message, parameters);
		}

		protected void Setup(EventId eventId, string message, params object[] parameters)
		{
			Setup(eventId, null, message, parameters);
		}

		protected void Setup(Exception exception, string message, params object[] parameters)
		{
			Setup(0, exception, message, parameters);
		}

		protected void Setup(EventId eventId, Exception exception, string message, params object[] parameters)
		{
			LoggerMock.Setup(l => l.Log(ExpectedLogLevel, eventId, It.IsAny<object>(), exception, It.IsAny<Func<object, Exception, string>>()))
					.Callback<LogLevel, EventId, object, Exception, Func<object, Exception, string>>((level, id, state, ex, formatter) =>
					{
						id.Should().Be(eventId);
						ex.Should().Be(exception);

						state.Should().BeOfType<FormattedLogValues>();
						var values = (FormattedLogValues)state;
						values.Count.Should().Be(parameters.Length + 1);
						values[parameters.Length].Should().Be(new KeyValuePair<string, object>("{OriginalFormat}", message));
					});
		}
	}
}
