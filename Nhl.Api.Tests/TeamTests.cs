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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

            // Act
            var team = await nhlApi.GetTeamByIdAsync(999);

            // Assert
            Assert.IsNull(team);

        }

        [TestMethod]
        public async Task TestGetTeamByIdEnumAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

            // Act
            var teams = await nhlApi.GetTeamsByIdsAsync(new[] { 8, 10 });

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
                Assert.IsNotNull(team.OfficialDarkTeamLogoUrl);
                Assert.IsNotNull(team.OfficialLightTeamLogoUrl);

            }

        }

        [TestMethod]
        public async Task TestGetTeamsByIdsIntEmptyArrayAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

            // Act
            var players = await nhlApi.SearchLeagueTeamRosterMembersAsync(string.Empty);

            // Assert
            Assert.AreEqual(0, players.Count);
        }

        [TestMethod]
        public async Task TestGetTeamWithInvalidIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
        [TestMethod]
        public async Task TestGetTeamLogoDarkAsync(TeamEnum teamEnum)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
        [TestMethod]
        public async Task TestGetTeamLogoLightAsIntAsync(int teamId)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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

        [TestMethod]
        public async Task TestGetTeamStatisticsBySeasonWithEnumAsync()
        {

            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var teamStats = await nhlApi.GetTeamStatisticsBySeasonAsync(TeamEnum.DallasStars, SeasonYear.season20102011);

            // Assert
            Assert.IsNotNull(teamStats);
            Assert.IsNotNull(teamStats.Conference);
            Assert.IsNotNull(teamStats.Abbreviation);
            Assert.IsNotNull(teamStats.Active);
            Assert.IsNotNull(teamStats.ShortName);
            Assert.IsNotNull(teamStats.Venue);
            Assert.IsNotNull(teamStats.FranchiseId);
            Assert.IsNotNull(teamStats.LocationName);
            Assert.IsNotNull(teamStats.TeamName);
            Assert.IsNotNull(teamStats.OfficialSiteUrl);
            Assert.IsNotNull(teamStats.Abbreviation);
            Assert.IsNotNull(teamStats.Division);
            Assert.IsNotNull(teamStats.Franchise);
            Assert.IsNotNull(teamStats.Id);
            Assert.IsNotNull(teamStats.Name);
            Assert.IsNotNull(teamStats.Link);
            Assert.IsNotNull(teamStats.FirstYearOfPlay);

            var firstTeamStatistic = teamStats.TeamStatistics.First();
            Assert.IsNotNull(firstTeamStatistic.Type.GameType);
            Assert.IsNotNull(firstTeamStatistic.Type.DisplayName);

            var firstTeamStatSplit = firstTeamStatistic.Splits.First();
            Assert.IsNotNull(firstTeamStatSplit.Team.Id);
            Assert.IsNotNull(firstTeamStatSplit.Team.Link);
            Assert.IsNotNull(firstTeamStatSplit.Team.Name);
            Assert.IsNotNull(firstTeamStatSplit.Team.OfficialDarkTeamLogoUrl);
            Assert.IsNotNull(firstTeamStatSplit.Team.OfficialLightTeamLogoUrl);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Wins);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Losses);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Ot);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);

            var lastTeamStatSplit = firstTeamStatistic.Splits.Last();
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Wins);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Losses);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Ot);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);

        }


        [TestMethod]
        public async Task TestGetTeamStatisticsBySeasonWithIntAsync()
        {

            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var teamStats = await nhlApi.GetTeamStatisticsBySeasonAsync(55, SeasonYear.season20212022);

            // Assert
            Assert.IsNotNull(teamStats);
            Assert.IsNotNull(teamStats.Conference);
            Assert.IsNotNull(teamStats.Abbreviation);
            Assert.IsNotNull(teamStats.Active);
            Assert.IsNotNull(teamStats.ShortName);
            Assert.IsNotNull(teamStats.Venue);
            Assert.IsNotNull(teamStats.FranchiseId);
            Assert.IsNotNull(teamStats.LocationName);
            Assert.IsNotNull(teamStats.TeamName);
            Assert.IsNotNull(teamStats.OfficialSiteUrl);
            Assert.IsNotNull(teamStats.Abbreviation);
            Assert.IsNotNull(teamStats.Division);
            Assert.IsNotNull(teamStats.Franchise);
            Assert.IsNotNull(teamStats.Id);
            Assert.IsNotNull(teamStats.Name);
            Assert.IsNotNull(teamStats.Link);
            Assert.IsNotNull(teamStats.FirstYearOfPlay);

            var firstTeamStatistic = teamStats.TeamStatistics.First();
            Assert.IsNotNull(firstTeamStatistic.Type.GameType);
            Assert.IsNotNull(firstTeamStatistic.Type.DisplayName);

            var firstTeamStatSplit = firstTeamStatistic.Splits.First();
            Assert.IsNotNull(firstTeamStatSplit.Team.Id);
            Assert.IsNotNull(firstTeamStatSplit.Team.Link);
            Assert.IsNotNull(firstTeamStatSplit.Team.Name);
            Assert.IsNotNull(firstTeamStatSplit.Team.OfficialDarkTeamLogoUrl);
            Assert.IsNotNull(firstTeamStatSplit.Team.OfficialLightTeamLogoUrl);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Wins);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Losses);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Ot);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
            Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);

            var lastTeamStatSplit = firstTeamStatistic.Splits.Last();
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Wins);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Losses);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Ot);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
            Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);

        }


        [TestMethod]
        public async Task TestGetAllTeamStatisticsBySeasonWithIntAsync()
        {

            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var teamStats = await nhlApi.GetAllTeamsStatisticsBySeasonAsync(SeasonYear.season19881989);

            // Assert
            Assert.IsNotNull(teamStats);

            foreach (var teamStat in teamStats.Teams)
            {
                Assert.IsNotNull(teamStat.Conference);
                Assert.IsNotNull(teamStat.Abbreviation);
                Assert.IsNotNull(teamStat.Active);
                Assert.IsNotNull(teamStat.ShortName);
                Assert.IsNotNull(teamStat.FranchiseId);
                Assert.IsNotNull(teamStat.LocationName);
                Assert.IsNotNull(teamStat.TeamName);
                Assert.IsNotNull(teamStat.Abbreviation);
                Assert.IsNotNull(teamStat.Division);
                Assert.IsNotNull(teamStat.Franchise);
                Assert.IsNotNull(teamStat.Id);
                Assert.IsNotNull(teamStat.Name);
                Assert.IsNotNull(teamStat.Link);
                Assert.IsNotNull(teamStat.FirstYearOfPlay);

                Assert.IsNotNull(teamStat.TeamStatistics);

                foreach (var teamStatistic in teamStat.TeamStatistics)
                {
                    Assert.IsNotNull(teamStatistic.Type.GameType);
                    Assert.IsNotNull(teamStatistic.Type.DisplayName);

                    var firstTeamStatSplit = teamStatistic.Splits.First();
                    Assert.IsNotNull(firstTeamStatSplit.Team.Id);
                    Assert.IsNotNull(firstTeamStatSplit.Team.Link);
                    Assert.IsNotNull(firstTeamStatSplit.Team.Name);
                    Assert.IsNotNull(firstTeamStatSplit.Team.OfficialDarkTeamLogoUrl);
                    Assert.IsNotNull(firstTeamStatSplit.Team.OfficialLightTeamLogoUrl);

                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Wins);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Losses);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.Ot);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
                    Assert.IsNotNull(firstTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);

                    var lastTeamStatSplit = teamStatistic.Splits.Last();
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);

                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.EvGGARatio);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsLost);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsTaken);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadFirstPer);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinLeadSecondPer);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOppScoreFirst);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshootOpp);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinOutshotByOpp);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Wins);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.WinScoreFirst);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffsWon);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.FaceOffWinPercentage);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GamesPlayed);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsAgainstPerGame);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.GoalsPerGame);

                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Losses);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.Ot);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoalsAgainst);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayOpportunities);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayPercentage);

                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PowerPlayGoals);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.PenaltyKillPercentage);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShootingPctg);
                    Assert.IsNotNull(lastTeamStatSplit.TeamStatisticsDetails.ShotsPerGame);


                }
            }
        }
    }
}
