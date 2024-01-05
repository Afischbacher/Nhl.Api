using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api.Common.Services;

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

    /// <summary>
    /// A for each iterator that executes with a degree of parallelism for asynchronous function bodies
    /// </summary>
    /// <typeparam name="T">The generic type</typeparam>
    /// <param name="source">The source of the iteration</param>
    /// <param name="degreeOfParallelism">The limited number of parallel tasks executing simultaneously</param>
    /// <param name="body">The body of the for-each asynchronous iterator</param>
    public static async Task ForEachAsync<T>(IEnumerable<T> source, int degreeOfParallelism, Func<T, Task> body)
    {
        using (var semaphore = new SemaphoreSlim(initialCount: degreeOfParallelism, maxCount: degreeOfParallelism))
        {
            var tasks = source.Select(async item =>
            {
                await semaphore.WaitAsync();
                try
                {
                    await body(item);
                }
                finally
                {
                    semaphore.Release();
                }
            });
            await Task.WhenAll(tasks);
        }
    }
}
