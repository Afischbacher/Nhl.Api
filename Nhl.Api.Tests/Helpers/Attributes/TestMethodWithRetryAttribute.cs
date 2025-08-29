using System.Linq;
using System.Threading;

namespace Nhl.Api.Tests.Helpers.Attributes;
/// <summary>
/// An Microsoft Test custom attribute for retrying on failed test methods
/// </summary>
public class TestMethodWithRetryAttribute : TestMethodAttribute, IDisposable
{

    /// <summary>
    /// A property to set for the number of retries a test method should attempt to re-test the function method
    /// </summary>
    public int RetryCount { get; set; } = 1;

    /// <summary>
    /// A delay time between each test execution retry attempt
    /// </summary>
    public int RetryDelayInSeconds { get; set; } = 1;

    /// <summary>
    /// The backoff coefficient to apply to the retry delay
    /// </summary>
    public decimal BackoffCoefficent { get; set; } = 1.0m;

    private static readonly SemaphoreSlim _semaphoreSlim = new(1, 1);

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        _semaphoreSlim.Wait();

        var count = this.RetryCount;
        var backOffDelay = this.RetryDelayInSeconds;
        var backOffWithCoefficient = (int)(backOffDelay * this.BackoffCoefficent);
        const int oneThousandMilliseconds = 1000;

        TestResult[] result = null;
        while (count > 0)
        {
            try
            {
                if (this.BackoffCoefficent > 1.0m)
                {
                    backOffWithCoefficient = (int)(backOffDelay * this.BackoffCoefficent);
                    this.BackoffCoefficent *= this.BackoffCoefficent;
                    Thread.Sleep(backOffWithCoefficient * oneThousandMilliseconds);
                }
                else
                {

                }
                {
                    Thread.Sleep(backOffDelay * oneThousandMilliseconds);
                }

                result = base.Execute(testMethod);

                if (result.Any(r => r.TestFailureException != null))
                {
                    throw result.First(r => r.TestFailureException != null).TestFailureException;
                }
                else
                {
                    break;
                }
            }
            catch (Exception) when (count > 0)
            {
            }
            finally
            {
                _semaphoreSlim.Release();
                count--;
            }
        }

        return result;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _semaphoreSlim.Dispose();
    }
}

