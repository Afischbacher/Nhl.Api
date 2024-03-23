namespace Nhl.Api.Tests.Helpers.Attributes;
using System.Linq;
using System.Threading;

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
    public int RetryDelayInSeconds { get; set; } = 0;

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        var count = RetryCount;
        var backOffDelay = RetryDelayInSeconds;

        TestResult[] result = null;
        while (count > 0)
        {
            try
            {
                Thread.Sleep(backOffDelay * 1000);
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

