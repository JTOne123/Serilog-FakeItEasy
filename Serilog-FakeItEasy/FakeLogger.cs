using FakeItEasy;
using Serilog;
using Serilog.Events;
using System;
using System.Linq.Expressions;

namespace SerilogFakeItEasy
{
    /// <summary>
    /// This class was created to compensate for some tribal knowledge. When testing with FakeItEasy and wanting to make sure
    /// logging was called with the appropriate messages given the logic we noticed the mocking/faking becomes very different
    /// whether you use Log.Information vs Log.Logger.Information.
    ///
    /// If your team deviates from Log.Information standard and uses Log.Logger.Information you need to Fake different methods.
    /// This information is only known if you go to the source on GitHub.
    /// 
    /// Log.Information requires you to Fake method(s) called .Write(). Whereas Log.Logger.Information requires to Fake Method(s) .Information()
    /// </summary>
    public static class FakeLogger
    {
        private static ILogger logger;

        /// <summary>
        /// Clear the Fake Setup. Call in your test cleanup methods.
        /// </summary>
        public static void Clear()
        {
            Fake.ClearConfiguration(logger);
        }

        #region Information Messages

        public static Expression<Action> Information(string messageTemplate, object propertyValue)
        {
            return Write(LogEventLevel.Information, messageTemplate, propertyValue);
        }

        public static Expression<Action> Information(string messageTemplate, params object[] propertyValue)
        {
            return Write(LogEventLevel.Information, messageTemplate, propertyValue);
        }

        public static Expression<Action> Information(string message)
        {
            return Write(LogEventLevel.Information, message);
        }

        #endregion

        #region Error Messages

        public static Expression<Action> Error(string message, Exception ex)
        {
            return Write(LogEventLevel.Error, ex, message);
        }

        public static Expression<Action> Error(string message)
        {
            return Write(LogEventLevel.Error, message);
        }

        public static Expression<Action> Error(string message, Exception ex, params object[] propertyValues)
        {
            return Write(LogEventLevel.Error, ex, message, propertyValues);
        }

        public static Expression<Action> Error(string message, Exception ex, object propertyValue)
        {
            return Write(LogEventLevel.Error, ex, message, propertyValue);
        }
        
        public static Expression<Action> Error(string message, params object[] propertyValues)
        {
            return Write(LogEventLevel.Error, message, propertyValues);
        }

        public static Expression<Action> Error(string message, object propertyValue)
        {
            return Write(LogEventLevel.Error, message, propertyValue);
        }

        #endregion

        #region Fatal Messages

        public static Expression<Action> Fatal(string message, object propertyValue)
        {
            return Write(LogEventLevel.Fatal, message, propertyValue);
        }

        public static Expression<Action> Fatal(string message, params object[] propertyValues)
        {
            return Write(LogEventLevel.Fatal, message, propertyValues);
        }

        public static Expression<Action> Fatal(string message)
        {
            return Write(LogEventLevel.Fatal, message);
        }

        #endregion

        #region Warning Messages

        public static Expression<Action> Warning(string message, Exception ex)
        {
            return Write(LogEventLevel.Warning, ex, message);
        }

        public static Expression<Action> Warning(string message)
        {
            return Write(LogEventLevel.Warning, message);
        }

        public static Expression<Action> Warning(string message, Exception ex, params object[] propertyValues)
        {
            return Write(LogEventLevel.Warning, ex, message, propertyValues);
        }

        public static Expression<Action> Warning(string message, Exception ex, object propertyValue)
        {
            return Write(LogEventLevel.Warning, ex, message, propertyValue);
        }

        public static Expression<Action> Warning(string message, params object[] propertyValues)
        {
            return Write(LogEventLevel.Warning, message, propertyValues);
        }

        public static Expression<Action> Warning(string message, object propertyValue)
        {
            return Write(LogEventLevel.Warning, message, propertyValue);
        }

        #endregion Warning Messages

        #region Helper Methods

        #region Write Messages
        private static Expression<Action> Write(LogEventLevel logEventLevel, string messageTemplate, params object[] propertyValues)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEventLevel, messageTemplate, propertyValues);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        private static Expression<Action> Write(LogEventLevel logEventLevel, string messageTemplate)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEventLevel, messageTemplate);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        private static Expression<Action> Write(LogEventLevel logEventLevel, string messageTemplate, object propertyValue)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEventLevel, messageTemplate, propertyValue);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        private static Expression<Action> Write(LogEventLevel logEventLevel, Exception ex, string messageTemplate, object propertyValue)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEventLevel, ex, messageTemplate, propertyValue);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        private static Expression<Action> Write(LogEventLevel logEventLevel, Exception ex, string messageTemplate, params object[] propertyValues)
        {
            SetLogger();
            Expression<Action> logExpression = () => logger.Write(logEventLevel, ex, messageTemplate, propertyValues);
            A.CallTo(logExpression).DoesNothing();

            return logExpression;
        }

        #endregion

        private static void SetLogger()
        {
            if (logger != null) { return; }

            logger = A.Fake<ILogger>();
            Log.Logger = logger;
        }

        #endregion Helper Methods
    }
}
