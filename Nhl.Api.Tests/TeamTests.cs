using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Team;
using System.Collections.Generic;
using System.Linq;
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
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teams = await nhlApi.GetInactiveTeamsAsync();

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
		public async Task TestGetTeamByIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var team = await nhlApi.GetTeamByIdAsync(10);

			// Assert
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
		public async Task TestGetManyTeamsByTasksAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamTasks = new List<Task<Team>> { nhlApi.GetTeamByIdAsync(10), nhlApi.GetTeamByIdAsync(17) };
			var teams = await Task.WhenAll(teamTasks);

			// Assert
			CollectionAssert.AllItemsAreNotNull(teams);
			Assert.AreEqual(2, teams.Count());
		}

		[TestMethod]
		public async Task TestGetTeamWithInvalidIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var franchise = await nhlApi.GetFranchiseByIdAsync(999);

			// Assert
			Assert.IsNull(franchise);
		}
	}
}
