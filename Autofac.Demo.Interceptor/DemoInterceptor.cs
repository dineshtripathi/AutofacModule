﻿using System.Linq;

namespace Autofac.Demo.Interceptor
{
    using System.IO;
    using Castle.DynamicProxy;

    public class LogInterceptor : IInterceptor
    {
        private readonly TextWriter _output;

        public static string name = "MyLogInterceptor";
        public LogInterceptor(TextWriter output)
        {
            _output = output;
        }

        #region IInterceptor Members

        //The interceptor will log the beginning and end of the method call.
        public void Intercept(IInvocation invocation)
        {
            //This happens before the method call
            _output.WriteLine("Calling method {0} with parameters {1}... ",
                invocation.Method.Name,
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            //Actual method call begins
            invocation.Proceed();

            //This happens after a method call
            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }

        #endregion
    }
}
