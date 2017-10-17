using System;
using System.Linq.Expressions;
using Serilog.Events;

namespace SerilogFakeItEasy
{
    public class InformationToLogger : IFakeLogWriter
    {
        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <example>
        /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write(string messageTemplate)
        {
            return WriterToLogger.Write(LogEventLevel.Information, messageTemplate);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T>(string messageTemplate, T propertyValue)
        {
            return WriterToLogger.Write(LogEventLevel.Information, messageTemplate, propertyValue);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            return WriterToLogger.Write(LogEventLevel.Information, messageTemplate, propertyValue0, propertyValue1);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            return WriterToLogger.Write(LogEventLevel.Information, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information("Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write(string messageTemplate, params object[] propertyValues)
        {
            return WriterToLogger.Write(LogEventLevel.Information, messageTemplate, propertyValues);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <example>
        /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write(Exception exception, string messageTemplate)
        {
            return WriterToLogger.Write(LogEventLevel.Information, exception, messageTemplate);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            return WriterToLogger.Write(LogEventLevel.Information, exception, messageTemplate, propertyValue);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            return WriterToLogger.Write(LogEventLevel.Information, exception, messageTemplate, propertyValue0, propertyValue1);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValue0">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue1">Object positionally formatted into the message template.</param>
        /// <param name="propertyValue2">Object positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1,
            T2 propertyValue2)
        {
            return WriterToLogger.Write(LogEventLevel.Information, exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        /// <summary>
        /// Write a log event with the <see cref="F:Serilog.Events.LogEventLevel.Information" /> level and associated exception.
        /// </summary>
        /// <param name="exception">Exception related to the event.</param>
        /// <param name="messageTemplate">Message template describing the event.</param>
        /// <param name="propertyValues">Objects positionally formatted into the message template.</param>
        /// <example>
        /// Log.Information(ex, "Processed {RecordCount} records in {TimeMS}.", records.Length, sw.ElapsedMilliseconds);
        /// </example>
        public Expression<Action> Write(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            return WriterToLogger.Write(LogEventLevel.Information, exception, messageTemplate, propertyValues);
        }

    }
}