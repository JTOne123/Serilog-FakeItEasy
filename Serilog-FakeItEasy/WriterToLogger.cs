using System;
using System.Linq.Expressions;
using FakeItEasy;
using Serilog;
using Serilog.Events;

namespace SerilogFakeItEasy
{
    internal class WriterToLogger
    {
        private static ILogger logger;

        private static void SetLogger()
        {
            if (logger != null) { return; }

            logger = A.Fake<ILogger>();
            Log.Logger = logger;
        }

        public static void Clear()
        {
            if (logger == null) return;
            Fake.ClearConfiguration(logger);
            Fake.ClearRecordedCalls(logger);
        }

        /// <summary>Write an event to the log.</summary>
        /// <param name="logEvent">The event to write.</param>
        public static Expression<Action> Write(LogEvent logEvent)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEvent);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>Write a log event with the specified level.</summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static Expression<Action> Write(LogEventLevel level, string messageTemplate)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, messageTemplate);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>Write a log event with the specified level.</summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T>(LogEventLevel level, string messageTemplate, T propertyValue)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, messageTemplate, propertyValue);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>Write a log event with the specified level.</summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, messageTemplate, propertyValue0, propertyValue1);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>Write a log event with the specified level.</summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
            T2 propertyValue2)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>Write a log event with the specified level.</summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="messageTemplate"></param>
        /// <param name="propertyValues"></param>
        public static Expression<Action> Write(LogEventLevel level, string messageTemplate, params object[] propertyValues)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, messageTemplate, propertyValues);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>
        /// Write a log event with the specified level and associated exception.
        /// </summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        public static Expression<Action> Write(LogEventLevel level, Exception exception, string messageTemplate)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, exception, messageTemplate);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>
        /// Write a log event with the specified level and associated exception.
        /// </summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, exception, messageTemplate, propertyValue);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>
        /// Write a log event with the specified level and associated exception.
        /// </summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0,
            T1 propertyValue1)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, exception, messageTemplate, propertyValue0, propertyValue1);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>
        /// Write a log event with the specified level and associated exception.
        /// </summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        public static Expression<Action> Write<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0,
            T1 propertyValue1, T2 propertyValue2)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        /// <summary>
        /// Write a log event with the specified level and associated exception.
        /// </summary>
        /// <param name="level">The level of the event.</param>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
        public static Expression<Action> Write(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(level, exception, messageTemplate, propertyValues);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }
    }
}