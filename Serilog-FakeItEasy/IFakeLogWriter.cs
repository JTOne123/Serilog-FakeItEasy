using System;
using System.Linq.Expressions;

namespace SerilogFakeItEasy
{
    public interface IFakeLogWriter
    {
        Expression<Action> Write(string messageTemplate);

        Expression<Action> Write<T>(string messageTemplate, T propertyValue);

        Expression<Action> Write<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);

        Expression<Action> Write<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1,
            T2 propertyValue2);

        Expression<Action> Write(string messageTemplate, params object[] propertyValues);

        Expression<Action> Write(Exception exception, string messageTemplate);

        Expression<Action> Write<T>(Exception exception, string messageTemplate, T propertyValue);

        Expression<Action> Write<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0,
            T1 propertyValue1);

        Expression<Action> Write<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0,
            T1 propertyValue1,
            T2 propertyValue2);

        Expression<Action> Write(Exception exception, string messageTemplate, params object[] propertyValues);
    }
}