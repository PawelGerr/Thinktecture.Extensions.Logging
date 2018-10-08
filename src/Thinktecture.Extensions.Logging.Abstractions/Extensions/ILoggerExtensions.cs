using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

// ReSharper disable once CheckNamespace
namespace Thinktecture
{
	/// <summary>
	/// Extension methods for <see cref="ILogger"/>
	/// </summary>
	// ReSharper disable once InconsistentNaming
	public static class ILoggerExtensions
	{
		/// <summary>Formats and writes a trace log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogTrace([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogTrace(null, message);
		}

		/// <summary>Formats and writes a trace log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogTrace([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogTrace(0, exception, message);
		}

		/// <summary>Formats and writes a trace log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogTrace([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogTrace(eventId, null, message);
		}

		/// <summary>Formats and writes a trace log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogTrace([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogTrace(eventId, exception, message.Format, message.GetArguments());
		}

		/// <summary>Formats and writes a debug log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogDebug([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogDebug(null, message);
		}

		/// <summary>Formats and writes a debug log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogDebug([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogDebug(0, exception, message);
		}

		/// <summary>Formats and writes a debug log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogDebug([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogDebug(eventId, null, message);
		}

		/// <summary>Formats and writes a debug log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogDebug([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogDebug(eventId, exception, message.Format, message.GetArguments());
		}

		/// <summary>Formats and writes an informational log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogInformation([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogInformation(null, message);
		}

		/// <summary>Formats and writes an informational log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogInformation([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogInformation(0, exception, message);
		}

		/// <summary>Formats and writes an informational log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogInformation([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogInformation(eventId, null, message);
		}

		/// <summary>Formats and writes an informational log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogInformation([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogInformation(eventId, exception, message.Format, message.GetArguments());
		}

		/// <summary>Formats and writes a warning log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogWarning([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogWarning(null, message);
		}

		/// <summary>Formats and writes a warning log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogWarning([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogWarning(0, exception, message);
		}

		/// <summary>Formats and writes a warning log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogWarning([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogWarning(eventId, null, message);
		}

		/// <summary>Formats and writes a warning log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogWarning([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogWarning(eventId, exception, message.Format, message.GetArguments());
		}

		/// <summary>Formats and writes an error log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogError([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogError(null, message);
		}

		/// <summary>Formats and writes an error log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogError([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogError(0, exception, message);
		}

		/// <summary>Formats and writes an error log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogError([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogError(eventId, null, message);
		}

		/// <summary>Formats and writes an error log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogError([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogError(eventId, exception, message.Format, message.GetArguments());
		}

		/// <summary>Formats and writes a critical log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogCritical([NotNull] this ILogger logger, [NotNull] FormattableString message)
		{
			logger.LogCritical(null, message);
		}

		/// <summary>Formats and writes a critical log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogCritical([NotNull] this ILogger logger, Exception exception, [NotNull] FormattableString message)
		{
			logger.LogCritical(0, exception, message);
		}

		/// <summary>Formats and writes a critical log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogCritical([NotNull] this ILogger logger, EventId eventId, [NotNull] FormattableString message)
		{
			logger.LogCritical(eventId, null, message);
		}

		/// <summary>Formats and writes a critical log message.</summary>
		/// <param name="logger">The <see cref="ILogger" /> to write to.</param>
		/// <param name="eventId">The event id associated with the log.</param>
		/// <param name="exception">The exception to log.</param>
		/// <param name="message">Formattable string of the log message.</param>
		/// <exception cref="ArgumentNullException">If <paramref name="logger"/> or <paramref name="message"/> is null.</exception>
		public static void LogCritical([NotNull] this ILogger logger, EventId eventId, Exception exception, [NotNull] FormattableString message)
		{
			if (logger == null)
				throw new ArgumentNullException(nameof(logger));
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			logger.LogCritical(eventId, exception, message.Format, message.GetArguments());
		}
	}
}
