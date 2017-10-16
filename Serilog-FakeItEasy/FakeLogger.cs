using FakeItEasy;
using Serilog;
using Serilog.Events;
using System;
using System.Linq.Expressions;

namespace Sentinel.Web.Tests
{
    public static class FakeLogger
    {
        private static ILogger logger;

        private static void SetLogger()
        {
            if (logger != null) return;

            logger = A.Fake<ILogger>();
            Log.Logger = logger;
        }

        public static Expression<Action> Information(string messageTemplate, params  object[] propertyValue)
        {
            return Write(LogEventLevel.Information, messageTemplate, propertyValue);
        }

        public static Expression<Action> Information(string message)
        {
            return Write(LogEventLevel.Information, message);
        }

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

        public static Expression<Action> Fatal(string message, params object[] propertyValues)
        {
            return Write(LogEventLevel.Fatal, message, propertyValues);
        }

        public static Expression<Action> Fatal(string message)
        {
            return Write(LogEventLevel.Fatal, message);
        }

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

        private static Expression<Action> Write(LogEventLevel logEventLevel, Exception ex, string messageTemplate, string propertyValue)
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

    }
}
