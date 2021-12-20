[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/master-build.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/master-build.yml)
[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/develop-build.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/develop-build.yml)
[![Code Analysis](https://github.com/Afischbacher/Nhl.Api/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/codeql-analysis.yml)
[![NuGet](https://img.shields.io/nuget/v/Nhl.Api)](https://www.nuget.org/packages/Nhl.Api)
[![Issues](https://img.shields.io/github/issues/Afischbacher/Nhl.Api.svg)](https://github.com/Afischbacher/Nhl.Api/issues)
[![License](https://img.shields.io/github/license/Afischbacher/Nhl.Api)](https://github.com/Afischbacher/Nhl.Api/blob/master/LICENSE)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Afischbacher/Nhl.Api/graphs/commit-activity)

# The Official Unofficial .NET NHL API 🏒
A C# .NET Standard 2.0 library for the .NET NHL API

## Installing Nhl.Api 💭
You should install Nhl.Api with NuGet:
```
Install-Package Nhl.Api
```
Or via the .NET Core command line interface:
```
dotnet add package Nhl.Api
```
Either commands, from Package Manager Console or .NET Core CLI, will download and install all required dependencies.

## Implementation 🚀
If you are using any type of a inversion of control or dependency injection library such as the built in library within .NET Core, Unity, or AutoFac. It's very simple to implement, or you can create an instance of the `NhlApi` class and use the API as you would like. 

If you are using the built-in .NET Core dependency injection library, there is a NuGet package to easily add the Nhl.Api to your .NET application, <a href="https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection">Nhl.Api.Extensions.Microsoft.DependencyInjection</a> this extension, it's highly recommended.

### Nhl.Api.Extensions.Microsoft.DependencyInjection
`builder.Services.AddNhlApi();`

### .NET Core
`builder.Services.AddTransient<INhlApi, NhlApi>();`

### Unity
`container.RegisterType<INhlApi, NhlApi>();`

### AutoFac
`builder.RegisterType<NhlApi>().As<INhlApi>();`

### Simple Object Instantiation
`var nhlApi = new NhlApi();`

<br/>
You can also use a subset of the Nhl.Api for specific data within the Nhl.Api, such as only game data, player data, statistics or league information.<br/> These 
individual API's make up the Nhl.Api in it's entirety. <br/>
If you are using the  <a href="https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection">Nhl.Api.Extensions.Microsoft.DependencyInjection</a> NuGet, these API's are 
included automatically within your .NET Core project.

### Nhl Player Api
#### .NET Core
`builder.Services.AddTransient<INhlPlayerApi, NhlPlayerApi>();` <br/>
#### Unity
`container.RegisterType<INhlPlayerApi, NhlPlayerApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlPlayerApi>().As<INhlPlayerApi>();`<br/>
#### Simple Object Instantiation
`var nhlPlayerApi = new NhlPlayerApi();`<br/>

### Nhl Game Api
#### .NET Core
`builder.Services.AddTransient<INhlGameApi, NhlGameApi>();`<br/>
#### Unity
`container.RegisterType<INhlGameApi, NhlGameApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlGameApi>().As<INhlGameApi>();`<br/>
#### Simple Object Instantiation
`var nhlGameApi = new NhlGameApi();`<br/>

### Nhl Statistics Api
#### .NET Core
`builder.Services.AddTransient<INhlStatisticsApi, NhlStatisticsApi>();`<br/>
#### Unity
`container.RegisterType<INhlStatisticsApi, NhlStatisticsApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlStatisticsApi>().As<INhlStatisticsApi>();`<br/>
#### Simple Object Instantiation
`var nhlStatisticsApi = new NhlStatisticsApi();`<br/>

### Nhl League Api
#### .NET Core
`builder.Services.AddTransient<INhlLeagueApi, NhlLeagueApi>();`<br/>
#### Unity
`container.RegisterType<INhlLeagueApi, NhlLeagueApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlLeagueApi>().As<INhlLeagueApi>();`<br/>
#### Simple Object Instantiation
`var nhlLeagueApi = new NhlLeagueApi();`<br/>

## Documentation 📖
Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.

<a name='assembly'></a>
# Nhl.Api

### Contents

- [NhlApi](#T-Nhl-Api-NhlApi 'Nhl.Api.NhlApi')
  - [Dispose()](#M-Nhl-Api-NhlApi-Dispose 'Nhl.Api.NhlApi.Dispose')
  - [GetActiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetActiveFranchisesAsync 'Nhl.Api.NhlApi.GetActiveFranchisesAsync')
  - [GetActiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetActiveTeamsAsync 'Nhl.Api.NhlApi.GetActiveTeamsAsync')
  - [GetAllPlayersAsync()](#M-Nhl-Api-NhlApi-GetAllPlayersAsync 'Nhl.Api.NhlApi.GetAllPlayersAsync')
  - [GetAllTeamsStatisticsBySeasonAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetAllTeamsStatisticsBySeasonAsync-System-String- 'Nhl.Api.NhlApi.GetAllTeamsStatisticsBySeasonAsync(System.String)')
  - [GetBoxScoreByIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetBoxScoreByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetBoxScoreByIdAsync(System.Int32)')
  - [GetConferenceByIdAsync(conferenceId)](#M-Nhl-Api-NhlApi-GetConferenceByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetConferenceByIdAsync(System.Int32)')
  - [GetConferenceByIdAsync(conference)](#M-Nhl-Api-NhlApi-GetConferenceByIdAsync-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum- 'Nhl.Api.NhlApi.GetConferenceByIdAsync(Nhl.Api.Models.Enumerations.Conference.ConferenceEnum)')
  - [GetConferencesAsync()](#M-Nhl-Api-NhlApi-GetConferencesAsync 'Nhl.Api.NhlApi.GetConferencesAsync')
  - [GetCurrentSeasonAsync()](#M-Nhl-Api-NhlApi-GetCurrentSeasonAsync 'Nhl.Api.NhlApi.GetCurrentSeasonAsync')
  - [GetDivisionByIdAsync(divisionId)](#M-Nhl-Api-NhlApi-GetDivisionByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetDivisionByIdAsync(System.Int32)')
  - [GetDivisionByIdAsync(division)](#M-Nhl-Api-NhlApi-GetDivisionByIdAsync-Nhl-Api-Models-Enumerations-Division-DivisionEnum- 'Nhl.Api.NhlApi.GetDivisionByIdAsync(Nhl.Api.Models.Enumerations.Division.DivisionEnum)')
  - [GetDivisionsAsync()](#M-Nhl-Api-NhlApi-GetDivisionsAsync 'Nhl.Api.NhlApi.GetDivisionsAsync')
  - [GetDraftByYearAsync(year)](#M-Nhl-Api-NhlApi-GetDraftByYearAsync-System-String- 'Nhl.Api.NhlApi.GetDraftByYearAsync(System.String)')
  - [GetEventTypesAsync()](#M-Nhl-Api-NhlApi-GetEventTypesAsync 'Nhl.Api.NhlApi.GetEventTypesAsync')
  - [GetFranchiseByIdAsync(franchiseId)](#M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetFranchiseByIdAsync(System.Int32)')
  - [GetFranchiseByIdAsync(franchise)](#M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum- 'Nhl.Api.NhlApi.GetFranchiseByIdAsync(Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum)')
  - [GetFranchisesAsync()](#M-Nhl-Api-NhlApi-GetFranchisesAsync 'Nhl.Api.NhlApi.GetFranchisesAsync')
  - [GetGameScheduleAsync()](#M-Nhl-Api-NhlApi-GetGameScheduleAsync 'Nhl.Api.NhlApi.GetGameScheduleAsync')
  - [GetGameScheduleByDateAsync(date)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlApi.GetGameScheduleByDateAsync(System.Nullable{System.DateTime})')
  - [GetGameScheduleByDateAsync(year,month,day)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Int32,System-Int32,System-Int32- 'Nhl.Api.NhlApi.GetGameScheduleByDateAsync(System.Int32,System.Int32,System.Int32)')
  - [GetGameScheduleForTeamByDateAsync(team,startDate,endDate)](#M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTime,System-DateTime- 'Nhl.Api.NhlApi.GetGameScheduleForTeamByDateAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.DateTime,System.DateTime)')
  - [GetGameScheduleForTeamByDateAsync(teamId,startDate,endDate)](#M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-System-Int32,System-DateTime,System-DateTime- 'Nhl.Api.NhlApi.GetGameScheduleForTeamByDateAsync(System.Int32,System.DateTime,System.DateTime)')
  - [GetGameScheduleBySeasonAsync(seasonYear,includePlayoffGames)](#M-Nhl-Api-NhlApi-GetGameScheduleBySeasonAsync-System-String,System-Boolean- 'Nhl.Api.NhlApi.GetGameScheduleBySeasonAsync(System.String,System.Boolean)')
  - [GetGameStatusesAsync()](#M-Nhl-Api-NhlApi-GetGameStatusesAsync 'Nhl.Api.NhlApi.GetGameStatusesAsync')
  - [GetGameTypesAsync()](#M-Nhl-Api-NhlApi-GetGameTypesAsync 'Nhl.Api.NhlApi.GetGameTypesAsync')
  - [GetGoalieStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetGoalieStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetGoalieStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlApi.GetGoalieStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetGoalieWithTopStatisticBySeasonAsync(goalieStatisticEnum,seasonYear)](#M-Nhl-Api-NhlApi-GetGoalieWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum,System-String- 'Nhl.Api.NhlApi.GetGoalieWithTopStatisticBySeasonAsync(Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum,System.String)')
  - [GetInactiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetInactiveFranchisesAsync 'Nhl.Api.NhlApi.GetInactiveFranchisesAsync')
  - [GetInactiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetInactiveTeamsAsync 'Nhl.Api.NhlApi.GetInactiveTeamsAsync')
  - [GetLeagueAwardByIdAsync(awardId)](#M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLeagueAwardByIdAsync(System.Int32)')
  - [GetLeagueAwardByIdAsync(leagueAward)](#M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-Nhl-Api-Models-Enumerations-Award-AwardEnum- 'Nhl.Api.NhlApi.GetLeagueAwardByIdAsync(Nhl.Api.Models.Enumerations.Award.AwardEnum)')
  - [GetLeagueAwardsAsync()](#M-Nhl-Api-NhlApi-GetLeagueAwardsAsync 'Nhl.Api.NhlApi.GetLeagueAwardsAsync')
  - [GetLeagueProspectByIdAsync(prospectId)](#M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLeagueProspectByIdAsync(System.Int32)')
  - [GetLeagueProspectByIdAsync(prospect)](#M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum- 'Nhl.Api.NhlApi.GetLeagueProspectByIdAsync(Nhl.Api.Models.Enumerations.Prospect.ProspectEnum)')
  - [GetLeagueProspectsAsync()](#M-Nhl-Api-NhlApi-GetLeagueProspectsAsync 'Nhl.Api.NhlApi.GetLeagueProspectsAsync')
  - [GetLeagueStandingTypesAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingTypesAsync 'Nhl.Api.NhlApi.GetLeagueStandingTypesAsync')
  - [GetLeagueStandingsAsync(date)](#M-Nhl-Api-NhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlApi.GetLeagueStandingsAsync(System.Nullable{System.DateTime})')
  - [GetLeagueStandingsAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingsAsync 'Nhl.Api.NhlApi.GetLeagueStandingsAsync')
  - [GetLeagueStandingsByConferenceAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingsByConferenceAsync 'Nhl.Api.NhlApi.GetLeagueStandingsByConferenceAsync')
  - [GetLeagueStandingsByConferenceAsync(date)](#M-Nhl-Api-NhlApi-GetLeagueStandingsByConferenceAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlApi.GetLeagueStandingsByConferenceAsync(System.Nullable{System.DateTime})')
  - [GetLeagueStandingsByDivisionAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingsByDivisionAsync 'Nhl.Api.NhlApi.GetLeagueStandingsByDivisionAsync')
  - [GetLeagueStandingsByDivisionAsync(date)](#M-Nhl-Api-NhlApi-GetLeagueStandingsByDivisionAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlApi.GetLeagueStandingsByDivisionAsync(System.Nullable{System.DateTime})')
  - [GetLeagueTeamRosterMembersAsync()](#M-Nhl-Api-NhlApi-GetLeagueTeamRosterMembersAsync 'Nhl.Api.NhlApi.GetLeagueTeamRosterMembersAsync')
  - [GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetLeagueTeamRosterMembersBySeasonYearAsync-System-String- 'Nhl.Api.NhlApi.GetLeagueTeamRosterMembersBySeasonYearAsync(System.String)')
  - [GetLeagueVenueByIdAsync(venueId)](#M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLeagueVenueByIdAsync(System.Int32)')
  - [GetLeagueVenueByIdAsync(venue)](#M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-Nhl-Api-Models-Enumerations-Venue-VenueEnum- 'Nhl.Api.NhlApi.GetLeagueVenueByIdAsync(Nhl.Api.Models.Enumerations.Venue.VenueEnum)')
  - [GetLeagueVenuesAsync()](#M-Nhl-Api-NhlApi-GetLeagueVenuesAsync 'Nhl.Api.NhlApi.GetLeagueVenuesAsync')
  - [GetLineScoreByIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetLineScoreByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLineScoreByIdAsync(System.Int32)')
  - [GetLiveGameFeedByIdAsync(gameId,liveGameFeedConfiguration)](#M-Nhl-Api-NhlApi-GetLiveGameFeedByIdAsync-System-Int32,Nhl-Api-Models-Game-LiveGameFeedConfiguration- 'Nhl.Api.NhlApi.GetLiveGameFeedByIdAsync(System.Int32,Nhl.Api.Models.Game.LiveGameFeedConfiguration)')
  - [GetOnPaceRegularSeasonPlayerStatisticsAsync(player)](#M-Nhl-Api-NhlApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId)](#M-Nhl-Api-NhlApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-System-Int32- 'Nhl.Api.NhlApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(System.Int32)')
  - [GetPlayTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayTypesAsync 'Nhl.Api.NhlApi.GetPlayTypesAsync')
  - [GetPlayerByIdAsync(playerId)](#M-Nhl-Api-NhlApi-GetPlayerByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetPlayerByIdAsync(System.Int32)')
  - [GetPlayerByIdAsync(player)](#M-Nhl-Api-NhlApi-GetPlayerByIdAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlApi.GetPlayerByIdAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetPlayerStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetPlayerStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetPlayerStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlApi.GetPlayerStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetPlayerWithTopStatisticBySeasonAsync(seasonYear,playerStatisticEnum)](#M-Nhl-Api-NhlApi-GetPlayerWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum,System-String- 'Nhl.Api.NhlApi.GetPlayerWithTopStatisticBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum,System.String)')
  - [GetPlayersByIdAsync(playerIds)](#M-Nhl-Api-NhlApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Nhl.Api.NhlApi.GetPlayersByIdAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetPlayersByIdAsync(players)](#M-Nhl-Api-NhlApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Player-PlayerEnum}- 'Nhl.Api.NhlApi.GetPlayersByIdAsync(System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum})')
  - [GetPlayoffTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayoffTournamentTypesAsync 'Nhl.Api.NhlApi.GetPlayoffTournamentTypesAsync')
  - [GetSeasonByYearAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetSeasonByYearAsync-System-String- 'Nhl.Api.NhlApi.GetSeasonByYearAsync(System.String)')
  - [GetSeasonsAsync()](#M-Nhl-Api-NhlApi-GetSeasonsAsync 'Nhl.Api.NhlApi.GetSeasonsAsync')
  - [GetStatisticTypesAsync()](#M-Nhl-Api-NhlApi-GetStatisticTypesAsync 'Nhl.Api.NhlApi.GetStatisticTypesAsync')
  - [GetTeamByIdAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetTeamByIdAsync(System.Int32)')
  - [GetTeamByIdAsync(team)](#M-Nhl-Api-NhlApi-GetTeamByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetTeamByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamLogoAsync(teamId,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(System.Int32,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamLogoAsync(team,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamStatisticsByIdAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsByIdAsync(System.Int32,System.String)')
  - [GetTeamStatisticsByIdAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamStatisticsBySeasonAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetTeamStatisticsBySeasonAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamsAsync()](#M-Nhl-Api-NhlApi-GetTeamsAsync 'Nhl.Api.NhlApi.GetTeamsAsync')
  - [GetTeamsByIdsAsync(teamIds)](#M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Nhl.Api.NhlApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetTeamsByIdsAsync(teams)](#M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Team-TeamEnum}- 'Nhl.Api.NhlApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum})')
  - [GetTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetTournamentTypesAsync 'Nhl.Api.NhlApi.GetTournamentTypesAsync')
  - [IsPlayoffsActiveAsync()](#M-Nhl-Api-NhlApi-IsPlayoffsActiveAsync 'Nhl.Api.NhlApi.IsPlayoffsActiveAsync')
  - [IsRegularSeasonActiveAsync()](#M-Nhl-Api-NhlApi-IsRegularSeasonActiveAsync 'Nhl.Api.NhlApi.IsRegularSeasonActiveAsync')
  - [IsSeasonActiveAsync()](#M-Nhl-Api-NhlApi-IsSeasonActiveAsync 'Nhl.Api.NhlApi.IsSeasonActiveAsync')
  - [SearchAllActivePlayersAsync(query)](#M-Nhl-Api-NhlApi-SearchAllActivePlayersAsync-System-String- 'Nhl.Api.NhlApi.SearchAllActivePlayersAsync(System.String)')
  - [SearchAllPlayersAsync(query)](#M-Nhl-Api-NhlApi-SearchAllPlayersAsync-System-String- 'Nhl.Api.NhlApi.SearchAllPlayersAsync(System.String)')
  - [SearchLeagueTeamRosterMembersAsync(query)](#M-Nhl-Api-NhlApi-SearchLeagueTeamRosterMembersAsync-System-String- 'Nhl.Api.NhlApi.SearchLeagueTeamRosterMembersAsync(System.String)')
- [NhlGameApi](#T-Nhl-Api-NhlGameApi 'Nhl.Api.NhlGameApi')
  - [GetBoxScoreByIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetBoxScoreByIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetBoxScoreByIdAsync(System.Int32)')
  - [GetGameScheduleAsync()](#M-Nhl-Api-NhlGameApi-GetGameScheduleAsync 'Nhl.Api.NhlGameApi.GetGameScheduleAsync')
  - [GetGameScheduleByDateAsync(date)](#M-Nhl-Api-NhlGameApi-GetGameScheduleByDateAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlGameApi.GetGameScheduleByDateAsync(System.Nullable{System.DateTime})')
  - [GetGameScheduleByDateAsync(year,month,day)](#M-Nhl-Api-NhlGameApi-GetGameScheduleByDateAsync-System-Int32,System-Int32,System-Int32- 'Nhl.Api.NhlGameApi.GetGameScheduleByDateAsync(System.Int32,System.Int32,System.Int32)')
  - [GetGameScheduleForTeamByDateAsync(team,startDate,endDate)](#M-Nhl-Api-NhlGameApi-GetGameScheduleForTeamByDateAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTime,System-DateTime- 'Nhl.Api.NhlGameApi.GetGameScheduleForTeamByDateAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.DateTime,System.DateTime)')
  - [GetGameScheduleForTeamByDateAsync(teamId,startDate,endDate)](#M-Nhl-Api-NhlGameApi-GetGameScheduleForTeamByDateAsync-System-Int32,System-DateTime,System-DateTime- 'Nhl.Api.NhlGameApi.GetGameScheduleForTeamByDateAsync(System.Int32,System.DateTime,System.DateTime)')
  - [GetGameScheduleBySeasonAsync(seasonYear,includePlayoffGames)](#M-Nhl-Api-NhlGameApi-GetGameScheduleBySeasonAsync-System-String,System-Boolean- 'Nhl.Api.NhlGameApi.GetGameScheduleBySeasonAsync(System.String,System.Boolean)')
  - [GetGameStatusesAsync()](#M-Nhl-Api-NhlGameApi-GetGameStatusesAsync 'Nhl.Api.NhlGameApi.GetGameStatusesAsync')
  - [GetGameTypesAsync()](#M-Nhl-Api-NhlGameApi-GetGameTypesAsync 'Nhl.Api.NhlGameApi.GetGameTypesAsync')
  - [GetLineScoreByIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetLineScoreByIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetLineScoreByIdAsync(System.Int32)')
  - [GetLiveGameFeedByIdAsync(gameId,liveGameFeedConfiguration)](#M-Nhl-Api-NhlGameApi-GetLiveGameFeedByIdAsync-System-Int32,Nhl-Api-Models-Game-LiveGameFeedConfiguration- 'Nhl.Api.NhlGameApi.GetLiveGameFeedByIdAsync(System.Int32,Nhl.Api.Models.Game.LiveGameFeedConfiguration)')
  - [GetPlayTypesAsync()](#M-Nhl-Api-NhlGameApi-GetPlayTypesAsync 'Nhl.Api.NhlGameApi.GetPlayTypesAsync')
  - [GetPlayoffTournamentTypesAsync()](#M-Nhl-Api-NhlGameApi-GetPlayoffTournamentTypesAsync 'Nhl.Api.NhlGameApi.GetPlayoffTournamentTypesAsync')
  - [GetTournamentTypesAsync()](#M-Nhl-Api-NhlGameApi-GetTournamentTypesAsync 'Nhl.Api.NhlGameApi.GetTournamentTypesAsync')
- [NhlLeagueApi](#T-Nhl-Api-NhlLeagueApi 'Nhl.Api.NhlLeagueApi')
  - [GetActiveFranchisesAsync()](#M-Nhl-Api-NhlLeagueApi-GetActiveFranchisesAsync 'Nhl.Api.NhlLeagueApi.GetActiveFranchisesAsync')
  - [GetActiveTeamsAsync()](#M-Nhl-Api-NhlLeagueApi-GetActiveTeamsAsync 'Nhl.Api.NhlLeagueApi.GetActiveTeamsAsync')
  - [GetConferenceByIdAsync(conferenceId)](#M-Nhl-Api-NhlLeagueApi-GetConferenceByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetConferenceByIdAsync(System.Int32)')
  - [GetConferenceByIdAsync(conference)](#M-Nhl-Api-NhlLeagueApi-GetConferenceByIdAsync-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum- 'Nhl.Api.NhlLeagueApi.GetConferenceByIdAsync(Nhl.Api.Models.Enumerations.Conference.ConferenceEnum)')
  - [GetConferencesAsync()](#M-Nhl-Api-NhlLeagueApi-GetConferencesAsync 'Nhl.Api.NhlLeagueApi.GetConferencesAsync')
  - [GetCurrentSeasonAsync()](#M-Nhl-Api-NhlLeagueApi-GetCurrentSeasonAsync 'Nhl.Api.NhlLeagueApi.GetCurrentSeasonAsync')
  - [GetDivisionByIdAsync(division)](#M-Nhl-Api-NhlLeagueApi-GetDivisionByIdAsync-Nhl-Api-Models-Enumerations-Division-DivisionEnum- 'Nhl.Api.NhlLeagueApi.GetDivisionByIdAsync(Nhl.Api.Models.Enumerations.Division.DivisionEnum)')
  - [GetDivisionByIdAsync(divisionId)](#M-Nhl-Api-NhlLeagueApi-GetDivisionByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetDivisionByIdAsync(System.Int32)')
  - [GetDivisionsAsync()](#M-Nhl-Api-NhlLeagueApi-GetDivisionsAsync 'Nhl.Api.NhlLeagueApi.GetDivisionsAsync')
  - [GetDraftByYearAsync(year)](#M-Nhl-Api-NhlLeagueApi-GetDraftByYearAsync-System-String- 'Nhl.Api.NhlLeagueApi.GetDraftByYearAsync(System.String)')
  - [GetEventTypesAsync()](#M-Nhl-Api-NhlLeagueApi-GetEventTypesAsync 'Nhl.Api.NhlLeagueApi.GetEventTypesAsync')
  - [GetFranchiseByIdAsync(franchiseId)](#M-Nhl-Api-NhlLeagueApi-GetFranchiseByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetFranchiseByIdAsync(System.Int32)')
  - [GetFranchiseByIdAsync(franchise)](#M-Nhl-Api-NhlLeagueApi-GetFranchiseByIdAsync-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum- 'Nhl.Api.NhlLeagueApi.GetFranchiseByIdAsync(Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum)')
  - [GetFranchisesAsync()](#M-Nhl-Api-NhlLeagueApi-GetFranchisesAsync 'Nhl.Api.NhlLeagueApi.GetFranchisesAsync')
  - [GetInactiveFranchisesAsync()](#M-Nhl-Api-NhlLeagueApi-GetInactiveFranchisesAsync 'Nhl.Api.NhlLeagueApi.GetInactiveFranchisesAsync')
  - [GetInactiveTeamsAsync()](#M-Nhl-Api-NhlLeagueApi-GetInactiveTeamsAsync 'Nhl.Api.NhlLeagueApi.GetInactiveTeamsAsync')
  - [GetLeagueAwardByIdAsync(awardId)](#M-Nhl-Api-NhlLeagueApi-GetLeagueAwardByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetLeagueAwardByIdAsync(System.Int32)')
  - [GetLeagueAwardByIdAsync(leagueAward)](#M-Nhl-Api-NhlLeagueApi-GetLeagueAwardByIdAsync-Nhl-Api-Models-Enumerations-Award-AwardEnum- 'Nhl.Api.NhlLeagueApi.GetLeagueAwardByIdAsync(Nhl.Api.Models.Enumerations.Award.AwardEnum)')
  - [GetLeagueAwardsAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueAwardsAsync 'Nhl.Api.NhlLeagueApi.GetLeagueAwardsAsync')
  - [GetLeagueStandingTypesAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingTypesAsync 'Nhl.Api.NhlLeagueApi.GetLeagueStandingTypesAsync')
  - [GetLeagueStandingsAsync(date)](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsAsync(System.Nullable{System.DateTime})')
  - [GetLeagueStandingsAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsAsync 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsAsync')
  - [GetLeagueStandingsByConferenceAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByConferenceAsync 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsByConferenceAsync')
  - [GetLeagueStandingsByConferenceAsync(date)](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByConferenceAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsByConferenceAsync(System.Nullable{System.DateTime})')
  - [GetLeagueStandingsByDivisionAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDivisionAsync 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsByDivisionAsync')
  - [GetLeagueStandingsByDivisionAsync(date)](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDivisionAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsByDivisionAsync(System.Nullable{System.DateTime})')
  - [GetLeagueVenueByIdAsync(venue)](#M-Nhl-Api-NhlLeagueApi-GetLeagueVenueByIdAsync-Nhl-Api-Models-Enumerations-Venue-VenueEnum- 'Nhl.Api.NhlLeagueApi.GetLeagueVenueByIdAsync(Nhl.Api.Models.Enumerations.Venue.VenueEnum)')
  - [GetLeagueVenueByIdAsync(venueId)](#M-Nhl-Api-NhlLeagueApi-GetLeagueVenueByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetLeagueVenueByIdAsync(System.Int32)')
  - [GetLeagueVenuesAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueVenuesAsync 'Nhl.Api.NhlLeagueApi.GetLeagueVenuesAsync')
  - [GetSeasonByYearAsync(seasonYear)](#M-Nhl-Api-NhlLeagueApi-GetSeasonByYearAsync-System-String- 'Nhl.Api.NhlLeagueApi.GetSeasonByYearAsync(System.String)')
  - [GetSeasonsAsync()](#M-Nhl-Api-NhlLeagueApi-GetSeasonsAsync 'Nhl.Api.NhlLeagueApi.GetSeasonsAsync')
  - [GetTeamByIdAsync(teamId)](#M-Nhl-Api-NhlLeagueApi-GetTeamByIdAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetTeamByIdAsync(System.Int32)')
  - [GetTeamByIdAsync(team)](#M-Nhl-Api-NhlLeagueApi-GetTeamByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlLeagueApi.GetTeamByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamLogoAsync(team,teamLogoType)](#M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlLeagueApi.GetTeamLogoAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamLogoAsync(teamId,teamLogoType)](#M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlLeagueApi.GetTeamLogoAsync(System.Int32,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamsAsync()](#M-Nhl-Api-NhlLeagueApi-GetTeamsAsync 'Nhl.Api.NhlLeagueApi.GetTeamsAsync')
  - [GetTeamsByIdsAsync(teamIds)](#M-Nhl-Api-NhlLeagueApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Nhl.Api.NhlLeagueApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetTeamsByIdsAsync(teams)](#M-Nhl-Api-NhlLeagueApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Team-TeamEnum}- 'Nhl.Api.NhlLeagueApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum})')
  - [IsPlayoffsActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsPlayoffsActiveAsync 'Nhl.Api.NhlLeagueApi.IsPlayoffsActiveAsync')
  - [IsRegularSeasonActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsRegularSeasonActiveAsync 'Nhl.Api.NhlLeagueApi.IsRegularSeasonActiveAsync')
  - [IsSeasonActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsSeasonActiveAsync 'Nhl.Api.NhlLeagueApi.IsSeasonActiveAsync')
- [NhlPlayerApi](#T-Nhl-Api-NhlPlayerApi 'Nhl.Api.NhlPlayerApi')
  - [Dispose()](#M-Nhl-Api-NhlPlayerApi-Dispose 'Nhl.Api.NhlPlayerApi.Dispose')
  - [GetAllPlayersAsync()](#M-Nhl-Api-NhlPlayerApi-GetAllPlayersAsync 'Nhl.Api.NhlPlayerApi.GetAllPlayersAsync')
  - [GetLeagueProspectByIdAsync(prospectId)](#M-Nhl-Api-NhlPlayerApi-GetLeagueProspectByIdAsync-System-Int32- 'Nhl.Api.NhlPlayerApi.GetLeagueProspectByIdAsync(System.Int32)')
  - [GetLeagueProspectByIdAsync(prospect)](#M-Nhl-Api-NhlPlayerApi-GetLeagueProspectByIdAsync-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum- 'Nhl.Api.NhlPlayerApi.GetLeagueProspectByIdAsync(Nhl.Api.Models.Enumerations.Prospect.ProspectEnum)')
  - [GetLeagueProspectsAsync()](#M-Nhl-Api-NhlPlayerApi-GetLeagueProspectsAsync 'Nhl.Api.NhlPlayerApi.GetLeagueProspectsAsync')
  - [GetLeagueTeamRosterMembersAsync()](#M-Nhl-Api-NhlPlayerApi-GetLeagueTeamRosterMembersAsync 'Nhl.Api.NhlPlayerApi.GetLeagueTeamRosterMembersAsync')
  - [GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear)](#M-Nhl-Api-NhlPlayerApi-GetLeagueTeamRosterMembersBySeasonYearAsync-System-String- 'Nhl.Api.NhlPlayerApi.GetLeagueTeamRosterMembersBySeasonYearAsync(System.String)')
  - [GetPlayerByIdAsync(playerId)](#M-Nhl-Api-NhlPlayerApi-GetPlayerByIdAsync-System-Int32- 'Nhl.Api.NhlPlayerApi.GetPlayerByIdAsync(System.Int32)')
  - [GetPlayerByIdAsync(player)](#M-Nhl-Api-NhlPlayerApi-GetPlayerByIdAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlPlayerApi.GetPlayerByIdAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetPlayersByIdAsync(playerIds)](#M-Nhl-Api-NhlPlayerApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Nhl.Api.NhlPlayerApi.GetPlayersByIdAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetPlayersByIdAsync(players)](#M-Nhl-Api-NhlPlayerApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Player-PlayerEnum}- 'Nhl.Api.NhlPlayerApi.GetPlayersByIdAsync(System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum})')
  - [SearchAllActivePlayersAsync(query)](#M-Nhl-Api-NhlPlayerApi-SearchAllActivePlayersAsync-System-String- 'Nhl.Api.NhlPlayerApi.SearchAllActivePlayersAsync(System.String)')
  - [SearchAllPlayersAsync(query)](#M-Nhl-Api-NhlPlayerApi-SearchAllPlayersAsync-System-String- 'Nhl.Api.NhlPlayerApi.SearchAllPlayersAsync(System.String)')
  - [SearchLeagueTeamRosterMembersAsync(query)](#M-Nhl-Api-NhlPlayerApi-SearchLeagueTeamRosterMembersAsync-System-String- 'Nhl.Api.NhlPlayerApi.SearchLeagueTeamRosterMembersAsync(System.String)')
- [NhlStatisticsApi](#T-Nhl-Api-NhlStatisticsApi 'Nhl.Api.NhlStatisticsApi')
  - [GetAllTeamsStatisticsBySeasonAsync(seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetAllTeamsStatisticsBySeasonAsync-System-String- 'Nhl.Api.NhlStatisticsApi.GetAllTeamsStatisticsBySeasonAsync(System.String)')
  - [GetGoalieStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetGoalieStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlStatisticsApi.GetGoalieStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetGoalieStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetGoalieStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetGoalieStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetGoalieWithTopStatisticBySeasonAsync(goalieStatisticEnum,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetGoalieWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetGoalieWithTopStatisticBySeasonAsync(Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum,System.String)')
  - [GetOnPaceRegularSeasonPlayerStatisticsAsync(player)](#M-Nhl-Api-NhlStatisticsApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlStatisticsApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId)](#M-Nhl-Api-NhlStatisticsApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-System-Int32- 'Nhl.Api.NhlStatisticsApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(System.Int32)')
  - [GetPlayerStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetPlayerStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlStatisticsApi.GetPlayerStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetPlayerStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetPlayerStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetPlayerStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetPlayerWithTopStatisticBySeasonAsync(seasonYear,playerStatisticEnum)](#M-Nhl-Api-NhlStatisticsApi-GetPlayerWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetPlayerWithTopStatisticBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum,System.String)')
  - [GetStatisticTypesAsync()](#M-Nhl-Api-NhlStatisticsApi-GetStatisticTypesAsync 'Nhl.Api.NhlStatisticsApi.GetStatisticTypesAsync')
  - [GetTeamStatisticsByIdAsync(teamId,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsByIdAsync-System-Int32,System-String- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsByIdAsync(System.Int32,System.String)')
  - [GetTeamStatisticsByIdAsync(team,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamStatisticsBySeasonAsync(teamId,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetTeamStatisticsBySeasonAsync(team,seasonYear)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')

<a name='T-Nhl-Api-NhlApi'></a>
## NhlApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more

<a name='M-Nhl-Api-NhlApi-Dispose'></a>
### Dispose() `method`

##### Summary

Releases and disposes all unused or garbage collected resources for the Nhl.Api

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetActiveFranchisesAsync'></a>
### GetActiveFranchisesAsync() `method`

##### Summary

Returns all active NHL franchises

##### Returns

A collection of all active NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetActiveTeamsAsync'></a>
### GetActiveTeamsAsync() `method`

##### Summary

Returns all active NHL teams

##### Returns

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetAllPlayersAsync'></a>
### GetAllPlayersAsync() `method`

##### Summary

Returns every single NHL player to ever play

##### Returns

Returns every single NHL player since the league inception

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetAllTeamsStatisticsBySeasonAsync-System-String-'></a>
### GetAllTeamsStatisticsBySeasonAsync(seasonYear) `method`

##### Summary

Returns all of the NHL team's statistics for the specific NHL season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the all the NHL statistics, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetBoxScoreByIdAsync-System-Int32-'></a>
### GetBoxScoreByIdAsync(gameId) `method`

##### Summary

Returns the box score content for an NHL game

##### Returns

Returns information about the current score, penalties, players, team statistics and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlApi-GetConferenceByIdAsync-System-Int32-'></a>
### GetConferenceByIdAsync(conferenceId) `method`

##### Summary

Returns all of the NHL conferences

##### Returns

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conferenceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL conference id, Example: Eastern Conference is the number 6 |

<a name='M-Nhl-Api-NhlApi-GetConferenceByIdAsync-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum-'></a>
### GetConferenceByIdAsync(conference) `method`

##### Summary

Returns the NHL conference by the conference enumeration 
Example: [Eastern](#F-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum-Eastern 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum.Eastern')

##### Returns

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conference | [Nhl.Api.Models.Enumerations.Conference.ConferenceEnum](#T-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum') | The NHL conference id, Example: 6 - Eastern Conference, see [ConferenceEnum](#T-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum') for more information on NHL conferences |

<a name='M-Nhl-Api-NhlApi-GetConferencesAsync'></a>
### GetConferencesAsync() `method`

##### Summary

Returns all of the NHL conferences

##### Returns

A collection of all the NHL conferences, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetCurrentSeasonAsync'></a>
### GetCurrentSeasonAsync() `method`

##### Summary

Return the current and most recent NHL season

##### Returns

The most recent NHL season

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetDivisionByIdAsync-System-Int32-'></a>
### GetDivisionByIdAsync(divisionId) `method`

##### Summary

Returns an NHL division by the division id

##### Returns

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| divisionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL division id, Example: Atlantic division is the number 17 |

<a name='M-Nhl-Api-NhlApi-GetDivisionByIdAsync-Nhl-Api-Models-Enumerations-Division-DivisionEnum-'></a>
### GetDivisionByIdAsync(division) `method`

##### Summary

Returns an NHL division by the division enumeration 
Example: [Atlantic](#F-Nhl-Api-Models-Enumerations-Division-DivisionEnum-Atlantic 'Nhl.Api.Models.Enumerations.Division.DivisionEnum.Atlantic')

##### Returns

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| division | [Nhl.Api.Models.Enumerations.Division.DivisionEnum](#T-Nhl-Api-Models-Enumerations-Division-DivisionEnum 'Nhl.Api.Models.Enumerations.Division.DivisionEnum') | The NHL division id, Example: 17 - Atlantic division, see [DivisionEnum](#T-Nhl-Api-Models-Enumerations-Division-DivisionEnum 'Nhl.Api.Models.Enumerations.Division.DivisionEnum') for more information on NHL divisions |

<a name='M-Nhl-Api-NhlApi-GetDivisionsAsync'></a>
### GetDivisionsAsync() `method`

##### Summary

Returns all of the NHL divisions

##### Returns

A collection of all the NHL divisions, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetDraftByYearAsync-System-String-'></a>
### GetDraftByYearAsync(year) `method`

##### Summary

Returns the NHL league draft based on a specific year based on the 4 character draft year, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear 'Nhl.Api.Models.Draft.DraftYear') for more information. Some responses provide very large JSON payloads

##### Returns

The NHL league draft, which includes draft rounds, player information and more, see [LeagueDraft](#T-Nhl-Api-Models-Draft-LeagueDraft 'Nhl.Api.Models.Draft.LeagueDraft') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The specified year of the NHL draft, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear 'Nhl.Api.Models.Draft.DraftYear') for all NHL draft years |

<a name='M-Nhl-Api-NhlApi-GetEventTypesAsync'></a>
### GetEventTypesAsync() `method`

##### Summary

Return's all the event types within the NHL

##### Returns

A collection of event types within the NHL, see [EventType](#T-Nhl-Api-Models-Event-EventType 'Nhl.Api.Models.Event.EventType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-System-Int32-'></a>
### GetFranchiseByIdAsync(franchiseId) `method`

##### Summary

Returns an NHL franchise by the franchise id

##### Returns

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| franchiseId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL franchise id, Example: Montréal Canadiens - 1 |

<a name='M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum-'></a>
### GetFranchiseByIdAsync(franchise) `method`

##### Summary

Returns an NHL franchise by the franchise id 
Example: [LosAngelesKings](#F-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum-LosAngelesKings 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum.LosAngelesKings')

##### Returns

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| franchise | [Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum](#T-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum') | The NHL team id, Example: 10 - Toronto Maple Leafs, see [FranchiseEnum](#T-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum') for more information on NHL franchises |

<a name='M-Nhl-Api-NhlApi-GetFranchisesAsync'></a>
### GetFranchisesAsync() `method`

##### Summary

Returns all NHL franchises, including information such as team name, location and more

##### Returns

A collection of all NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetGameScheduleAsync'></a>
### GetGameScheduleAsync() `method`

##### Summary

Return's today's the NHL game schedule and it will provide today's current NHL game schedule

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Nullable{System-DateTime}-'></a>
### GetGameScheduleByDateAsync(date) `method`

##### Summary

Return's the NHL game schedule based on the provided [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime'). If the date is null, it will provide today's current NHL game schedule

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The requested date for the NHL game schedule |

<a name='M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Int32,System-Int32,System-Int32-'></a>
### GetGameScheduleByDateAsync(year,month,day) `method`

##### Summary

Return's the NHL game schedule based on the provided year, month and day

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more infGetGameScheduleByDateAsyncormation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested year for the NHL game schedule |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested month for the NHL game schedule |
| day | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested day for the NHL game schedule |

<a name='M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTime,System-DateTime-'></a>
### GetGameScheduleForTeamByDateAsync(team,startDate,endDate) `method`

##### Summary

Return's the NHL game schedule for the specified team based on the provided start date and end date

##### Returns

Returns all of the NHL team's game schedules based on the selected start and end dates

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks') |
| startDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The starting date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 2017-01-01 |
| endDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The ending date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 1988-06-01 |

<a name='M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-System-Int32,System-DateTime,System-DateTime-'></a>
### GetGameScheduleForTeamByDateAsync(teamId,startDate,endDate) `method`

##### Summary

Return's the NHL game schedule for the specified team based on the provided start date and end date

##### Returns

Returns all of the NHL team's game schedules based on the selected start and end dates

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: 1 |
| startDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The starting date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 2017-01-01 |
| endDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The ending date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 1988-06-01 |

<a name='M-Nhl-Api-NhlApi-GetGameScheduleBySeasonAsync-System-String,System-Boolean-'></a>
### GetGameScheduleBySeasonAsync(seasonYear,includePlayoffGames) `method`

##### Summary

Return's the entire collection of NHL game schedules for the specified season

##### Returns

Returns all of the NHL team's game schedules based on the selected NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, Example: 19992000, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |
| includePlayoffGames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Includes the NHL playoff games if set to true, default value is false |

<a name='M-Nhl-Api-NhlApi-GetGameStatusesAsync'></a>
### GetGameStatusesAsync() `method`

##### Summary

Returns all of the valid NHL game statuses of an NHL game

##### Returns

A collection of NHL game statues, see [GameStatus](#T-Nhl-Api-Models-Game-GameStatus 'Nhl.Api.Models.Game.GameStatus') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetGameTypesAsync'></a>
### GetGameTypesAsync() `method`

##### Summary

Returns all of the NHL game types within a season and within special events

##### Returns

A collection of NHL and other sporting event game types, see [GameType](#T-Nhl-Api-Models-Game-GameType 'Nhl.Api.Models.Game.GameType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetGoalieStatisticsBySeasonAsync(playerId,seasonYear) `method`

##### Summary

Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL goalie statistics per season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL goalie |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String-'></a>
### GetGoalieStatisticsBySeasonAsync(player,seasonYear) `method`

##### Summary

Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL goalie statistics per season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL goalie |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetGoalieWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum,System-String-'></a>
### GetGoalieWithTopStatisticBySeasonAsync(goalieStatisticEnum,seasonYear) `method`

##### Summary

Returns the goalie with the top NHL goalie statistic based on the selected season year

##### Returns

Returns the goalie profile with the top player statistic in the specified NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| goalieStatisticEnum | [Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum 'Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum') | The argument for the type of NHL goalie statistic, see [GoalieStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum 'Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetInactiveFranchisesAsync'></a>
### GetInactiveFranchisesAsync() `method`

##### Summary

Returns all inactive NHL franchises

##### Returns

A collection of all inactive NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetInactiveTeamsAsync'></a>
### GetInactiveTeamsAsync() `method`

##### Summary

Returns all inactive NHL teams

##### Returns

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-System-Int32-'></a>
### GetLeagueAwardByIdAsync(awardId) `method`

##### Summary

Returns an NHL award by id

##### Returns

An NHL award, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| awardId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL award, Example: Ted Lindsay Award - 13 |

<a name='M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-Nhl-Api-Models-Enumerations-Award-AwardEnum-'></a>
### GetLeagueAwardByIdAsync(leagueAward) `method`

##### Summary

Returns an NHL award by the award id 
Example: [StanleyCup](#F-Nhl-Api-Models-Enumerations-Award-AwardEnum-StanleyCup 'Nhl.Api.Models.Enumerations.Award.AwardEnum.StanleyCup')

##### Returns

An NHL award, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| leagueAward | [Nhl.Api.Models.Enumerations.Award.AwardEnum](#T-Nhl-Api-Models-Enumerations-Award-AwardEnum 'Nhl.Api.Models.Enumerations.Award.AwardEnum') | The NHL league award identifier, see [AwardEnum](#T-Nhl-Api-Models-Enumerations-Award-AwardEnum 'Nhl.Api.Models.Enumerations.Award.AwardEnum') for more information on NHL awards |

<a name='M-Nhl-Api-NhlApi-GetLeagueAwardsAsync'></a>
### GetLeagueAwardsAsync() `method`

##### Summary

Returns all of the NHL awards, including the description, history, and images

##### Returns

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-System-Int32-'></a>
### GetLeagueProspectByIdAsync(prospectId) `method`

##### Summary

Returns an NHL prospect profile by their prospect id

##### Returns

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prospectId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL prospect id, Example: 86515 - Francesco Pinelli |

<a name='M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum-'></a>
### GetLeagueProspectByIdAsync(prospect) `method`

##### Summary

Returns an NHL prospect profile by their prospect id

##### Returns

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prospect | [Nhl.Api.Models.Enumerations.Prospect.ProspectEnum](#T-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum 'Nhl.Api.Models.Enumerations.Prospect.ProspectEnum') | The NHL prospect id, Example: 86515 - Francesco Pinelli, see [ProspectEnum](#T-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum 'Nhl.Api.Models.Enumerations.Prospect.ProspectEnum') for more information |

<a name='M-Nhl-Api-NhlApi-GetLeagueProspectsAsync'></a>
### GetLeagueProspectsAsync() `method`

##### Summary

Returns all the NHL league prospects The NHL prospects response provides a very large JSON payload

##### Returns

A collection of all the NHL prospects, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingTypesAsync'></a>
### GetLeagueStandingTypesAsync() `method`

##### Summary

Returns all of the NHL league standing types, this includes playoff and pre-season standings

##### Returns

A collection of all the NHL standing types, see [LeagueStandingType](#T-Nhl-Api-Models-Standing-LeagueStandingType 'Nhl.Api.Models.Standing.LeagueStandingType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsAsync(date) `method`

##### Summary

Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings

##### Returns

A collection of all the league standings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings |

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsAsync'></a>
### GetLeagueStandingsAsync() `method`

##### Summary

Returns the standings of every team in the NHL for the current date

##### Returns

A collection of all the league standings

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsByConferenceAsync'></a>
### GetLeagueStandingsByConferenceAsync() `method`

##### Summary

Returns the standings of every team in the NHL by conference for the current date

##### Returns

A collection of all the league standings by conference

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsByConferenceAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsByConferenceAsync(date) `method`

##### Summary

Returns the standings of every team in the NHL by conference for the current date, if the date is null it will provide the current NHL league standings by conference

##### Returns

A collection of all the league standings by conference for the selected date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings by conference |

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsByDivisionAsync'></a>
### GetLeagueStandingsByDivisionAsync() `method`

##### Summary

Returns the standings of every team by division in the NHL for the current date

##### Returns

A collection of all the league standings by division

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsByDivisionAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsByDivisionAsync(date) `method`

##### Summary

Returns the standings of every team by division in the NHL by date, if the date is null it will provide the current NHL league standings by division

##### Returns

A collection of all the league standings by division for the selected date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings by division |

<a name='M-Nhl-Api-NhlApi-GetLeagueTeamRosterMembersAsync'></a>
### GetLeagueTeamRosterMembersAsync() `method`

##### Summary

Returns all of the active NHL players

##### Returns

A collection of all NHL players

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueTeamRosterMembersBySeasonYearAsync-System-String-'></a>
### GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear) `method`

##### Summary

Returns all of the active NHL roster members by a season year

##### Returns

A collection of all NHL players based on the season year provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-System-Int32-'></a>
### GetLeagueVenueByIdAsync(venueId) `method`

##### Summary

Returns an NHL venue by the venue id 
 Example: 5058 - Canada Life Centre

##### Returns

An NHL venue, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| venueId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The specified id of an NHL venue, |

<a name='M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-Nhl-Api-Models-Enumerations-Venue-VenueEnum-'></a>
### GetLeagueVenueByIdAsync(venue) `method`

##### Summary

Returns an NHL venue by the venue enumeration 
 Example: [EnterpriseCenter](#F-Nhl-Api-Models-Enumerations-Venue-VenueEnum-EnterpriseCenter 'Nhl.Api.Models.Enumerations.Venue.VenueEnum.EnterpriseCenter')

##### Returns

An NHL venue, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| venue | [Nhl.Api.Models.Enumerations.Venue.VenueEnum](#T-Nhl-Api-Models-Enumerations-Venue-VenueEnum 'Nhl.Api.Models.Enumerations.Venue.VenueEnum') | The specified NHL venue, see [VenueEnum](#T-Nhl-Api-Models-Enumerations-Venue-VenueEnum 'Nhl.Api.Models.Enumerations.Venue.VenueEnum') for more information on NHL venues |

<a name='M-Nhl-Api-NhlApi-GetLeagueVenuesAsync'></a>
### GetLeagueVenuesAsync() `method`

##### Summary

Returns all of the NHL venue's, including arenas and stadiums This is not a comprehensive list of all NHL stadiums and arenas

##### Returns

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLineScoreByIdAsync-System-Int32-'></a>
### GetLineScoreByIdAsync(gameId) `method`

##### Summary

Returns the line score content for an NHL game

##### Returns

Returns information about the current score, strength of the play, time remaining, shots on goal and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlApi-GetLiveGameFeedByIdAsync-System-Int32,Nhl-Api-Models-Game-LiveGameFeedConfiguration-'></a>
### GetLiveGameFeedByIdAsync(gameId,liveGameFeedConfiguration) `method`

##### Summary

Returns the live game feed content for an NHL game

##### Returns

A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The live game feed id, Example: 2021020087 |
| liveGameFeedConfiguration | [Nhl.Api.Models.Game.LiveGameFeedConfiguration](#T-Nhl-Api-Models-Game-LiveGameFeedConfiguration 'Nhl.Api.Models.Game.LiveGameFeedConfiguration') | The NHL live game feed configuration settings for NHL live game feed updates |

<a name='M-Nhl-Api-NhlApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetOnPaceRegularSeasonPlayerStatisticsAsync(player) `method`

##### Summary

Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics

##### Returns

A collection of all the on pace expected NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL player |

<a name='M-Nhl-Api-NhlApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-System-Int32-'></a>
### GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId) `method`

##### Summary

Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics

##### Returns

A collection of all the on pace expected NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL player |

<a name='M-Nhl-Api-NhlApi-GetPlayTypesAsync'></a>
### GetPlayTypesAsync() `method`

##### Summary

Returns a collection of all the play types within the duration of an NHL game

##### Returns

A collection of distinct play types, see [PlayType](#T-Nhl-Api-Models-Game-PlayType 'Nhl.Api.Models.Game.PlayType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetPlayerByIdAsync-System-Int32-'></a>
### GetPlayerByIdAsync(playerId) `method`

##### Summary

Returns an NHL player by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 is Connor McDavid |

<a name='M-Nhl-Api-NhlApi-GetPlayerByIdAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetPlayerByIdAsync(player) `method`

##### Summary

Returns an NHL player by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetPlayerStatisticsBySeasonAsync(playerId,seasonYear) `method`

##### Summary

Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL player |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String-'></a>
### GetPlayerStatisticsBySeasonAsync(player,seasonYear) `method`

##### Summary

Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL player |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetPlayerWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum,System-String-'></a>
### GetPlayerWithTopStatisticBySeasonAsync(seasonYear,playerStatisticEnum) `method`

##### Summary

Returns the player with the top NHL player statistic based on the selected season year

##### Returns

Returns the player profile with the top player statistic in the specified NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum 'Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |
| playerStatisticEnum | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the type of NHL player statistic, see [PlayerStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum 'Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum') for more information |

<a name='M-Nhl-Api-NhlApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetPlayersByIdAsync(playerIds) `method`

##### Summary

Returns a collection of NHL players by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIds | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | A collection of NHL player identifiers, Example: 8478402 - Connor McDavid |

<a name='M-Nhl-Api-NhlApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Player-PlayerEnum}-'></a>
### GetPlayersByIdAsync(players) `method`

##### Summary

Returns a collection of NHL players by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| players | [System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum}') | A collection of NHL player identifiers, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlApi-GetPlayoffTournamentTypesAsync'></a>
### GetPlayoffTournamentTypesAsync() `method`

##### Summary

Returns a collection of all the different types of playoff tournaments in the NHL

##### Returns

A collection of tournament types, see [PlayoffTournamentType](#T-Nhl-Api-Models-Game-PlayoffTournamentType 'Nhl.Api.Models.Game.PlayoffTournamentType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetSeasonByYearAsync-System-String-'></a>
### GetSeasonByYearAsync(seasonYear) `method`

##### Summary

Returns the NHL season information based on the provided season years

##### Returns

An NHL season based on the provided season year, Example: '20172018'

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | See [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid season year arguments |

<a name='M-Nhl-Api-NhlApi-GetSeasonsAsync'></a>
### GetSeasonsAsync() `method`

##### Summary

Returns all of the NHL seasons since the inception of the league in 1917-1918

##### Returns

A collection of seasons since the inception of the NHL

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetStatisticTypesAsync'></a>
### GetStatisticTypesAsync() `method`

##### Summary

Returns all distinct types of NHL statistics types

##### Returns

A collection of all the various NHL statistics types, see [StatisticTypes](#T-Nhl-Api-Models-Statistics-StatisticTypes 'Nhl.Api.Models.Statistics.StatisticTypes') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetTeamByIdAsync-System-Int32-'></a>
### GetTeamByIdAsync(teamId) `method`

##### Summary

Returns an NHL team by the team id

##### Returns

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: Toronto Maple Leafs - 10 |

<a name='M-Nhl-Api-NhlApi-GetTeamByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamByIdAsync(team) `method`

##### Summary

Returns an NHL team by the team enumeration 
Example: [SeattleKraken](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-SeattleKraken 'Nhl.Api.Models.Enumerations.Team.TeamEnum.SeattleKraken')

##### Returns

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information on teams

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: 10 - Toronto Maple Leafs, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information on NHL teams |

<a name='M-Nhl-Api-NhlApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType-'></a>
### GetTeamLogoAsync(teamId,teamLogoType) `method`

##### Summary

Returns an the NHL team logo based a dark or light preference using the NHL team id

##### Returns

Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |
| teamLogoType | [Nhl.Api.Models.Team.TeamLogoType](#T-Nhl-Api-Models-Team-TeamLogoType 'Nhl.Api.Models.Team.TeamLogoType') | The NHL team logo image type, based on the background of light or dark |

<a name='M-Nhl-Api-NhlApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType-'></a>
### GetTeamLogoAsync(team,teamLogoType) `method`

##### Summary

Returns an the NHL team logo based a dark or light preference using the NHL team enumeration

##### Returns

Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| teamLogoType | [Nhl.Api.Models.Team.TeamLogoType](#T-Nhl-Api-Models-Team-TeamLogoType 'Nhl.Api.Models.Team.TeamLogoType') | The NHL team logo image type, based on the background of light or dark |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-'></a>
### GetTeamStatisticsByIdAsync(teamId,seasonYear) `method`

##### Summary

Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned

##### Returns

A collection of all the specified NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: Toronto Maple Leafs - 10 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, Example: 20202021 |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamStatisticsByIdAsync(team,seasonYear) `method`

##### Summary

Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned

##### Returns

A collection of all the specified NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks') |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, Example: 20202021 |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetTeamStatisticsBySeasonAsync(teamId,seasonYear) `method`

##### Summary

Returns all of the NHL team statistics for the specific NHL team identifier and season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamStatisticsBySeasonAsync(team,seasonYear) `method`

##### Summary

Returns all of the NHL team statistics for the specific NHL team identifier and season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks'), see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlApi-GetTeamsAsync'></a>
### GetTeamsAsync() `method`

##### Summary

Returns all active and inactive NHL teams

##### Returns

A collection of all NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetTeamsByIdsAsync(teamIds) `method`

##### Summary

Returns a collection of NHL team by the team id's

##### Returns

A collection of NHL team's with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamIds | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | A collection of NHL team id's, Example: 10 - Toronto Maple Leafs |

<a name='M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Team-TeamEnum}-'></a>
### GetTeamsByIdsAsync(teams) `method`

##### Summary

Returns a collection of NHL team's by the team enumeration values

##### Returns

A collection of NHL team's with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teams | [System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum}') | A collection of NHL team id's, Example: 10 - Toronto Maple Leafs, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information on NHL teams |

<a name='M-Nhl-Api-NhlApi-GetTournamentTypesAsync'></a>
### GetTournamentTypesAsync() `method`

##### Summary

Returns a collection of all the different types of tournaments in the hockey

##### Returns

A collection of tournament types, see [TournamentType](#T-Nhl-Api-Models-Game-TournamentType 'Nhl.Api.Models.Game.TournamentType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsPlayoffsActiveAsync'></a>
### IsPlayoffsActiveAsync() `method`

##### Summary

Determines whether the NHL playoff season is currently active or inactive

##### Returns

A result if the current NHL playoff season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsRegularSeasonActiveAsync'></a>
### IsRegularSeasonActiveAsync() `method`

##### Summary

Determines whether the NHL regular season is currently active or inactive

##### Returns

A result if the current NHL regular season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsSeasonActiveAsync'></a>
### IsSeasonActiveAsync() `method`

##### Summary

Determines whether the NHL season is currently active or inactive

##### Returns

A result if the current NHL season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-SearchAllActivePlayersAsync-System-String-'></a>
### SearchAllActivePlayersAsync(query) `method`

##### Summary

Returns only active NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" |

<a name='M-Nhl-Api-NhlApi-SearchAllPlayersAsync-System-String-'></a>
### SearchAllPlayersAsync(query) `method`

##### Summary

Returns any active or inactive NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" |

<a name='M-Nhl-Api-NhlApi-SearchLeagueTeamRosterMembersAsync-System-String-'></a>
### SearchLeagueTeamRosterMembersAsync(query) `method`

##### Summary

Returns all of the active rostered NHL players based on the search query provided

##### Returns

A collection of all rostered and active NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" |

<a name='T-Nhl-Api-NhlGameApi'></a>
## NhlGameApi `type`

##### Namespace

Nhl.Api

##### Summary

NHL Game API

<a name='M-Nhl-Api-NhlGameApi-GetBoxScoreByIdAsync-System-Int32-'></a>
### GetBoxScoreByIdAsync(gameId) `method`

##### Summary

Returns the box score content for an NHL game

##### Returns

Returns information about the current score, penalties, players, team statistics and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleAsync'></a>
### GetGameScheduleAsync() `method`

##### Summary

Return's today's the NHL game schedule and it will provide today's current NHL game schedule

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleByDateAsync-System-Nullable{System-DateTime}-'></a>
### GetGameScheduleByDateAsync(date) `method`

##### Summary

Return's the NHL game schedule based on the provided [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime'). If the date is null, it will provide today's current NHL game schedule

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The requested date for the NHL game schedule |

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleByDateAsync-System-Int32,System-Int32,System-Int32-'></a>
### GetGameScheduleByDateAsync(year,month,day) `method`

##### Summary

Return's the NHL game schedule based on the provided year, month and day

##### Returns

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more infGetGameScheduleByDateAsyncormation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested year for the NHL game schedule |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested month for the NHL game schedule |
| day | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The requested day for the NHL game schedule |

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleForTeamByDateAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTime,System-DateTime-'></a>
### GetGameScheduleForTeamByDateAsync(team,startDate,endDate) `method`

##### Summary

Return's the NHL game schedule for the specified team based on the provided start date and end date

##### Returns

Returns all of the NHL team's game schedules based on the selected start and end dates

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks') |
| startDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The starting date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 2017-01-01 |
| endDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The ending date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 1988-06-01 |

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleForTeamByDateAsync-System-Int32,System-DateTime,System-DateTime-'></a>
### GetGameScheduleForTeamByDateAsync(teamId,startDate,endDate) `method`

##### Summary

Return's the NHL game schedule for the specified team based on the provided start date and end date

##### Returns

Returns all of the NHL team's game schedules based on the selected start and end dates

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: 1 |
| startDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The starting date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 2017-01-01 |
| endDate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The ending date for the NHL team game schedule, see [LeagueSeasonDates](#T-Nhl-Api-Models-Season-LeagueSeasonDates 'Nhl.Api.Models.Season.LeagueSeasonDates') for start dates of NHL seasons, Example: 1988-06-01 |

<a name='M-Nhl-Api-NhlGameApi-GetGameScheduleBySeasonAsync-System-String,System-Boolean-'></a>
### GetGameScheduleBySeasonAsync(seasonYear,includePlayoffGames) `method`

##### Summary

Return's the entire collection of NHL game schedules for the specified season

##### Returns

Returns all of the NHL team's game schedules based on the selected NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, Example: 19992000, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |
| includePlayoffGames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Includes all of the NHL playoff games, default value is false |

<a name='M-Nhl-Api-NhlGameApi-GetGameStatusesAsync'></a>
### GetGameStatusesAsync() `method`

##### Summary

Returns all of the valid NHL game statuses of an NHL game

##### Returns

A collection of NHL game statues, see [GameStatus](#T-Nhl-Api-Models-Game-GameStatus 'Nhl.Api.Models.Game.GameStatus') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetGameTypesAsync'></a>
### GetGameTypesAsync() `method`

##### Summary

Returns all of the NHL game types within a season and within special events

##### Returns

A collection of NHL and other sporting event game types, see [GameType](#T-Nhl-Api-Models-Game-GameType 'Nhl.Api.Models.Game.GameType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetLineScoreByIdAsync-System-Int32-'></a>
### GetLineScoreByIdAsync(gameId) `method`

##### Summary

Returns the line score content for an NHL game

##### Returns

Returns information about the current score, strength of the play, time remaining, shots on goal and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlGameApi-GetLiveGameFeedByIdAsync-System-Int32,Nhl-Api-Models-Game-LiveGameFeedConfiguration-'></a>
### GetLiveGameFeedByIdAsync(gameId,liveGameFeedConfiguration) `method`

##### Summary

Returns the live game feed content for an NHL game

##### Returns

A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The live game feed id, Example: 2021020087 |
| liveGameFeedConfiguration | [Nhl.Api.Models.Game.LiveGameFeedConfiguration](#T-Nhl-Api-Models-Game-LiveGameFeedConfiguration 'Nhl.Api.Models.Game.LiveGameFeedConfiguration') | The NHL live game feed event configuration settings for NHL live game feed updates |

<a name='M-Nhl-Api-NhlGameApi-GetPlayTypesAsync'></a>
### GetPlayTypesAsync() `method`

##### Summary

Returns a collection of all the play types within the duration of an NHL game

##### Returns

A collection of distinct play types, see [PlayType](#T-Nhl-Api-Models-Game-PlayType 'Nhl.Api.Models.Game.PlayType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetPlayoffTournamentTypesAsync'></a>
### GetPlayoffTournamentTypesAsync() `method`

##### Summary

Returns a collection of all the different types of playoff tournaments in the NHL

##### Returns

A collection of tournament types, see [PlayoffTournamentType](#T-Nhl-Api-Models-Game-PlayoffTournamentType 'Nhl.Api.Models.Game.PlayoffTournamentType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetTournamentTypesAsync'></a>
### GetTournamentTypesAsync() `method`

##### Summary

Returns a collection of all the different types of tournaments in the hockey

##### Returns

A collection of tournament types, see [TournamentType](#T-Nhl-Api-Models-Game-TournamentType 'Nhl.Api.Models.Game.TournamentType') for more information

##### Parameters

This method has no parameters.

<a name='T-Nhl-Api-NhlLeagueApi'></a>
## NhlLeagueApi `type`

##### Namespace

Nhl.Api

##### Summary

NHL League API

<a name='M-Nhl-Api-NhlLeagueApi-GetActiveFranchisesAsync'></a>
### GetActiveFranchisesAsync() `method`

##### Summary

Returns all active NHL franchises

##### Returns

A collection of all active NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetActiveTeamsAsync'></a>
### GetActiveTeamsAsync() `method`

##### Summary

Returns all active NHL teams

##### Returns

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetConferenceByIdAsync-System-Int32-'></a>
### GetConferenceByIdAsync(conferenceId) `method`

##### Summary

Returns all of the NHL conferences

##### Returns

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conferenceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL conference id, Example: Eastern Conference is the number 6 |

<a name='M-Nhl-Api-NhlLeagueApi-GetConferenceByIdAsync-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum-'></a>
### GetConferenceByIdAsync(conference) `method`

##### Summary

Returns the NHL conference by the conference enumeration 
Example: [Eastern](#F-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum-Eastern 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum.Eastern')

##### Returns

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conference | [Nhl.Api.Models.Enumerations.Conference.ConferenceEnum](#T-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum') | The NHL conference id, Example: 6 - Eastern Conference, see [ConferenceEnum](#T-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum 'Nhl.Api.Models.Enumerations.Conference.ConferenceEnum') for more information on NHL conferences |

<a name='M-Nhl-Api-NhlLeagueApi-GetConferencesAsync'></a>
### GetConferencesAsync() `method`

##### Summary

Returns all of the NHL conferences

##### Returns

A collection of all the NHL conferences, see [Conference](#T-Nhl-Api-Models-Conference-Conference 'Nhl.Api.Models.Conference.Conference') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetCurrentSeasonAsync'></a>
### GetCurrentSeasonAsync() `method`

##### Summary

Return the current and most recent NHL season

##### Returns

The most recent NHL season

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetDivisionByIdAsync-Nhl-Api-Models-Enumerations-Division-DivisionEnum-'></a>
### GetDivisionByIdAsync(division) `method`

##### Summary

Returns an NHL division by the division enumeration 
Example: [Atlantic](#F-Nhl-Api-Models-Enumerations-Division-DivisionEnum-Atlantic 'Nhl.Api.Models.Enumerations.Division.DivisionEnum.Atlantic')

##### Returns

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| division | [Nhl.Api.Models.Enumerations.Division.DivisionEnum](#T-Nhl-Api-Models-Enumerations-Division-DivisionEnum 'Nhl.Api.Models.Enumerations.Division.DivisionEnum') | The NHL division id, Example: 17 - Atlantic division, see [DivisionEnum](#T-Nhl-Api-Models-Enumerations-Division-DivisionEnum 'Nhl.Api.Models.Enumerations.Division.DivisionEnum') for more information on NHL divisions |

<a name='M-Nhl-Api-NhlLeagueApi-GetDivisionByIdAsync-System-Int32-'></a>
### GetDivisionByIdAsync(divisionId) `method`

##### Summary

Returns an NHL division by the division id

##### Returns

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| divisionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL division id, Example: Atlantic division is the number 17 |

<a name='M-Nhl-Api-NhlLeagueApi-GetDivisionsAsync'></a>
### GetDivisionsAsync() `method`

##### Summary

Returns all of the NHL divisions

##### Returns

A collection of all the NHL divisions, see [Division](#T-Nhl-Api-Models-Division-Division 'Nhl.Api.Models.Division.Division') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetDraftByYearAsync-System-String-'></a>
### GetDraftByYearAsync(year) `method`

##### Summary

Returns the NHL league draft based on a specific year based on the 4 character draft year, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear 'Nhl.Api.Models.Draft.DraftYear') for more information. Some responses provide very large JSON payloads

##### Returns

The NHL league draft, which includes draft rounds, player information and more, see [LeagueDraft](#T-Nhl-Api-Models-Draft-LeagueDraft 'Nhl.Api.Models.Draft.LeagueDraft') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The specified year of the NHL draft, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear 'Nhl.Api.Models.Draft.DraftYear') for all NHL draft years |

<a name='M-Nhl-Api-NhlLeagueApi-GetEventTypesAsync'></a>
### GetEventTypesAsync() `method`

##### Summary

Return's all the event types within the NHL

##### Returns

A collection of event types within the NHL, see [EventType](#T-Nhl-Api-Models-Event-EventType 'Nhl.Api.Models.Event.EventType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetFranchiseByIdAsync-System-Int32-'></a>
### GetFranchiseByIdAsync(franchiseId) `method`

##### Summary

Returns an NHL franchise by the franchise id

##### Returns

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| franchiseId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL franchise id, Example: Montréal Canadiens - 1 |

<a name='M-Nhl-Api-NhlLeagueApi-GetFranchiseByIdAsync-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum-'></a>
### GetFranchiseByIdAsync(franchise) `method`

##### Summary

Returns an NHL franchise by the franchise id 
Example: [LosAngelesKings](#F-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum-LosAngelesKings 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum.LosAngelesKings')

##### Returns

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| franchise | [Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum](#T-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum') | The NHL team id, Example: 10 - Toronto Maple Leafs, see [FranchiseEnum](#T-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum 'Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum') for more information on NHL franchises |

<a name='M-Nhl-Api-NhlLeagueApi-GetFranchisesAsync'></a>
### GetFranchisesAsync() `method`

##### Summary

Returns all NHL franchises, including information such as team name, location and more

##### Returns

A collection of all NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetInactiveFranchisesAsync'></a>
### GetInactiveFranchisesAsync() `method`

##### Summary

Returns all inactive NHL franchises

##### Returns

A collection of all inactive NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise 'Nhl.Api.Models.Franchise.Franchise') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetInactiveTeamsAsync'></a>
### GetInactiveTeamsAsync() `method`

##### Summary

Returns all inactive NHL teams

##### Returns

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueAwardByIdAsync-System-Int32-'></a>
### GetLeagueAwardByIdAsync(awardId) `method`

##### Summary

Returns an NHL award by id

##### Returns

An NHL award, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| awardId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL award, Example: Ted Lindsay Award - 13 |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueAwardByIdAsync-Nhl-Api-Models-Enumerations-Award-AwardEnum-'></a>
### GetLeagueAwardByIdAsync(leagueAward) `method`

##### Summary

Returns an NHL award by the award id 
Example: [StanleyCup](#F-Nhl-Api-Models-Enumerations-Award-AwardEnum-StanleyCup 'Nhl.Api.Models.Enumerations.Award.AwardEnum.StanleyCup')

##### Returns

An NHL award, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| leagueAward | [Nhl.Api.Models.Enumerations.Award.AwardEnum](#T-Nhl-Api-Models-Enumerations-Award-AwardEnum 'Nhl.Api.Models.Enumerations.Award.AwardEnum') | The NHL league award identifier, see [AwardEnum](#T-Nhl-Api-Models-Enumerations-Award-AwardEnum 'Nhl.Api.Models.Enumerations.Award.AwardEnum') for more information on NHL awards |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueAwardsAsync'></a>
### GetLeagueAwardsAsync() `method`

##### Summary

Returns all of the NHL awards, including the description, history, and images

##### Returns

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award 'Nhl.Api.Models.Award.Award') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingTypesAsync'></a>
### GetLeagueStandingTypesAsync() `method`

##### Summary

Returns all of the NHL league standing types, this includes playoff and pre-season standings

##### Returns

A collection of all the NHL standing types, see [LeagueStandingType](#T-Nhl-Api-Models-Standing-LeagueStandingType 'Nhl.Api.Models.Standing.LeagueStandingType') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsAsync(date) `method`

##### Summary

Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings

##### Returns

A collection of all the league standings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsAsync'></a>
### GetLeagueStandingsAsync() `method`

##### Summary

Returns the standings of every team in the NHL for the current date

##### Returns

A collection of all the league standings

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByConferenceAsync'></a>
### GetLeagueStandingsByConferenceAsync() `method`

##### Summary

Returns the standings of every team in the NHL by conference for the current date

##### Returns

A collection of all the league standings by conference

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByConferenceAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsByConferenceAsync(date) `method`

##### Summary

Returns the standings of every team in the NHL by conference for the current date, if the date is null it will provide the current NHL league standings by conference

##### Returns

A collection of all the league standings by conference for the selected date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings by conference |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDivisionAsync'></a>
### GetLeagueStandingsByDivisionAsync() `method`

##### Summary

Returns the standings of every team by division in the NHL for the current date

##### Returns

A collection of all the league standings by division

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDivisionAsync-System-Nullable{System-DateTime}-'></a>
### GetLeagueStandingsByDivisionAsync(date) `method`

##### Summary

Returns the standings of every team by division in the NHL by date, if the date is null it will provide the current NHL league standings by division

##### Returns

A collection of all the league standings by division for the selected date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings by division |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueVenueByIdAsync-Nhl-Api-Models-Enumerations-Venue-VenueEnum-'></a>
### GetLeagueVenueByIdAsync(venue) `method`

##### Summary

Returns an NHL venue by the venue enumeration 
 Example: [EnterpriseCenter](#F-Nhl-Api-Models-Enumerations-Venue-VenueEnum-EnterpriseCenter 'Nhl.Api.Models.Enumerations.Venue.VenueEnum.EnterpriseCenter')

##### Returns

An NHL venue, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| venue | [Nhl.Api.Models.Enumerations.Venue.VenueEnum](#T-Nhl-Api-Models-Enumerations-Venue-VenueEnum 'Nhl.Api.Models.Enumerations.Venue.VenueEnum') | The specified NHL venue, see [VenueEnum](#T-Nhl-Api-Models-Enumerations-Venue-VenueEnum 'Nhl.Api.Models.Enumerations.Venue.VenueEnum') for more information on NHL venues |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueVenueByIdAsync-System-Int32-'></a>
### GetLeagueVenueByIdAsync(venueId) `method`

##### Summary

Returns an NHL venue by the venue id 
 Example: 5058 - Canada Life Centre

##### Returns

An NHL venue, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| venueId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The specified id of an NHL venue, |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueVenuesAsync'></a>
### GetLeagueVenuesAsync() `method`

##### Summary

Returns all of the NHL venue's, including arenas and stadiums This is not a comprehensive list of all NHL stadiums and arenas

##### Returns

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue 'Nhl.Api.Models.Venue.LeagueVenue') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetSeasonByYearAsync-System-String-'></a>
### GetSeasonByYearAsync(seasonYear) `method`

##### Summary

Returns the NHL season information based on the provided season years

##### Returns

An NHL season based on the provided season year, Example: '20172018'

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | See [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid season year arguments |

<a name='M-Nhl-Api-NhlLeagueApi-GetSeasonsAsync'></a>
### GetSeasonsAsync() `method`

##### Summary

Returns all of the NHL seasons since the inception of the league in 1917-1918

##### Returns

A collection of seasons since the inception of the NHL

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamByIdAsync-System-Int32-'></a>
### GetTeamByIdAsync(teamId) `method`

##### Summary

Returns an NHL team by the team id

##### Returns

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: Toronto Maple Leafs - 10 |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamByIdAsync(team) `method`

##### Summary

Returns an NHL team by the team enumeration 
Example: [SeattleKraken](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-SeattleKraken 'Nhl.Api.Models.Enumerations.Team.TeamEnum.SeattleKraken')

##### Returns

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information on teams

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: 10 - Toronto Maple Leafs, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information on NHL teams |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType-'></a>
### GetTeamLogoAsync(team,teamLogoType) `method`

##### Summary

Returns an the NHL team logo based a dark or light preference using the NHL team enumeration

##### Returns

Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| teamLogoType | [Nhl.Api.Models.Team.TeamLogoType](#T-Nhl-Api-Models-Team-TeamLogoType 'Nhl.Api.Models.Team.TeamLogoType') | The NHL team logo image type, based on the background of light or dark |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType-'></a>
### GetTeamLogoAsync(teamId,teamLogoType) `method`

##### Summary

Returns an the NHL team logo based a dark or light preference using the NHL team id

##### Returns

Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |
| teamLogoType | [Nhl.Api.Models.Team.TeamLogoType](#T-Nhl-Api-Models-Team-TeamLogoType 'Nhl.Api.Models.Team.TeamLogoType') | The NHL team logo image type, based on the background of light or dark |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamsAsync'></a>
### GetTeamsAsync() `method`

##### Summary

Returns all active and inactive NHL teams

##### Returns

A collection of all NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetTeamsByIdsAsync(teamIds) `method`

##### Summary

Returns a collection of NHL team by the team id's

##### Returns

A collection of NHL team's with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamIds | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | A collection of NHL team id's, Example: 10 - Toronto Maple Leafs |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Team-TeamEnum}-'></a>
### GetTeamsByIdsAsync(teams) `method`

##### Summary

Returns a collection of NHL team's by the team enumeration values

##### Returns

A collection of NHL team's with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team 'Nhl.Api.Models.Team.Team') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teams | [System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum}') | A collection of NHL team id's, Example: 10 - Toronto Maple Leafs, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information on NHL teams |

<a name='M-Nhl-Api-NhlLeagueApi-IsPlayoffsActiveAsync'></a>
### IsPlayoffsActiveAsync() `method`

##### Summary

Determines whether the NHL playoff season is currently active or inactive

##### Returns

A result if the current NHL playoff season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-IsRegularSeasonActiveAsync'></a>
### IsRegularSeasonActiveAsync() `method`

##### Summary

Determines whether the NHL regular season is currently active or inactive

##### Returns

A result if the current NHL regular season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-IsSeasonActiveAsync'></a>
### IsSeasonActiveAsync() `method`

##### Summary

Determines whether the NHL season is currently active or inactive

##### Returns

A result if the current NHL season is active (true) or inactive (false)

##### Parameters

This method has no parameters.

<a name='T-Nhl-Api-NhlPlayerApi'></a>
## NhlPlayerApi `type`

##### Namespace

Nhl.Api

##### Summary

NHL Player API

<a name='M-Nhl-Api-NhlPlayerApi-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes and releases all unneeded resources for the NHL player api

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NotImplementedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NotImplementedException 'System.NotImplementedException') |  |

<a name='M-Nhl-Api-NhlPlayerApi-GetAllPlayersAsync'></a>
### GetAllPlayersAsync() `method`

##### Summary

Returns every single NHL player to ever play

##### Returns

Returns every single NHL player since the league inception

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlPlayerApi-GetLeagueProspectByIdAsync-System-Int32-'></a>
### GetLeagueProspectByIdAsync(prospectId) `method`

##### Summary

Returns an NHL prospect profile by their prospect id

##### Returns

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prospectId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL prospect id, Example: 86515 - Francesco Pinelli |

<a name='M-Nhl-Api-NhlPlayerApi-GetLeagueProspectByIdAsync-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum-'></a>
### GetLeagueProspectByIdAsync(prospect) `method`

##### Summary

Returns an NHL prospect profile by their prospect id

##### Returns

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prospect | [Nhl.Api.Models.Enumerations.Prospect.ProspectEnum](#T-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum 'Nhl.Api.Models.Enumerations.Prospect.ProspectEnum') | The NHL prospect id, Example: 86515 - Francesco Pinelli, see [ProspectEnum](#T-Nhl-Api-Models-Enumerations-Prospect-ProspectEnum 'Nhl.Api.Models.Enumerations.Prospect.ProspectEnum') for more information |

<a name='M-Nhl-Api-NhlPlayerApi-GetLeagueProspectsAsync'></a>
### GetLeagueProspectsAsync() `method`

##### Summary

Returns all the NHL league prospects The NHL prospects response provides a very large JSON payload

##### Returns

A collection of all the NHL prospects, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile 'Nhl.Api.Models.Player.ProspectProfile') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlPlayerApi-GetLeagueTeamRosterMembersAsync'></a>
### GetLeagueTeamRosterMembersAsync() `method`

##### Summary

Returns all of the active NHL players

##### Returns

A collection of all NHL players

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlPlayerApi-GetLeagueTeamRosterMembersBySeasonYearAsync-System-String-'></a>
### GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear) `method`

##### Summary

Returns all of the active NHL roster members by a season year

##### Returns

A collection of all NHL players based on the season year provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerByIdAsync-System-Int32-'></a>
### GetPlayerByIdAsync(playerId) `method`

##### Summary

Returns an NHL player by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 is Connor McDavid |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerByIdAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetPlayerByIdAsync(player) `method`

##### Summary

Returns an NHL player by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{System-Int32}-'></a>
### GetPlayersByIdAsync(playerIds) `method`

##### Summary

Returns a collection of NHL players by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIds | [System.Collections.Generic.IEnumerable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Int32}') | A collection of NHL player identifiers, Example: 8478402 - Connor McDavid |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayersByIdAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Player-PlayerEnum}-'></a>
### GetPlayersByIdAsync(players) `method`

##### Summary

Returns a collection of NHL players by their player id, includes information such as age, weight, position and more

##### Returns

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player 'Nhl.Api.Models.Player.Player') for more information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| players | [System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Player.PlayerEnum}') | A collection of NHL player identifiers, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlPlayerApi-SearchAllActivePlayersAsync-System-String-'></a>
### SearchAllActivePlayersAsync(query) `method`

##### Summary

Returns only active NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" |

<a name='M-Nhl-Api-NhlPlayerApi-SearchAllPlayersAsync-System-String-'></a>
### SearchAllPlayersAsync(query) `method`

##### Summary

Returns any active or inactive NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" |

<a name='M-Nhl-Api-NhlPlayerApi-SearchLeagueTeamRosterMembersAsync-System-String-'></a>
### SearchLeagueTeamRosterMembersAsync(query) `method`

##### Summary

Returns all of the active rostered NHL players based on the search query provided

##### Returns

A collection of all rostered and active NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" |

<a name='T-Nhl-Api-NhlStatisticsApi'></a>
## NhlStatisticsApi `type`

##### Namespace

Nhl.Api

##### Summary

NHL Statistics API

<a name='M-Nhl-Api-NhlStatisticsApi-GetAllTeamsStatisticsBySeasonAsync-System-String-'></a>
### GetAllTeamsStatisticsBySeasonAsync(seasonYear) `method`

##### Summary

Returns all of the NHL team's statistics for the specific NHL season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the all the NHL statistics, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetGoalieStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetGoalieStatisticsBySeasonAsync(playerId,seasonYear) `method`

##### Summary

Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL goalie statistics per season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL goalie |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetGoalieStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String-'></a>
### GetGoalieStatisticsBySeasonAsync(player,seasonYear) `method`

##### Summary

Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL goalie statistics per season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL goalie |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetGoalieWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum,System-String-'></a>
### GetGoalieWithTopStatisticBySeasonAsync(goalieStatisticEnum,seasonYear) `method`

##### Summary

Returns the goalie with the top NHL goalie statistic based on the selected season year

##### Returns

Returns the goalie profile with the top player statistic in the specified NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| goalieStatisticEnum | [Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum 'Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum') | The argument for the type of NHL goalie statistic, see [GoalieStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-GoalieStatisticEnum 'Nhl.Api.Models.Enumerations.Player.GoalieStatisticEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetOnPaceRegularSeasonPlayerStatisticsAsync(player) `method`

##### Summary

Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics

##### Returns

A collection of all the on pace expected NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL player |

<a name='M-Nhl-Api-NhlStatisticsApi-GetOnPaceRegularSeasonPlayerStatisticsAsync-System-Int32-'></a>
### GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId) `method`

##### Summary

Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics

##### Returns

A collection of all the on pace expected NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL player |

<a name='M-Nhl-Api-NhlStatisticsApi-GetPlayerStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetPlayerStatisticsBySeasonAsync(playerId,seasonYear) `method`

##### Summary

Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier for the NHL player |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetPlayerStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String-'></a>
### GetPlayerStatisticsBySeasonAsync(player,seasonYear) `method`

##### Summary

Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data

##### Returns

A collection of all the in-depth NHL player statistics by type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | The identifier for the NHL player |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetPlayerWithTopStatisticBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum,System-String-'></a>
### GetPlayerWithTopStatisticBySeasonAsync(seasonYear,playerStatisticEnum) `method`

##### Summary

Returns the player with the top NHL player statistic based on the selected season year

##### Returns

Returns the player profile with the top player statistic in the specified NHL season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum 'Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum') | The argument for the NHL season of the play, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |
| playerStatisticEnum | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The argument for the type of NHL player statistic, see [PlayerStatisticEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerStatisticEnum 'Nhl.Api.Models.Enumerations.Player.PlayerStatisticEnum') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetStatisticTypesAsync'></a>
### GetStatisticTypesAsync() `method`

##### Summary

Returns all distinct types of NHL statistics types

##### Returns

A collection of all the various NHL statistics types, see [StatisticTypes](#T-Nhl-Api-Models-Statistics-StatisticTypes 'Nhl.Api.Models.Statistics.StatisticTypes') for more information

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-'></a>
### GetTeamStatisticsByIdAsync(teamId,seasonYear) `method`

##### Summary

Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned

##### Returns

A collection of all the specified NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team id, Example: Toronto Maple Leafs - 10 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, Example: 20202021 |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamStatisticsByIdAsync(team,seasonYear) `method`

##### Summary

Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned

##### Returns

A collection of all the specified NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks') |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, Example: 20202021 |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-System-Int32,System-String-'></a>
### GetTeamStatisticsBySeasonAsync(teamId,seasonYear) `method`

##### Summary

Returns all of the NHL team statistics for the specific NHL team identifier and season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamStatisticsBySeasonAsync(team,seasonYear) `method`

##### Summary

Returns all of the NHL team statistics for the specific NHL team identifier and season

##### Returns

A collection of NHL team statistics for the specified season

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team id, Example: [AnaheimDucks](#F-Nhl-Api-Models-Enumerations-Team-TeamEnum-AnaheimDucks 'Nhl.Api.Models.Enumerations.Team.TeamEnum.AnaheimDucks'), see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A season year for the entire NHL roster, Example: 19971998, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information |

## Bugs 🐛
If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

## Feature Backlog 📈
Here are some of the future items I would like to add and are currently in the backlog:

- [x] Player Search within the NHL league
- [x] Add additional API functionality for ease of searching for various NHL entities
- [x] Add NHL player enum dynamically generated by T4 runtime templates
- [x] Live Game Feed for Live Games
- [ ] Content and Media for Games

## Notable Mentions 🙏
Thank you to all the people in the hockey community, especially <a href="https://gitlab.com/dword4" target="_blank">Drew Hynes</a> to contributed to documenting the <a href="https://statsapi.web.nhl.com/api/v1" target="_blank">NHL Stats API</a>. Without all of their help, guidance and knowledge none of this would be possible.
