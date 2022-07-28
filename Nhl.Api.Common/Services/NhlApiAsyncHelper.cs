using System;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Services
{
    /// <summary>
    /// An asynchronous helper for running asynchronous code in synchronous environments
    /// </summary>
    public static class NhlApiAsyncHelper
    {
        private static readonly TaskFactory _myTaskFactory = new
          TaskFactory(CancellationToken.None,
                      TaskCreationOptions.None,
                      TaskContinuationOptions.None,
                      TaskScheduler.Default);

        /// <summary>
        /// Takes a asynchronous Task based function and runs it asynchronously and returns the result
        /// </summary>
        /// <typeparam name="TResult">The type of the task result</typeparam>
        /// <param name="func">The task that is to be ran in a synchronous manner</param>
        /// <returns>The task result</returns>
        public static TResult RunSync<TResult>(Func<Task<TResult>> func)
        {
            return NhlApiAsyncHelper._myTaskFactory
              .StartNew<Task<TResult>>(func)
              .Unwrap<TResult>()
              .GetAwaiter()
              .GetResult();
        }

        /// <summary>
        /// Takes a asynchronous Task based function and runs it asynchronously in a void manner
        /// </summary>
        /// <param name="func">The task that is to be ran in a synchronous manner</param>
        public static void RunSync(Func<Task> func)
        {
            NhlApiAsyncHelper._myTaskFactory
              .StartNew<Task>(func)
              .Unwrap()
              .GetAwaiter()
              .GetResult();
        }
    }
}
