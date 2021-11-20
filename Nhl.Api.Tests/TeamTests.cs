using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
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
		public async Task TestGetTeamByIdInvalidAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var team = await nhlApi.GetTeamByIdAsync(999);

			// Assert
			Assert.IsNull(team);

		}

		[TestMethod]
		public async Task TestGetTeamByIdEnumAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var team = await nhlApi.GetTeamByIdAsync(TeamEnum.BuffaloSabres);

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
		public async Task TestGetTeamsByIdsEnumAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teams = await nhlApi.GetTeamsByIdsAsync(new[] { TeamEnum.BuffaloSabres, TeamEnum.ArizonaCoyotes });

            // Assert
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
		public async Task TestGetTeamsByIdsEnumEmptyArrayAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teams = await nhlApi.GetTeamsByIdsAsync(new TeamEnum[] { });

			// Assert
			Assert.IsNotNull(teams);
			Assert.AreEqual(32, teams.Count);

		}

		[TestMethod]
		public async Task TestGetTeamsByIdsIntAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teams = await nhlApi.GetTeamsByIdsAsync(new[] { 8,10 });

			// Assert
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
				Assert.IsNotNull(team.OfficalDarkTeamLogoUrl);
				Assert.IsNotNull(team.OfficalLightTeamLogoUrl);

			}

		}

		[TestMethod]
		public async Task TestGetTeamsByIdsIntEmptyArrayAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teams = await nhlApi.GetTeamsByIdsAsync(new int[] { });

			// Assert
			Assert.IsNotNull(teams);
			Assert.AreEqual(32, teams.Count);

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
		[DataRow(SeasonYear.season19171918)]
		[DataRow(SeasonYear.season19971998)]
		[DataRow(SeasonYear.season20202021)]
		public async Task TestGetLeagueTeamRosterMembersWithSeasonAsync(string seasonYear)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamRosterMembers = await nhlApi.GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear);

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
		[DataRow("Ovechkin")]
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

		[DataRow(TeamEnum.TorontoMapleLeafs)]
		[DataRow(TeamEnum.ArizonaCoyotes)]
		[DataRow(TeamEnum.DetroitRedWings)]
		[DataRow(TeamEnum.AnaheimDucks)]
		[TestMethod]
		public async Task TestGetTeamLogoLightAsync(TeamEnum teamEnum)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Light);

			// Assert
			Assert.IsNotNull(teamLogo);
			Assert.IsNotNull(teamLogo.Uri);
			Assert.IsNotNull(teamLogo.ImageAsByteArray);
			Assert.IsNotNull(teamLogo.ImageAsBase64String);

			Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
			Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
		}


		[DataRow(TeamEnum.ColoradoAvalanche)]
		[DataRow(TeamEnum.SanJoseSharks)]
		[DataRow(TeamEnum.ColumbusBlueJackets)]
		[DataRow(TeamEnum.ChicagoBlackhawks)]
		[TestMethod]
		public async Task TestGetTeamLogoDarkAsync(TeamEnum teamEnum)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Dark);

			// Assert
			Assert.IsNotNull(teamLogo);
			Assert.IsNotNull(teamLogo.Uri);
			Assert.IsNotNull(teamLogo.ImageAsByteArray);
			Assert.IsNotNull(teamLogo.ImageAsBase64String);

			Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
			Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
		}

		[DataRow(10)]
		[DataRow(55)]
		[DataRow(7)]
		[DataRow(24)]
		[TestMethod]
		public async Task TestGetTeamLogoLightAsIntAsync(int teamId)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

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
		[TestMethod]
		public async Task TestGetTeamLogoDarkAsIntAsync(int teamId)
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

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
