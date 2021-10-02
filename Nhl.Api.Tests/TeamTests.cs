using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Team;
using System;
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
		public async Task TestGetAllPlayersAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamRosterMembers = await nhlApi.GetLeagueTeamRosterMembersAsync();

			// Assert
			CollectionAssert.AllItemsAreNotNull(teamRosterMembers);

			var teamRosterMember = teamRosterMembers.First();
			Assert.IsNotNull(teamRosterMember.JerseyNumber);
			Assert.IsNotNull(teamRosterMember.Person);
			Assert.IsNotNull(teamRosterMember.Person.FullName);
			Assert.IsNotNull(teamRosterMember.Person.Id);
			Assert.IsNotNull(teamRosterMember.Person.Link);
			Assert.IsNotNull(teamRosterMember.Position);
			Assert.IsNotNull(teamRosterMember.Position.Code);
			Assert.IsNotNull(teamRosterMember.Position.Abbreviation);
			Assert.IsNotNull(teamRosterMember.Position.Name);

		}

		[DataTestMethod]
		[DataRow("sidne")]
		[DataRow("mcdaVid")]
		[DataRow("Auston Matth")]
		[DataRow("Price")]
		[DataRow("John")]
		public async Task TestSearchLeagueTeamRosterMembersAsync(string query)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var players = await nhlApi.SearchLeagueTeamRosterMembersAsync(query);

			// Assert
			CollectionAssert.AllItemsAreNotNull(players);

			var player = players.First();
			Assert.IsNotNull(player.JerseyNumber);
			Assert.IsNotNull(player.Person);
			Assert.IsNotNull(player.Person.FullName);
			Assert.IsNotNull(player.Person.Id);
			Assert.IsNotNull(player.Person.Link);
			Assert.IsNotNull(player.Position);
			Assert.IsNotNull(player.Position.Code);
			Assert.IsNotNull(player.Position.Abbreviation);
			Assert.IsNotNull(player.Position.Name);

		}

		[TestMethod]
		public async Task TestSearchLeagueTeamRosterMembersNullQueryAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var players = await nhlApi.SearchLeagueTeamRosterMembersAsync(string.Empty);

			// Assert
			Assert.AreEqual(0, players.Count);
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
