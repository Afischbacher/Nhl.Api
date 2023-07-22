using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Player;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class PlayerEnumHelperTests
    {
        [TestMethod]
        public void GetAllPlayersTest()
        {
            var players = PlayerEnumHelper.GetAllPlayers();
            Assert.IsNotNull(players);
            Assert.IsTrue(players.Count > 20000);
        }
    }
}
