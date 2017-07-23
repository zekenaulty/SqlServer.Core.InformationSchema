using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SqlServer.Core.InformationSchema.Test
{
    class SqlLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            if (categoryName == typeof(Microsoft.EntityFrameworkCore.Storage.IRelationalCommandBuilderFactory).FullName)
            {
                return new SqlLogger(categoryName);
            }

            return new NullLogger();
        }

        public void Dispose()
        { }

        private class SqlLogger : ILogger
        {
            private string _test;

            public SqlLogger(string test)
            {
                _test = test;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                if (eventId.Id == (int)RelationalEventId.ExecutedCommand)
                {
                    var data = state as IEnumerable<KeyValuePair<string, object>>;
                    if (data != null)
                    {
                        var commandText = data.Single(p => p.Key == "CommandText").Value;
                        Console.WriteLine(commandText);
                        Console.WriteLine("The above command will be executed. Press enter to continue.");
                        Console.ReadLine();
                    }
                }
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
        }

        private class NullLogger : ILogger
        {
            public bool IsEnabled(LogLevel logLevel)
            {
                return false;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            { }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
        }
    }
}
