using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api.Tests.Helpers.Attributes;

/// <summary>
/// An Microsoft Test custom attribute for retrying on failed test methods
/// </summary>
public class TestMethodWithRetryAttribute : TestMethodAttribute
{

    /// <summary>
    /// A property to set for the number of retries a test method should attempt to re-test the function method
    /// </summary>
    public int RetryCount { get; set; } = 1;

    /// <summary>
    /// A delay time between each test execution retry attempt
    /// </summary>
    public TimeSpan RetryDelay { get; set; } = TimeSpan.Zero;

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        var count = RetryCount;
        var backOffDelay = RetryDelay;

        TestResult[] result = null;
        while (count > 0)
        {
            try
            {
                Thread.Sleep(backOffDelay);
                result = base.Execute(testMethod);
                if (result.Any(r => r.TestFailureException != null))
                {
                    throw result.First(r => r.TestFailureException != null).TestFailureException;
                }
                else 
                {
                    return result;
                }
            }
            catch (Exception) when (count > 0)
            {
            }
            finally
            {
                count--;
            }
        }

        return result;
    }
}

