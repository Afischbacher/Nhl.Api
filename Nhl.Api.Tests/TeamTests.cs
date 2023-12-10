using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Team;
using Nhl.Api.Tests.Helpers.Attributes;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class TeamTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamColorsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamColor = await nhlApi.GetTeamColorsAsync(10);

            // Assert
            Assert.IsNotNull(teamColor);
            Assert.IsNotNull(teamColor.PrimaryColor);
            Assert.IsNotNull(teamColor.SecondaryColor);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamColorsInvalidTeamIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamColor = await nhlApi.GetTeamColorsAsync(99);

            // Assert
            Assert.IsNull(teamColor);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamColorsEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamColor = await nhlApi.GetTeamColorsAsync(TeamEnum.ChicagoBlackhawks);

            // Assert
            Assert.IsNotNull(teamColor);
            Assert.IsNotNull(teamColor.PrimaryColor);
            Assert.IsNotNull(teamColor.SecondaryColor);
            Assert.IsNotNull(teamColor.TertiaryColor);
            Assert.IsNotNull(teamColor.QuinaryColor);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetAllTeamColorsEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teams = Enum.GetValues(typeof(TeamEnum)).Cast<TeamEnum>();
            foreach (var team in teams)
            {
                var teamColor = await nhlApi.GetTeamColorsAsync(team);
                // Assert
                Assert.IsNotNull(teamColor);
                Assert.IsNotNull(teamColor.PrimaryColor);
                Assert.IsNotNull(teamColor.SecondaryColor);
            }

        }

        [DataRow(TeamEnum.TorontoMapleLeafs)]
        [DataRow(TeamEnum.ArizonaCoyotes)]
        [DataRow(TeamEnum.DetroitRedWings)]
        [DataRow(TeamEnum.AnaheimDucks)]
        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamLogoLightAsync(TeamEnum teamEnum)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Light);

            // Assert
            Assert.IsNotNull(teamLogo);
            Assert.IsNotNull(teamLogo.Uri);
            Assert.IsNotNull(teamLogo.ImageAsByteArray);
            Assert.IsNotNull(teamLogo.ImageAsBase64String);

            Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 1000);
            Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 100);
        }


        [DataRow(TeamEnum.ColoradoAvalanche)]
        [DataRow(TeamEnum.SanJoseSharks)]
        [DataRow(TeamEnum.ColumbusBlueJackets)]
        [DataRow(TeamEnum.ChicagoBlackhawks)]
        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamLogoDarkAsync(TeamEnum teamEnum)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Dark);

            // Assert
            Assert.IsNotNull(teamLogo);
            Assert.IsNotNull(teamLogo.Uri);
            Assert.IsNotNull(teamLogo.ImageAsByteArray);
            Assert.IsNotNull(teamLogo.ImageAsBase64String);

            Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 1000);
            Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 100);
        }

        [DataRow(10)]
        [DataRow(55)]
        [DataRow(7)]
        [DataRow(24)]
        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamLogoLightAsIntAsync(int teamId)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamLogo = await nhlApi.GetTeamLogoAsync(teamId, TeamLogoType.Light);

            // Assert
            Assert.IsNotNull(teamLogo);
            Assert.IsNotNull(teamLogo.Uri);
            Assert.IsNotNull(teamLogo.ImageAsByteArray);
            Assert.IsNotNull(teamLogo.ImageAsBase64String);

            Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
            Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
        }


        [DataRow(21)]
        [DataRow(28)]
        [DataRow(6)]
        [DataRow(5)]
        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamLogoDarkAsIntAsync(int teamId)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamLogo = await nhlApi.GetTeamLogoAsync(teamId, TeamLogoType.Dark);

            // Assert
            Assert.IsNotNull(teamLogo);
            Assert.IsNotNull(teamLogo.Uri);
            Assert.IsNotNull(teamLogo.ImageAsByteArray);
            Assert.IsNotNull(teamLogo.ImageAsBase64String);

            Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
            Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
        }
    }
}
