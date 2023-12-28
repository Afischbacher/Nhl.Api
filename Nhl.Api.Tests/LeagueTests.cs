using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Nhl.Api.Tests;

[TestClass]
public class LeagueTests
{
    [TestMethod]
    public async Task Test_Get_League_Schedule_Async()
    {
        await using INhlApi nhlApi = new NhlApi();

        var schedule = await nhlApi.GetLeagueGameWeekScheduleByDateTimeAsync(DateTimeOffset.Now);

        Assert.IsNotNull(schedule);

    }
}
