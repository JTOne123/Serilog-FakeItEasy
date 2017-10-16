using System;
using System.Linq.Expressions;
using Serilog.Events;

namespace SerilogFakeItEasy
{
    internal class DebugToLogger : IFakeLogWriter
    {

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <example>
        /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
        /// </example>
        public Expression<Action> Write(string messageTemplate)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, messageTemplate);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
        /// </example>
        public Expression<Action> Write<T>(string messageTemplate, T propertyValue)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, messageTemplate, propertyValue);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
        /// </example>
        public Expression<Action> Write<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, messageTemplate, propertyValue0, propertyValue1);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
        /// </example>
        public Expression<Action> Write<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
        /// <example>
        /// Log.Debug("Starting up at {StartedAt}.", DateTime.Now);
        /// </example>
        public Expression<Action> Write(string messageTemplate, params object[] propertyValues)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, messageTemplate, propertyValues);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <example>Log.Debug(ex, "Swallowing a mundane exception.");</example>
        public Expression<Action> Write(Exception exception, string messageTemplate)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, exception, messageTemplate);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        /// <example>Log.Debug(ex, "Swallowing a mundane exception.");</example>
        public Expression<Action> Write<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <example>Log.Debug(ex, "Swallowing a mundane exception.");</example>
        public Expression<Action> Write<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue0, propertyValue1);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        /// <example>Log.Debug(ex, "Swallowing a mundane exception.");</example>
        public Expression<Action> Write<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
            T2 propertyValue2)
        {
            return WriterToLogger.Write(LogEventLevel.Debug, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }


        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Debug" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
        /// <example>Log.Debug(ex, "Swallowing a mundane exception.");</example>
        public Expression<Action> Write(Exception exception, string messageTemplate, params object[] propertyValues)
        {
           return WriterToLogger.Write(LogEventLevel.Debug, exception, messageTemplate, propertyValues);
        }

    }
}