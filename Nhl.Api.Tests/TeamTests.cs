using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class TeamTests
	{

		[TestMethod]
		public async Task TestGetTeamsAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var teams = await nhlApi.GetTeamsAsync();

			// Assert
			Assert.IsNotNull(teams);
			CollectionAssert.AllItemsAreNotNull(teams);

			foreach (var team in teams)
			{
				Assert.IsNotNull(team.Conference);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Active);
				Assert.IsNotNull(team.ShortName);
				Assert.IsNotNull(team.Venue);
				Assert.IsNotNull(team.FranchiseId);
				Assert.IsNotNull(team.LocationName);
				Assert.IsNotNull(team.TeamName);
				Assert.IsNotNull(team.OfficialSiteUrl);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Division);
				Assert.IsNotNull(team.Franchise);
				Assert.IsNotNull(team.Id);
				Assert.IsNotNull(team.Name);
				Assert.IsNotNull(team.Link);
				Assert.IsNotNull(team.FirstYearOfPlay);
			}
		}

		[TestMethod]
		public async Task TestGetAllActiveTeamsAsync()
		{

			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var teams = await nhlApi.GetActiveTeamsAsync();

			// Assert
			Assert.IsNotNull(teams);
			CollectionAssert.AllItemsAreNotNull(teams);

			foreach (var team in teams)
			{
				Assert.IsNotNull(team.Conference);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Active);
				Assert.IsNotNull(team.ShortName);
				Assert.IsNotNull(team.Venue);
				Assert.IsNotNull(team.FranchiseId);
				Assert.IsNotNull(team.LocationName);
				Assert.IsNotNull(team.TeamName);
				Assert.IsNotNull(team.OfficialSiteUrl);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Division);
				Assert.IsNotNull(team.Franchise);
				Assert.IsNotNull(team.Id);
				Assert.IsNotNull(team.Name);
				Assert.IsNotNull(team.Link);
				Assert.IsNotNull(team.FirstYearOfPlay);
			}
		}


		[TestMethod]
		public async Task TestGetAllInactiveTeamsAsync()
		{
			var nhlApi = new NhlApi();

			var teams = await nhlApi.GetInactiveTeamsAsync();

			Assert.IsNotNull(teams);
			CollectionAssert.AllItemsAreNotNull(teams);

			foreach (var team in teams)
			{
				Assert.IsNotNull(team.Conference);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Active);
				Assert.IsNotNull(team.ShortName);
				Assert.IsNotNull(team.Venue);
				Assert.IsNotNull(team.FranchiseId);
				Assert.IsNotNull(team.LocationName);
				Assert.IsNotNull(team.TeamName);
				Assert.IsNotNull(team.OfficialSiteUrl);
				Assert.IsNotNull(team.Abbreviation);
				Assert.IsNotNull(team.Division);
				Assert.IsNotNull(team.Franchise);
				Assert.IsNotNull(team.Id);
				Assert.IsNotNull(team.Name);
				Assert.IsNotNull(team.Link);
				Assert.IsNotNull(team.FirstYearOfPlay);
			}
		}


		[TestMethod]
		public async Task TestGetTeamByIdAsync()
		{
			var nhlApi = new NhlApi();

			var team = await nhlApi.GetTeamByIdAsync(10);
			Assert.IsNotNull(team.Conference);
			Assert.IsNotNull(team.Abbreviation);
			Assert.IsNotNull(team.Active);
			Assert.IsNotNull(team.ShortName);
			Assert.IsNotNull(team.Venue);
			Assert.IsNotNull(team.FranchiseId);
			Assert.IsNotNull(team.LocationName);
			Assert.IsNotNull(team.TeamName);
			Assert.IsNotNull(team.OfficialSiteUrl);
			Assert.IsNotNull(team.Abbreviation);
			Assert.IsNotNull(team.Division);
			Assert.IsNotNull(team.Franchise);
			Assert.IsNotNull(team.Id);
			Assert.IsNotNull(team.Name);
			Assert.IsNotNull(team.Link);
			Assert.IsNotNull(team.FirstYearOfPlay);
		}

		[TestMethod]
		public async Task TestGetTeamWithInvalidIdAsync()
		{
			var nhlApi = new NhlApi();

			var franchise = await nhlApi.GetFranchiseByIdAsync(999);

			Assert.IsNull(franchise);
		}
	}
}
