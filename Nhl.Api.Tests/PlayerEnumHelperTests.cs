using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Tests.Helpers.Attributes;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class PlayerEnumHelperTests
    {
        [TestMethodWithRetry(RetryCount = 5)]
        public void GetAllPlayersTest()
        {
            var players = PlayerEnumHelper.GetAllPlayers();
            Assert.IsNotNull(players);
            Assert.IsTrue(players.Count > 20000);
        }
    }
}
