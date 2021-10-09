using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Player;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class PlayerTests
	{
		[TestMethod]
		public async Task TestGetPlayerByIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			// Connor McDavid - Player Id - 8478402
			var player = await nhlApi.GetPlayerByIdAsync(8478402);

			// Assert
			Assert.IsNotNull(player);

			Assert.IsNotNull(player.Active);
			Assert.IsNotNull(player.AlternateCaptain);
			Assert.IsNotNull(player.BirthCountry);
			Assert.IsNotNull(player.BirthCity);

			Assert.IsNotNull(player.BirthDate);
			Assert.IsNotNull(player.Captain);
			Assert.IsNotNull(player.CurrentAge);
			Assert.IsNotNull(player.CurrentTeam);

			Assert.IsNotNull(player.FirstName);
			Assert.IsNotNull(player.LastName);
			Assert.IsNotNull(player.FullName);
			Assert.IsNotNull(player.Height);

			Assert.IsNotNull(player.ShootsCatches);
			Assert.IsNotNull(player.RosterStatus);
			Assert.IsNotNull(player.Weight);
			Assert.IsNotNull(player.Rookie);
			Assert.IsNotNull(player.PrimaryNumber);
			Assert.IsNotNull(player.Nationality);
			Assert.IsNotNull(player.Id);
			Assert.IsNotNull(player.Link);
			Assert.IsNotNull(player.PlayerHeadshotImageLink);

			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Small));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Medium));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Large));


		}

		[TestMethod]
		public async Task TestGetPlayerByIdEnumAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			// William Nylander - Player Id - 8477939
			var player = await nhlApi.GetPlayerByIdAsync(PlayerEnum.WilliamNylander8477939);

			// Assert
			Assert.IsNotNull(player);

			Assert.IsNotNull(player.Active);
			Assert.IsNotNull(player.AlternateCaptain);
			Assert.IsNotNull(player.BirthCountry);
			Assert.IsNotNull(player.BirthCity);

			Assert.IsNotNull(player.BirthDate);
			Assert.IsNotNull(player.Captain);
			Assert.IsNotNull(player.CurrentAge);
			Assert.IsNotNull(player.CurrentTeam);

			Assert.IsNotNull(player.FirstName);
			Assert.IsNotNull(player.LastName);
			Assert.IsNotNull(player.FullName);
			Assert.IsNotNull(player.Height);

			Assert.IsNotNull(player.ShootsCatches);
			Assert.IsNotNull(player.RosterStatus);
			Assert.IsNotNull(player.Weight);
			Assert.IsNotNull(player.Rookie);
			Assert.IsNotNull(player.PrimaryNumber);
			Assert.IsNotNull(player.Nationality);
			Assert.IsNotNull(player.Id);
			Assert.IsNotNull(player.Link);
			Assert.IsNotNull(player.PlayerHeadshotImageLink);

			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Small));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Medium));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Large));
		}

		[TestMethod]
		public async Task TestGetPlayerByInvalidIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var player = await nhlApi.GetPlayerByIdAsync(1000);

			// Assert
			Assert.IsNull(player);
		}
	}
}
