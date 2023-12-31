[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/master-build.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/master-build.yml)
[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/develop-build.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/develop-build.yml)
[![Code Analysis](https://github.com/Afischbacher/Nhl.Api/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/codeql-analysis.yml)
[![NuGet](https://img.shields.io/nuget/v/Nhl.Api)](https://www.nuget.org/packages/Nhl.Api)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Nhl.Api.svg)](https://www.nuget.org/packages/Nhl.Api/)
[![Issues](https://img.shields.io/github/issues/Afischbacher/Nhl.Api.svg)](https://github.com/Afischbacher/Nhl.Api/issues)
[![License](https://img.shields.io/github/license/Afischbacher/Nhl.Api)](https://github.com/Afischbacher/Nhl.Api/blob/master/LICENSE)
[![codecov](https://codecov.io/github/Afischbacher/Nhl.Api/branch/master/graph/badge.svg?token=3TBEBCZJJ5)](https://codecov.io/github/Afischbacher/Nhl.Api)
# The Official Unofficial .NET NHL API 🏒
A modern C# .NET library for the NHL API providing various NHL information about players, games, teams, conferences, divisions, statistics and more


<div align="center">
    <img src="https://user-images.githubusercontent.com/15982357/151871970-87419a98-69f1-47c3-9a82-f15c48e30c5f.png" alt="nhl-api-logo" height="350" />
</div>

## Table of Contents 📚
- Installation 💭 <a href="#installing-nhl-api">Installing Nhl.Api</a>
- Implementation 🚀 <a href="#implementation">Implementation</a>
- Documentation 📖 <a href="#documentation">Documentation</a>
- Contents 📋 <a href="#contents">Contents</a>
- Bugs 🐛 <a href="#bugs">Bugs</a>
- Feature Backlog 📈 <a href="#feature-backlog">Feature Backlog</a>
- Notable Mentions 🙏 <a href="#notable-mentions">Notable Mentions</a>

## Installing Nhl.Api 💭 <a name="installing-nhl-api"></a>
You should install Nhl.Api with NuGet:
```
Install-Package Nhl.Api
```
Or via the .NET Core command line interface:
```
dotnet add package Nhl.Api
```
Either commands, from Package Manager Console or .NET Core CLI, will download and install all required dependencies.

## Implementation 🚀 <a name="implementation"></a>
If you are using any type of a inversion of control or dependency injection library such as the built in library within .NET Core, Unity, or AutoFac. It's very simple to implement, or you can create an instance of the `NhlApi` class and use the API as you would like. 

If you are using the built-in .NET Core dependency injection library, there is a NuGet package to easily add the Nhl.Api to your .NET application, <a href="https://github.com/Afischbacher/Nhl.Api.Extensions.Microsoft.DependencyInjection">Nhl.Api.Extensions.Microsoft.DependencyInjection</a> this extension, it's highly recommended.

### Nhl.Api.Extensions.Microsoft.DependencyInjection
`builder.Services.AddNhlApi();`

### .NET
`builder.Services.AddSingleton<INhlApi, NhlApi>();`

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

## Documentation 📖 <a name="documentation"></a>
Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.

### Nhl Player Api
#### .NET
`builder.Services.AddSingleton<INhlPlayerApi, NhlPlayerApi>();` <br/>
#### Unity
`container.RegisterType<INhlPlayerApi, NhlPlayerApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlPlayerApi>().As<INhlPlayerApi>();`<br/>
#### Simple Object Instantiation
`var nhlPlayerApi = new NhlPlayerApi();`<br/>

### Nhl Game Api
#### .NET
`builder.Services.AddSingleton<INhlGameApi, NhlGameApi>();`<br/>
#### Unity
`container.RegisterType<INhlGameApi, NhlGameApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlGameApi>().As<INhlGameApi>();`<br/>
#### Simple Object Instantiation
`var nhlGameApi = new NhlGameApi();`<br/>

### Nhl Statistics Api
#### .NET
`builder.Services.AddSingleton<INhlStatisticsApi, NhlStatisticsApi>();`<br/>
#### Unity
`container.RegisterType<INhlStatisticsApi, NhlStatisticsApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlStatisticsApi>().As<INhlStatisticsApi>();`<br/>
#### Simple Object Instantiation
`var nhlStatisticsApi = new NhlStatisticsApi();`<br/>

### Nhl League Api
#### .NET
`builder.Services.AddSingleton<INhlLeagueApi, NhlLeagueApi>();`<br/>
#### Unity
`container.RegisterType<INhlLeagueApi, NhlLeagueApi>();`<br/>
#### AutoFac
`builder.RegisterType<NhlLeagueApi>().As<INhlLeagueApi>();`<br/>
#### Simple Object Instantiation
`var nhlLeagueApi = new NhlLeagueApi();`<br/>

## Bugs 🐛 <a name="bugs"></a>
If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

## Feature Backlog 📈 <a name="feature-backlog"></a>
Currently there are no features in the backlog, but if you have any suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

## Notable Mentions 🙏 <a name="notable-mentions"></a>
Thank you to all the people in the hockey community, especially 
- <a target="_blank" href="https://www.nhl.com/">Drew Hynes</a> for providing the leading guidance for the all of the NHL stat heads for having the new API documented for usage
- <a target="_blank" href="https://www.zacharymaludzinski.com/">Zachary Maludzinski</a> to contributed to documenting the <a href="https://api-web.nhle.com/api/v1" target="_blank">NHL Web API</a>. Without all this help, and documentation one of this would be possible.
- <a target="_blank" href="https://www.nhl.com/">NHL</a> for providing the API for the community to use

### Contents <a name="contents"></a>

- [NhlApi](#T-Nhl-Api-NhlApi 'Nhl.Api.NhlApi')
  - [#ctor()](#M-Nhl-Api-NhlApi-#ctor 'Nhl.Api.NhlApi.#ctor')
  - [Dispose()](#M-Nhl-Api-NhlApi-Dispose 'Nhl.Api.NhlApi.Dispose')
  - [DisposeAsync()](#M-Nhl-Api-NhlApi-DisposeAsync 'Nhl.Api.NhlApi.DisposeAsync')
  - [GetAllRosterSeasonsByTeamAsync(teamId)](#M-Nhl-Api-NhlApi-GetAllRosterSeasonsByTeamAsync-System-Int32- 'Nhl.Api.NhlApi.GetAllRosterSeasonsByTeamAsync(System.Int32)')
  - [GetAllRosterSeasonsByTeamAsync(team)](#M-Nhl-Api-NhlApi-GetAllRosterSeasonsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetAllRosterSeasonsByTeamAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetAllSeasonsAsync()](#M-Nhl-Api-NhlApi-GetAllSeasonsAsync 'Nhl.Api.NhlApi.GetAllSeasonsAsync')
  - [GetCurrentTeamScoreboardAsync(teamId)](#M-Nhl-Api-NhlApi-GetCurrentTeamScoreboardAsync-System-Int32- 'Nhl.Api.NhlApi.GetCurrentTeamScoreboardAsync(System.Int32)')
  - [GetCurrentTeamScoreboardAsync(team)](#M-Nhl-Api-NhlApi-GetCurrentTeamScoreboardAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetCurrentTeamScoreboardAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetGameCenterBoxScoreByGameIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetGameCenterBoxScoreByGameIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetGameCenterBoxScoreByGameIdAsync(System.Int32)')
  - [GetGameCenterLandingByGameIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetGameCenterLandingByGameIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetGameCenterLandingByGameIdAsync(System.Int32)')
  - [GetGameCenterPlayByPlayByGameIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetGameCenterPlayByPlayByGameIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetGameCenterPlayByPlayByGameIdAsync(System.Int32)')
  - [GetGameMetadataByGameIdAsync(gameId)](#M-Nhl-Api-NhlApi-GetGameMetadataByGameIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetGameMetadataByGameIdAsync(System.Int32)')
  - [GetGameScoreboardAsync()](#M-Nhl-Api-NhlApi-GetGameScoreboardAsync 'Nhl.Api.NhlApi.GetGameScoreboardAsync')
  - [GetGameScoresByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetGameScoresByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetGameScoresByDateTimeAsync(System.DateTimeOffset)')
  - [GetGoalieInformationAsync(playerId)](#M-Nhl-Api-NhlApi-GetGoalieInformationAsync-System-Int32- 'Nhl.Api.NhlApi.GetGoalieInformationAsync(System.Int32)')
  - [GetGoalieInformationAsync(player)](#M-Nhl-Api-NhlApi-GetGoalieInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlApi.GetGoalieInformationAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetGoalieStatsisticsLeadersAsync(goalieStatisticsType,seasonYear,gameType,limit)](#M-Nhl-Api-NhlApi-GetGoalieStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32- 'Nhl.Api.NhlApi.GetGoalieStatsisticsLeadersAsync(Nhl.Api.Enumerations.Statistic.GoalieStatisticsType,Nhl.Api.Enumerations.Game.GameType,System.String,System.Int32)')
  - [GetLeagueGameWeekScheduleByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetLeagueGameWeekScheduleByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetLeagueGameWeekScheduleByDateTimeAsync(System.DateTimeOffset)')
  - [GetLeagueMetadataInformation(playerIds,teamIds)](#M-Nhl-Api-NhlApi-GetLeagueMetadataInformation-System-Collections-Generic-List{System-Int32},System-Collections-Generic-List{System-String}- 'Nhl.Api.NhlApi.GetLeagueMetadataInformation(System.Collections.Generic.List{System.Int32},System.Collections.Generic.List{System.String})')
  - [GetLeagueMetadataInformation(players,teams)](#M-Nhl-Api-NhlApi-GetLeagueMetadataInformation-System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Player-PlayerEnum},System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Team-TeamEnum}- 'Nhl.Api.NhlApi.GetLeagueMetadataInformation(System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum},System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum})')
  - [GetLeagueScheduleCalendarAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetLeagueScheduleCalendarAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetLeagueScheduleCalendarAsync(System.DateTimeOffset)')
  - [GetLeagueStandingsByDateTimeOffsetAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetLeagueStandingsByDateTimeOffsetAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetLeagueStandingsByDateTimeOffsetAsync(System.DateTimeOffset)')
  - [GetLeagueStandingsSeasonInformationAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingsSeasonInformationAsync 'Nhl.Api.NhlApi.GetLeagueStandingsSeasonInformationAsync')
  - [GetLeagueWeekScheduleByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetLeagueWeekScheduleByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetLeagueWeekScheduleByDateTimeAsync(System.DateTimeOffset)')
  - [GetLiveGameFeedPlayerShiftsAsync(gameId)](#M-Nhl-Api-NhlApi-GetLiveGameFeedPlayerShiftsAsync-System-Int32- 'Nhl.Api.NhlApi.GetLiveGameFeedPlayerShiftsAsync(System.Int32)')
  - [GetPlayerHeadshotImageAsync(player,playerHeadshotImageSize)](#M-Nhl-Api-NhlApi-GetPlayerHeadshotImageAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize- 'Nhl.Api.NhlApi.GetPlayerHeadshotImageAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize)')
  - [GetPlayerHeadshotImageAsync(playerId,playerHeadshotImageSize)](#M-Nhl-Api-NhlApi-GetPlayerHeadshotImageAsync-System-Int32,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize- 'Nhl.Api.NhlApi.GetPlayerHeadshotImageAsync(System.Int32,Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize)')
  - [GetPlayerInformationAsync(playerId)](#M-Nhl-Api-NhlApi-GetPlayerInformationAsync-System-Int32- 'Nhl.Api.NhlApi.GetPlayerInformationAsync(System.Int32)')
  - [GetPlayerInformationAsync(player)](#M-Nhl-Api-NhlApi-GetPlayerInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlApi.GetPlayerInformationAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetPlayerSpotlightAsync()](#M-Nhl-Api-NhlApi-GetPlayerSpotlightAsync 'Nhl.Api.NhlApi.GetPlayerSpotlightAsync')
  - [GetSkaterStatsisticsLeadersAsync(playerStatisticsType,seasonYear,gameType,limit)](#M-Nhl-Api-NhlApi-GetSkaterStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32- 'Nhl.Api.NhlApi.GetSkaterStatsisticsLeadersAsync(Nhl.Api.Enumerations.Statistic.PlayerStatisticsType,Nhl.Api.Enumerations.Game.GameType,System.String,System.Int32)')
  - [GetSourcesToWatchGamesAsync()](#M-Nhl-Api-NhlApi-GetSourcesToWatchGamesAsync 'Nhl.Api.NhlApi.GetSourcesToWatchGamesAsync')
  - [GetTeamColorsAsync(team)](#M-Nhl-Api-NhlApi-GetTeamColorsAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetTeamColorsAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamColorsAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamColorsAsync-System-Int32- 'Nhl.Api.NhlApi.GetTeamColorsAsync(System.Int32)')
  - [GetTeamLogoAsync(teamId,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(System.Int32,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamLogoAsync(team,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamProspectsByTeamAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamProspectsByTeamAsync-System-Int32- 'Nhl.Api.NhlApi.GetTeamProspectsByTeamAsync(System.Int32)')
  - [GetTeamProspectsByTeamAsync(team)](#M-Nhl-Api-NhlApi-GetTeamProspectsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetTeamProspectsByTeamAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamRosterBySeasonYearAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamRosterBySeasonYearAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamRosterBySeasonYearAsync(System.Int32,System.String)')
  - [GetTeamRosterBySeasonYearAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamRosterBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamRosterBySeasonYearAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamScheduleBySeasonAsync(teamAbbreviation,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamScheduleBySeasonAsync-System-String,System-String- 'Nhl.Api.NhlApi.GetTeamScheduleBySeasonAsync(System.String,System.String)')
  - [GetTeamSeasonScheduleBySeasonYearAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamSeasonScheduleBySeasonYearAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamSeasonScheduleBySeasonYearAsync(System.Int32,System.String)')
  - [GetTeamSeasonScheduleBySeasonYearAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamSeasonScheduleBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamSeasonScheduleBySeasonYearAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamSeasonScheduleByYearAndMonthAsync(teamId,year,month)](#M-Nhl-Api-NhlApi-GetTeamSeasonScheduleByYearAndMonthAsync-System-Int32,System-Int32,System-Int32- 'Nhl.Api.NhlApi.GetTeamSeasonScheduleByYearAndMonthAsync(System.Int32,System.Int32,System.Int32)')
  - [GetTeamSeasonScheduleByYearAndMonthAsync(team,year,month)](#M-Nhl-Api-NhlApi-GetTeamSeasonScheduleByYearAndMonthAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-Int32,System-Int32- 'Nhl.Api.NhlApi.GetTeamSeasonScheduleByYearAndMonthAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.Int32,System.Int32)')
  - [GetTeamStatisticsBySeasonAndGameTypeAsync(team,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetTeamStatisticsBySeasonAndGameTypeAsync(teamId,seasonYear,gameType)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetTeamStatisticsBySeasonAsync(team)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamStatisticsBySeasonAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-System-Int32- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(System.Int32)')
  - [GetTeamWeekScheduleByDateTimeAsync(teamId,dateTimeOffset)](#M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeAsync-System-Int32,System-DateTimeOffset- 'Nhl.Api.NhlApi.GetTeamWeekScheduleByDateTimeAsync(System.Int32,System.DateTimeOffset)')
  - [GetTeamWeekScheduleByDateTimeAsync(team,dateTimeOffset)](#M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTimeOffset- 'Nhl.Api.NhlApi.GetTeamWeekScheduleByDateTimeAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.DateTimeOffset)')
  - [GetTeamWeekScheduleByDateTimeOffsetAsync(teamAbbreviation,dateTimeOffset)](#M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeOffsetAsync-System-String,System-DateTimeOffset- 'Nhl.Api.NhlApi.GetTeamWeekScheduleByDateTimeOffsetAsync(System.String,System.DateTimeOffset)')
  - [GetTvScheduleBroadcastAsync(dateTimeOffset)](#M-Nhl-Api-NhlApi-GetTvScheduleBroadcastAsync-System-DateTimeOffset- 'Nhl.Api.NhlApi.GetTvScheduleBroadcastAsync(System.DateTimeOffset)')
  - [IsLeagueActiveAsync()](#M-Nhl-Api-NhlApi-IsLeagueActiveAsync 'Nhl.Api.NhlApi.IsLeagueActiveAsync')
  - [IsPlayoffSeasonActiveAsync()](#M-Nhl-Api-NhlApi-IsPlayoffSeasonActiveAsync 'Nhl.Api.NhlApi.IsPlayoffSeasonActiveAsync')
  - [IsPreSeasonActiveAsync()](#M-Nhl-Api-NhlApi-IsPreSeasonActiveAsync 'Nhl.Api.NhlApi.IsPreSeasonActiveAsync')
  - [IsRegularSeasonActiveAsync()](#M-Nhl-Api-NhlApi-IsRegularSeasonActiveAsync 'Nhl.Api.NhlApi.IsRegularSeasonActiveAsync')
  - [SearchAllActivePlayersAsync(query,limit)](#M-Nhl-Api-NhlApi-SearchAllActivePlayersAsync-System-String,System-Int32- 'Nhl.Api.NhlApi.SearchAllActivePlayersAsync(System.String,System.Int32)')
  - [SearchAllPlayersAsync(query,limit)](#M-Nhl-Api-NhlApi-SearchAllPlayersAsync-System-String,System-Int32- 'Nhl.Api.NhlApi.SearchAllPlayersAsync(System.String,System.Int32)')
- [NhlGameApi](#T-Nhl-Api-NhlGameApi 'Nhl.Api.NhlGameApi')
  - [#ctor()](#M-Nhl-Api-NhlGameApi-#ctor 'Nhl.Api.NhlGameApi.#ctor')
  - [GetCurrentTeamScoreboardAsync(team)](#M-Nhl-Api-NhlGameApi-GetCurrentTeamScoreboardAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlGameApi.GetCurrentTeamScoreboardAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetCurrentTeamScoreboardAsync(teamId)](#M-Nhl-Api-NhlGameApi-GetCurrentTeamScoreboardAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetCurrentTeamScoreboardAsync(System.Int32)')
  - [GetGameCenterBoxScoreByGameIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetGameCenterBoxScoreByGameIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetGameCenterBoxScoreByGameIdAsync(System.Int32)')
  - [GetGameCenterLandingByGameIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetGameCenterLandingByGameIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetGameCenterLandingByGameIdAsync(System.Int32)')
  - [GetGameCenterPlayByPlayByGameIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetGameCenterPlayByPlayByGameIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetGameCenterPlayByPlayByGameIdAsync(System.Int32)')
  - [GetGameMetadataByGameIdAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetGameMetadataByGameIdAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetGameMetadataByGameIdAsync(System.Int32)')
  - [GetGameScoreboardAsync()](#M-Nhl-Api-NhlGameApi-GetGameScoreboardAsync 'Nhl.Api.NhlGameApi.GetGameScoreboardAsync')
  - [GetGameScoresByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlGameApi-GetGameScoresByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlGameApi.GetGameScoresByDateTimeAsync(System.DateTimeOffset)')
  - [GetLiveGameFeedPlayerShiftsAsync(gameId)](#M-Nhl-Api-NhlGameApi-GetLiveGameFeedPlayerShiftsAsync-System-Int32- 'Nhl.Api.NhlGameApi.GetLiveGameFeedPlayerShiftsAsync(System.Int32)')
  - [GetTeamSeasonScheduleBySeasonYearAsync(teamId,seasonYear)](#M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleBySeasonYearAsync-System-Int32,System-String- 'Nhl.Api.NhlGameApi.GetTeamSeasonScheduleBySeasonYearAsync(System.Int32,System.String)')
  - [GetTeamSeasonScheduleBySeasonYearAsync(team,seasonYear)](#M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlGameApi.GetTeamSeasonScheduleBySeasonYearAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamSeasonScheduleByYearAndMonthAsync(teamId,year,month)](#M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleByYearAndMonthAsync-System-Int32,System-Int32,System-Int32- 'Nhl.Api.NhlGameApi.GetTeamSeasonScheduleByYearAndMonthAsync(System.Int32,System.Int32,System.Int32)')
  - [GetTeamSeasonScheduleByYearAndMonthAsync(team,year,month)](#M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleByYearAndMonthAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-Int32,System-Int32- 'Nhl.Api.NhlGameApi.GetTeamSeasonScheduleByYearAndMonthAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.Int32,System.Int32)')
  - [GetTeamWeekScheduleByDateTimeAsync(teamId,dateTimeOffset)](#M-Nhl-Api-NhlGameApi-GetTeamWeekScheduleByDateTimeAsync-System-Int32,System-DateTimeOffset- 'Nhl.Api.NhlGameApi.GetTeamWeekScheduleByDateTimeAsync(System.Int32,System.DateTimeOffset)')
  - [GetTeamWeekScheduleByDateTimeAsync(team,dateTimeOffset)](#M-Nhl-Api-NhlGameApi-GetTeamWeekScheduleByDateTimeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTimeOffset- 'Nhl.Api.NhlGameApi.GetTeamWeekScheduleByDateTimeAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.DateTimeOffset)')
- [NhlLeagueApi](#T-Nhl-Api-NhlLeagueApi 'Nhl.Api.NhlLeagueApi')
  - [#ctor()](#M-Nhl-Api-NhlLeagueApi-#ctor 'Nhl.Api.NhlLeagueApi.#ctor')
  - [GetAllRosterSeasonsByTeamAsync(teamId)](#M-Nhl-Api-NhlLeagueApi-GetAllRosterSeasonsByTeamAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetAllRosterSeasonsByTeamAsync(System.Int32)')
  - [GetAllRosterSeasonsByTeamAsync(team)](#M-Nhl-Api-NhlLeagueApi-GetAllRosterSeasonsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlLeagueApi.GetAllRosterSeasonsByTeamAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetAllSeasonsAsync()](#M-Nhl-Api-NhlLeagueApi-GetAllSeasonsAsync 'Nhl.Api.NhlLeagueApi.GetAllSeasonsAsync')
  - [GetLeagueGameWeekScheduleByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetLeagueGameWeekScheduleByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetLeagueGameWeekScheduleByDateTimeAsync(System.DateTimeOffset)')
  - [GetLeagueMetadataInformation(playerIds,teamIds)](#M-Nhl-Api-NhlLeagueApi-GetLeagueMetadataInformation-System-Collections-Generic-List{System-Int32},System-Collections-Generic-List{System-String}- 'Nhl.Api.NhlLeagueApi.GetLeagueMetadataInformation(System.Collections.Generic.List{System.Int32},System.Collections.Generic.List{System.String})')
  - [GetLeagueMetadataInformation(players,teams)](#M-Nhl-Api-NhlLeagueApi-GetLeagueMetadataInformation-System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Player-PlayerEnum},System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Team-TeamEnum}- 'Nhl.Api.NhlLeagueApi.GetLeagueMetadataInformation(System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum},System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum})')
  - [GetLeagueScheduleCalendarAsync(dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetLeagueScheduleCalendarAsync-System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetLeagueScheduleCalendarAsync(System.DateTimeOffset)')
  - [GetLeagueStandingsByDateTimeOffsetAsync(dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDateTimeOffsetAsync-System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsByDateTimeOffsetAsync(System.DateTimeOffset)')
  - [GetLeagueStandingsSeasonInformationAsync()](#M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsSeasonInformationAsync 'Nhl.Api.NhlLeagueApi.GetLeagueStandingsSeasonInformationAsync')
  - [GetLeagueWeekScheduleByDateTimeAsync(dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetLeagueWeekScheduleByDateTimeAsync-System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetLeagueWeekScheduleByDateTimeAsync(System.DateTimeOffset)')
  - [GetSourcesToWatchGamesAsync()](#M-Nhl-Api-NhlLeagueApi-GetSourcesToWatchGamesAsync 'Nhl.Api.NhlLeagueApi.GetSourcesToWatchGamesAsync')
  - [GetTeamColorsAsync(team)](#M-Nhl-Api-NhlLeagueApi-GetTeamColorsAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlLeagueApi.GetTeamColorsAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamColorsAsync(teamId)](#M-Nhl-Api-NhlLeagueApi-GetTeamColorsAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetTeamColorsAsync(System.Int32)')
  - [GetTeamLogoAsync(team,teamLogoType)](#M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlLeagueApi.GetTeamLogoAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamLogoAsync(teamId,teamLogoType)](#M-Nhl-Api-NhlLeagueApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlLeagueApi.GetTeamLogoAsync(System.Int32,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamProspectsByTeamAsync(teamId)](#M-Nhl-Api-NhlLeagueApi-GetTeamProspectsByTeamAsync-System-Int32- 'Nhl.Api.NhlLeagueApi.GetTeamProspectsByTeamAsync(System.Int32)')
  - [GetTeamProspectsByTeamAsync(team)](#M-Nhl-Api-NhlLeagueApi-GetTeamProspectsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlLeagueApi.GetTeamProspectsByTeamAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamRosterBySeasonYearAsync(teamId,seasonYear)](#M-Nhl-Api-NhlLeagueApi-GetTeamRosterBySeasonYearAsync-System-Int32,System-String- 'Nhl.Api.NhlLeagueApi.GetTeamRosterBySeasonYearAsync(System.Int32,System.String)')
  - [GetTeamRosterBySeasonYearAsync(team,seasonYear)](#M-Nhl-Api-NhlLeagueApi-GetTeamRosterBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlLeagueApi.GetTeamRosterBySeasonYearAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamScheduleBySeasonAsync(teamAbbreviation,seasonYear)](#M-Nhl-Api-NhlLeagueApi-GetTeamScheduleBySeasonAsync-System-String,System-String- 'Nhl.Api.NhlLeagueApi.GetTeamScheduleBySeasonAsync(System.String,System.String)')
  - [GetTeamWeekScheduleByDateTimeOffsetAsync(teamAbbreviation,dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetTeamWeekScheduleByDateTimeOffsetAsync-System-String,System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetTeamWeekScheduleByDateTimeOffsetAsync(System.String,System.DateTimeOffset)')
  - [GetTvScheduleBroadcastAsync(dateTimeOffset)](#M-Nhl-Api-NhlLeagueApi-GetTvScheduleBroadcastAsync-System-DateTimeOffset- 'Nhl.Api.NhlLeagueApi.GetTvScheduleBroadcastAsync(System.DateTimeOffset)')
  - [IsLeagueActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsLeagueActiveAsync 'Nhl.Api.NhlLeagueApi.IsLeagueActiveAsync')
  - [IsPlayoffSeasonActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsPlayoffSeasonActiveAsync 'Nhl.Api.NhlLeagueApi.IsPlayoffSeasonActiveAsync')
  - [IsPreSeasonActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsPreSeasonActiveAsync 'Nhl.Api.NhlLeagueApi.IsPreSeasonActiveAsync')
  - [IsRegularSeasonActiveAsync()](#M-Nhl-Api-NhlLeagueApi-IsRegularSeasonActiveAsync 'Nhl.Api.NhlLeagueApi.IsRegularSeasonActiveAsync')
- [NhlPlayerApi](#T-Nhl-Api-NhlPlayerApi 'Nhl.Api.NhlPlayerApi')
  - [#ctor()](#M-Nhl-Api-NhlPlayerApi-#ctor 'Nhl.Api.NhlPlayerApi.#ctor')
  - [Dispose()](#M-Nhl-Api-NhlPlayerApi-Dispose 'Nhl.Api.NhlPlayerApi.Dispose')
  - [GetGoalieInformationAsync(playerId)](#M-Nhl-Api-NhlPlayerApi-GetGoalieInformationAsync-System-Int32- 'Nhl.Api.NhlPlayerApi.GetGoalieInformationAsync(System.Int32)')
  - [GetGoalieInformationAsync(player)](#M-Nhl-Api-NhlPlayerApi-GetGoalieInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlPlayerApi.GetGoalieInformationAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType)](#M-Nhl-Api-NhlPlayerApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType)](#M-Nhl-Api-NhlPlayerApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetPlayerHeadshotImageAsync(player,playerHeadshotImageSize)](#M-Nhl-Api-NhlPlayerApi-GetPlayerHeadshotImageAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize- 'Nhl.Api.NhlPlayerApi.GetPlayerHeadshotImageAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize)')
  - [GetPlayerHeadshotImageAsync(playerId,playerHeadshotImageSize)](#M-Nhl-Api-NhlPlayerApi-GetPlayerHeadshotImageAsync-System-Int32,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize- 'Nhl.Api.NhlPlayerApi.GetPlayerHeadshotImageAsync(System.Int32,Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize)')
  - [GetPlayerInformationAsync(playerId)](#M-Nhl-Api-NhlPlayerApi-GetPlayerInformationAsync-System-Int32- 'Nhl.Api.NhlPlayerApi.GetPlayerInformationAsync(System.Int32)')
  - [GetPlayerInformationAsync(player)](#M-Nhl-Api-NhlPlayerApi-GetPlayerInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlPlayerApi.GetPlayerInformationAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType)](#M-Nhl-Api-NhlPlayerApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType)](#M-Nhl-Api-NhlPlayerApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetPlayerSpotlightAsync()](#M-Nhl-Api-NhlPlayerApi-GetPlayerSpotlightAsync 'Nhl.Api.NhlPlayerApi.GetPlayerSpotlightAsync')
  - [SearchAllActivePlayersAsync(query,limit)](#M-Nhl-Api-NhlPlayerApi-SearchAllActivePlayersAsync-System-String,System-Int32- 'Nhl.Api.NhlPlayerApi.SearchAllActivePlayersAsync(System.String,System.Int32)')
  - [SearchAllPlayersAsync(query,limit)](#M-Nhl-Api-NhlPlayerApi-SearchAllPlayersAsync-System-String,System-Int32- 'Nhl.Api.NhlPlayerApi.SearchAllPlayersAsync(System.String,System.Int32)')
- [NhlStatisticsApi](#T-Nhl-Api-NhlStatisticsApi 'Nhl.Api.NhlStatisticsApi')
  - [#ctor()](#M-Nhl-Api-NhlStatisticsApi-#ctor 'Nhl.Api.NhlStatisticsApi.#ctor')
  - [GetGoalieStatsisticsLeadersAsync(goalieStatisticsType,seasonYear,gameType,limit)](#M-Nhl-Api-NhlStatisticsApi-GetGoalieStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32- 'Nhl.Api.NhlStatisticsApi.GetGoalieStatsisticsLeadersAsync(Nhl.Api.Enumerations.Statistic.GoalieStatisticsType,Nhl.Api.Enumerations.Game.GameType,System.String,System.Int32)')
  - [GetSkaterStatsisticsLeadersAsync(playerStatisticsType,seasonYear,gameType,limit)](#M-Nhl-Api-NhlStatisticsApi-GetSkaterStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32- 'Nhl.Api.NhlStatisticsApi.GetSkaterStatsisticsLeadersAsync(Nhl.Api.Enumerations.Statistic.PlayerStatisticsType,Nhl.Api.Enumerations.Game.GameType,System.String,System.Int32)')
  - [GetTeamStatisticsBySeasonAndGameTypeAsync(team,seasonYear,gameType)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAndGameTypeAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetTeamStatisticsBySeasonAndGameTypeAsync(teamId,seasonYear,gameType)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAndGameTypeAsync(System.Int32,System.String,Nhl.Api.Enumerations.Game.GameType)')
  - [GetTeamStatisticsBySeasonAsync(team)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamStatisticsBySeasonAsync(teamId)](#M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-System-Int32- 'Nhl.Api.NhlStatisticsApi.GetTeamStatisticsBySeasonAsync(System.Int32)')

<a name='T-Nhl-Api-NhlApi'></a>
## NhlApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more

<a name='M-Nhl-Api-NhlApi-#ctor'></a>
### #ctor() `constructor`

##### Summary

The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more

##### Parameters

This constructor has no parameters.

<a name='M-Nhl-Api-NhlApi-Dispose'></a>
### Dispose() `method`

##### Summary

Releases and disposes all unused or garbage collected resources for the Nhl.Api

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-DisposeAsync'></a>
### DisposeAsync() `method`

##### Summary

Releases and disposes all unused or garbage collected resources for the Nhl.Api asynchronously

##### Returns

The await-able result of the asynchronous operation

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetAllRosterSeasonsByTeamAsync-System-Int32-'></a>
### GetAllRosterSeasonsByTeamAsync(teamId) `method`

##### Summary

Returns every active season for an NHL team and their participation in the NHL

##### Returns

Returns every active season for an NHL team and their participation in the NHL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |

<a name='M-Nhl-Api-NhlApi-GetAllRosterSeasonsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetAllRosterSeasonsByTeamAsync(team) `method`

##### Summary

Returns every active season for an NHL team and their participation in the NHL

##### Returns

Returns every active season for an NHL team and their participation in the NHL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 9 - Ottawa Senators |

<a name='M-Nhl-Api-NhlApi-GetAllSeasonsAsync'></a>
### GetAllSeasonsAsync() `method`

##### Summary

Returns all the NHL seasons for the NHL league

##### Returns

Returns all the NHL seasons for the NHL league

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetCurrentTeamScoreboardAsync-System-Int32-'></a>
### GetCurrentTeamScoreboardAsync(teamId) `method`

##### Summary

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Returns

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |

<a name='M-Nhl-Api-NhlApi-GetCurrentTeamScoreboardAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetCurrentTeamScoreboardAsync(team) `method`

##### Summary

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Returns

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlApi-GetGameCenterBoxScoreByGameIdAsync-System-Int32-'></a>
### GetGameCenterBoxScoreByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlApi-GetGameCenterLandingByGameIdAsync-System-Int32-'></a>
### GetGameCenterLandingByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlApi-GetGameCenterPlayByPlayByGameIdAsync-System-Int32-'></a>
### GetGameCenterPlayByPlayByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlApi-GetGameMetadataByGameIdAsync-System-Int32-'></a>
### GetGameMetadataByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game metadata for the specified game id, including the teams, season states and more

##### Returns

Returns the NHL game metadata for the specified game id, including the teams, season states and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlApi-GetGameScoreboardAsync'></a>
### GetGameScoreboardAsync() `method`

##### Summary

Returns the live NHL game scoreboard, including the game information, game status, game venue and more

##### Returns

Returns the live NHL game scoreboard, including the game information, game status, game venue and more

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetGameScoresByDateTimeAsync-System-DateTimeOffset-'></a>
### GetGameScoresByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more

##### Returns

Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='M-Nhl-Api-NhlApi-GetGoalieInformationAsync-System-Int32-'></a>
### GetGoalieInformationAsync(playerId) `method`

##### Summary

Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8480313 - Logan Thompson |

<a name='M-Nhl-Api-NhlApi-GetGoalieInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetGoalieInformationAsync(player) `method`

##### Summary

Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8480313 - Logan Thompson, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType) `method`

##### Summary

The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Joseph Woll, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL goalies |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType) `method`

##### Summary

The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8479361 - Joseph Woll |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlApi-GetGoalieStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32-'></a>
### GetGoalieStatsisticsLeadersAsync(goalieStatisticsType,seasonYear,gameType,limit) `method`

##### Summary

Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year

##### Returns

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| goalieStatisticsType | [Nhl.Api.Enumerations.Statistic.GoalieStatisticsType](#T-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType 'Nhl.Api.Enumerations.Statistic.GoalieStatisticsType') | A player statistics type, [GoalieStatisticsType](#T-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType 'Nhl.Api.Enumerations.Statistic.GoalieStatisticsType') for all the types of statisitics |
| seasonYear | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL season year to retrieve the player statistics leaders for, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL game type to retrieve the player statistics leaders for, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit to the number of results returned when reviewing the NHL player sta |

<a name='M-Nhl-Api-NhlApi-GetLeagueGameWeekScheduleByDateTimeAsync-System-DateTimeOffset-'></a>
### GetLeagueGameWeekScheduleByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for a specific date using the DateTimeOffset

##### Returns

A result of the current NHL schedule by the specified date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') for the specific date for the NHL schedule |

<a name='M-Nhl-Api-NhlApi-GetLeagueMetadataInformation-System-Collections-Generic-List{System-Int32},System-Collections-Generic-List{System-String}-'></a>
### GetLeagueMetadataInformation(playerIds,teamIds) `method`

##### Summary

Returns the metadata information about the NHL league including players, teams and season states

##### Returns

Returns the metadata information about the NHL league including players, teams and season states

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | A collection of NHL player identifiers, Example: [8478402,8478403] |
| teamIds | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | A collection of NHL team identifiers, Example: [EDM, TOR] |

<a name='M-Nhl-Api-NhlApi-GetLeagueMetadataInformation-System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Player-PlayerEnum},System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Team-TeamEnum}-'></a>
### GetLeagueMetadataInformation(players,teams) `method`

##### Summary

Returns the metadata information about the NHL league including players, teams and season states

##### Returns

Returns the metadata information about the NHL league including players, teams and season states

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| players | [System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum}') | A collection of NHL player identifiers, Example: [8478402,8478403] |
| teams | [System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum}') | A collection of NHL team identifiers, Example: [EDM, TOR] |

<a name='M-Nhl-Api-NhlApi-GetLeagueScheduleCalendarAsync-System-DateTimeOffset-'></a>
### GetLeagueScheduleCalendarAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league calendar schedule for the specified date and all applicable teams

##### Returns

Returns the NHL league calendar schedule for the specified date and all applicable teams

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL league schedule, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsByDateTimeOffsetAsync-System-DateTimeOffset-'></a>
### GetLeagueStandingsByDateTimeOffsetAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league standings for the current NHL season by the specified date

##### Returns

Return the NHL league standings for the specified date with specific team information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL season standing |

<a name='M-Nhl-Api-NhlApi-GetLeagueStandingsSeasonInformationAsync'></a>
### GetLeagueStandingsSeasonInformationAsync() `method`

##### Summary

Returns the NHL league standings for the all NHL seasons with specific league season information

##### Returns

Returns the NHL league standings information for each saeson since 1917-1918

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetLeagueWeekScheduleByDateTimeAsync-System-DateTimeOffset-'></a>
### GetLeagueWeekScheduleByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league schedule for the specified date

##### Returns

Returns the NHL league schedule for the specified date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL league schedule, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlApi-GetLiveGameFeedPlayerShiftsAsync-System-Int32-'></a>
### GetLiveGameFeedPlayerShiftsAsync(gameId) `method`

##### Summary

Returns all of the individual shifts of each NHL player for a specific NHL game id

##### Returns

A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlApi-GetPlayerHeadshotImageAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize-'></a>
### GetPlayerHeadshotImageAsync(player,playerHeadshotImageSize) `method`

##### Summary

Returns the NHL player's head shot image by the selected size

##### Returns

A byte array content of an NHL player head shot image

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |
| playerHeadshotImageSize | [Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') | The size of the head shot image, see [PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') for more information |

<a name='M-Nhl-Api-NhlApi-GetPlayerHeadshotImageAsync-System-Int32,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize-'></a>
### GetPlayerHeadshotImageAsync(playerId,playerHeadshotImageSize) `method`

##### Summary

Returns the NHL player's head shot image by the selected size

##### Returns

A byte array content of an NHL player head shot image

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |
| playerHeadshotImageSize | [Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') | The size of the head shot image, see [PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') for more information |

<a name='M-Nhl-Api-NhlApi-GetPlayerInformationAsync-System-Int32-'></a>
### GetPlayerInformationAsync(playerId) `method`

##### Summary

Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |

<a name='M-Nhl-Api-NhlApi-GetPlayerInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetPlayerInformationAsync(player) `method`

##### Summary

Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlApi-GetPlayerSpotlightAsync'></a>
### GetPlayerSpotlightAsync() `method`

##### Summary

Returns the NHL player's in the spotlight based on their recent performances

##### Returns

A collection of players and their information for players in the NHL spotlight

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetSkaterStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32-'></a>
### GetSkaterStatsisticsLeadersAsync(playerStatisticsType,seasonYear,gameType,limit) `method`

##### Summary

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Returns

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerStatisticsType | [Nhl.Api.Enumerations.Statistic.PlayerStatisticsType](#T-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType 'Nhl.Api.Enumerations.Statistic.PlayerStatisticsType') | A player statistics type, [PlayerStatisticsType](#T-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType 'Nhl.Api.Enumerations.Statistic.PlayerStatisticsType') for all the types of statisitics |
| seasonYear | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL season year to retrieve the player statistics leaders for, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL game type to retrieve the player statistics leaders for, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit to the number of results returned when reviewing the NHL player sta |

<a name='M-Nhl-Api-NhlApi-GetSourcesToWatchGamesAsync'></a>
### GetSourcesToWatchGamesAsync() `method`

##### Summary

Returns the collection of countries and where you can watch NHL games with links and more

##### Returns

Returns the collection of countries and where you can watch NHL games with links and more

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-GetTeamColorsAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamColorsAsync(team) `method`

##### Summary

Returns the hexadecimal code for an NHL team's colors

##### Returns

An NHL team color scheme using hexadecimal codes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlApi-GetTeamColorsAsync-System-Int32-'></a>
### GetTeamColorsAsync(teamId) `method`

##### Summary

Returns the hexadecimal code for an NHL team's colors

##### Returns

An NHL team color scheme using hexadecimal codes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |

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

<a name='M-Nhl-Api-NhlApi-GetTeamProspectsByTeamAsync-System-Int32-'></a>
### GetTeamProspectsByTeamAsync(teamId) `method`

##### Summary

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Returns

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |

<a name='M-Nhl-Api-NhlApi-GetTeamProspectsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamProspectsByTeamAsync(team) `method`

##### Summary

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Returns

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 10 - Toronto Maple Leafs |

<a name='M-Nhl-Api-NhlApi-GetTeamRosterBySeasonYearAsync-System-Int32,System-String-'></a>
### GetTeamRosterBySeasonYearAsync(teamId,seasonYear) `method`

##### Summary

Returns the NHL team roster for a specific team by the team identifier and season year

##### Returns

Returns the NHL team roster for a specific team by the team identifier and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20232024 |

<a name='M-Nhl-Api-NhlApi-GetTeamRosterBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamRosterBySeasonYearAsync(team,seasonYear) `method`

##### Summary

Returns the NHL team roster for a specific team by the team identifier and season year

##### Returns

Returns the NHL team roster for a specific team by the team identifier and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 8 - Montreal Canadiens |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20232024 |

<a name='M-Nhl-Api-NhlApi-GetTeamScheduleBySeasonAsync-System-String,System-String-'></a>
### GetTeamScheduleBySeasonAsync(teamAbbreviation,seasonYear) `method`

##### Summary

This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season

##### Returns

A collection of all games in the requested season for the requested NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamAbbreviation | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The required team abbreviation for the NHL team, Example: WSH - Washington Capitals |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, Example: 20232024 |

<a name='M-Nhl-Api-NhlApi-GetTeamSeasonScheduleBySeasonYearAsync-System-Int32,System-String-'></a>
### GetTeamSeasonScheduleBySeasonYearAsync(teamId,seasonYear) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year

##### Returns

Returns the NHL team schedule for the specified team and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year, see [](#!-=SeasonYear '=SeasonYear') for more information, Example: 20202021 |

<a name='M-Nhl-Api-NhlApi-GetTeamSeasonScheduleBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamSeasonScheduleBySeasonYearAsync(team,seasonYear) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year

##### Returns

Returns the NHL team schedule for the specified team and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20202021 |

<a name='M-Nhl-Api-NhlApi-GetTeamSeasonScheduleByYearAndMonthAsync-System-Int32,System-Int32,System-Int32-'></a>
### GetTeamSeasonScheduleByYearAndMonthAsync(teamId,year,month) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year and month

##### Returns

Returns the NHL team schedule for the specified team and season year and month

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The year, Example: 2020 |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The month, Example: 10 |

<a name='M-Nhl-Api-NhlApi-GetTeamSeasonScheduleByYearAndMonthAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-Int32,System-Int32-'></a>
### GetTeamSeasonScheduleByYearAndMonthAsync(team,year,month) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year and month

##### Returns

Returns the NHL team schedule for the specified team and season year and month

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The year, Example: 2020 |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The month, Example: 10 |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetTeamStatisticsBySeasonAndGameTypeAsync(team,seasonYear,gameType) `method`

##### Summary

Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year

##### Returns

The NHL team season statistics for the specified season and game type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The team enumeration identifier, specifying which the NHL team, [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year to retrieve the team statistics, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL game type to retrieve the team statistics, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetTeamStatisticsBySeasonAndGameTypeAsync(teamId,seasonYear,gameType) `method`

##### Summary

Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year

##### Returns

The NHL team season statistics for the specified season and game type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year to retrieve the team statistics, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL game type to retrieve the team statistics, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamStatisticsBySeasonAsync(team) `method`

##### Summary

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Returns

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The team enumeration identifier, specifying which the NHL team, [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-System-Int32-'></a>
### GetTeamStatisticsBySeasonAsync(teamId) `method`

##### Summary

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Returns

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken |

<a name='M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeAsync-System-Int32,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeAsync(teamId,dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for the specified team and the specified date and time

##### Returns

Returns the NHL team schedule for the specified team and the specified date and time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeAsync(team,dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for the specified team and the specified date and time

##### Returns

Returns the NHL team schedule for the specified team and the specified date and time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='M-Nhl-Api-NhlApi-GetTeamWeekScheduleByDateTimeOffsetAsync-System-String,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeOffsetAsync(teamAbbreviation,dateTimeOffset) `method`

##### Summary

This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season

##### Returns

A collection of all games in the requested season for the requested NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamAbbreviation | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The required team abbreviation for the NHL team, Example: WSH - Washington Capitals |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date in which the request schedule for the team and for the week is request for |

<a name='M-Nhl-Api-NhlApi-GetTvScheduleBroadcastAsync-System-DateTimeOffset-'></a>
### GetTvScheduleBroadcastAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL TV broadcasts for the specified date with information about the broadcasts

##### Returns

Returns the NHL TV broadcasts for the specified date with information about the broadcasts

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL TV broadcasts, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlApi-IsLeagueActiveAsync'></a>
### IsLeagueActiveAsync() `method`

##### Summary

Determines if the NHL league is active or inactive based on the current date and time

##### Returns

Returns true or false based on the current time and date

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsPlayoffSeasonActiveAsync'></a>
### IsPlayoffSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL playoff season is active or inactive

##### Returns

Returns a result of true or false if the NHL playoff season is active

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsPreSeasonActiveAsync'></a>
### IsPreSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL playoff pre season is active or inactive

##### Returns

Returns a result of true or false if the NHL pre-season is active

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-IsRegularSeasonActiveAsync'></a>
### IsRegularSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL regular season is active or inactive

##### Returns

Returns a result of true or false if the NHL regular season is active

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlApi-SearchAllActivePlayersAsync-System-String,System-Int32-'></a>
### SearchAllActivePlayersAsync(query,limit) `method`

##### Summary

Returns only active NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A parameter to limit the number of search results returned when searching for a player |

<a name='M-Nhl-Api-NhlApi-SearchAllPlayersAsync-System-String,System-Int32-'></a>
### SearchAllPlayersAsync(query,limit) `method`

##### Summary

Returns any active or inactive NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A parameter to limit the number of search results returned when searching for a player |

<a name='T-Nhl-Api-NhlGameApi'></a>
## NhlGameApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more

<a name='M-Nhl-Api-NhlGameApi-#ctor'></a>
### #ctor() `constructor`

##### Summary

The official unofficial NHL Game API providing various NHL information game information, game schedules, live game feeds and more

##### Parameters

This constructor has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetCurrentTeamScoreboardAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetCurrentTeamScoreboardAsync(team) `method`

##### Summary

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Returns

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlGameApi-GetCurrentTeamScoreboardAsync-System-Int32-'></a>
### GetCurrentTeamScoreboardAsync(teamId) `method`

##### Summary

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Returns

Returns the current NHL team scoreboard for the current date and time, with upcoming game scores and completed game scores

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |

<a name='M-Nhl-Api-NhlGameApi-GetGameCenterBoxScoreByGameIdAsync-System-Int32-'></a>
### GetGameCenterBoxScoreByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center box score for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlGameApi-GetGameCenterLandingByGameIdAsync-System-Int32-'></a>
### GetGameCenterLandingByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlGameApi-GetGameCenterPlayByPlayByGameIdAsync-System-Int32-'></a>
### GetGameCenterPlayByPlayByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Returns

Returns the NHL game center feed for the specified game id, including the game information, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlGameApi-GetGameMetadataByGameIdAsync-System-Int32-'></a>
### GetGameMetadataByGameIdAsync(gameId) `method`

##### Summary

Returns the NHL game metadata for the specified game id, including the teams, season states and more

##### Returns

Returns the NHL game metadata for the specified game id, including the teams, season states and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL game identfier, Example: 2023020204 |

<a name='M-Nhl-Api-NhlGameApi-GetGameScoreboardAsync'></a>
### GetGameScoreboardAsync() `method`

##### Summary

Returns the live NHL game scoreboard, including the game information, game status, game venue and more

##### Returns

Returns the live NHL game scoreboard, including the game information, game status, game venue and more

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlGameApi-GetGameScoresByDateTimeAsync-System-DateTimeOffset-'></a>
### GetGameScoresByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more

##### Returns

Returns all of the NHL game scores for the specified date, including the game id, game date and time, game status, game venue and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='M-Nhl-Api-NhlGameApi-GetLiveGameFeedPlayerShiftsAsync-System-Int32-'></a>
### GetLiveGameFeedPlayerShiftsAsync(gameId) `method`

##### Summary

Returns all of the individual shifts of each NHL player for a specific NHL game id

##### Returns

A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The game id, Example: 2021020087 |

<a name='M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleBySeasonYearAsync-System-Int32,System-String-'></a>
### GetTeamSeasonScheduleBySeasonYearAsync(teamId,seasonYear) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year

##### Returns

Returns the NHL team schedule for the specified team and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year, see [](#!-=SeasonYear '=SeasonYear') for more information, Example: 20202021 |

<a name='M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamSeasonScheduleBySeasonYearAsync(team,seasonYear) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year

##### Returns

Returns the NHL team schedule for the specified team and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20202021 |

<a name='M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleByYearAndMonthAsync-System-Int32,System-Int32,System-Int32-'></a>
### GetTeamSeasonScheduleByYearAndMonthAsync(teamId,year,month) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year and month

##### Returns

Returns the NHL team schedule for the specified team and season year and month

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The year, Example: 2020 |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The month, Example: 10 |

<a name='M-Nhl-Api-NhlGameApi-GetTeamSeasonScheduleByYearAndMonthAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-Int32,System-Int32-'></a>
### GetTeamSeasonScheduleByYearAndMonthAsync(team,year,month) `method`

##### Summary

Returns the NHL team schedule for the specified team and season year and month

##### Returns

Returns the NHL team schedule for the specified team and season year and month

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The year, Example: 2020 |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The month, Example: 10 |

<a name='M-Nhl-Api-NhlGameApi-GetTeamWeekScheduleByDateTimeAsync-System-Int32,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeAsync(teamId,dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for the specified team and the specified date and time

##### Returns

Returns the NHL team schedule for the specified team and the specified date and time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The team identifier, Example: 10 - Toronto Maples Leafs |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='M-Nhl-Api-NhlGameApi-GetTeamWeekScheduleByDateTimeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeAsync(team,dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for the specified team and the specified date and time

##### Returns

Returns the NHL team schedule for the specified team and the specified date and time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 54 - Vegas Golden Knights |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date and time, Example: 2020-10-02T00:00:00Z |

<a name='T-Nhl-Api-NhlLeagueApi'></a>
## NhlLeagueApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more

<a name='M-Nhl-Api-NhlLeagueApi-#ctor'></a>
### #ctor() `constructor`

##### Summary

The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more

##### Parameters

This constructor has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetAllRosterSeasonsByTeamAsync-System-Int32-'></a>
### GetAllRosterSeasonsByTeamAsync(teamId) `method`

##### Summary

Returns every active season for an NHL team and their participation in the NHL

##### Returns

Returns every active season for an NHL team and their participation in the NHL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |

<a name='M-Nhl-Api-NhlLeagueApi-GetAllRosterSeasonsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetAllRosterSeasonsByTeamAsync(team) `method`

##### Summary

Returns every active season for an NHL team and their participation in the NHL

##### Returns

Returns every active season for an NHL team and their participation in the NHL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 9 - Ottawa Senators |

<a name='M-Nhl-Api-NhlLeagueApi-GetAllSeasonsAsync'></a>
### GetAllSeasonsAsync() `method`

##### Summary

Returns all the NHL seasons for the NHL league

##### Returns

Returns all the NHL seasons for the NHL league

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueGameWeekScheduleByDateTimeAsync-System-DateTimeOffset-'></a>
### GetLeagueGameWeekScheduleByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL team schedule for a specific date using the DateTimeOffset

##### Returns

A result of the current NHL schedule by the specified date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | A [DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') for the specific date for the NHL schedule |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueMetadataInformation-System-Collections-Generic-List{System-Int32},System-Collections-Generic-List{System-String}-'></a>
### GetLeagueMetadataInformation(playerIds,teamIds) `method`

##### Summary

Returns the metadata information about the NHL league including players, teams and season states

##### Returns

Returns the metadata information about the NHL league including players, teams and season states

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerIds | [System.Collections.Generic.List{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Int32}') | A collection of NHL player identifiers, Example: [8478402,8478403] |
| teamIds | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') | A collection of NHL team identifiers, Example: [EDM, TOR] |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueMetadataInformation-System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Player-PlayerEnum},System-Collections-Generic-List{Nhl-Api-Models-Enumerations-Team-TeamEnum}-'></a>
### GetLeagueMetadataInformation(players,teams) `method`

##### Summary

Returns the metadata information about the NHL league including players, teams and season states

##### Returns

Returns the metadata information about the NHL league including players, teams and season states

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| players | [System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Player.PlayerEnum}') | A collection of NHL player identifiers, Example: [8478402,8478403] |
| teams | [System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Nhl.Api.Models.Enumerations.Team.TeamEnum}') | A collection of NHL team identifiers, Example: [EDM, TOR] |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueScheduleCalendarAsync-System-DateTimeOffset-'></a>
### GetLeagueScheduleCalendarAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league calendar schedule for the specified date and all applicable teams

##### Returns

Returns the NHL league calendar schedule for the specified date and all applicable teams

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL league schedule, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsByDateTimeOffsetAsync-System-DateTimeOffset-'></a>
### GetLeagueStandingsByDateTimeOffsetAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league standings for the current NHL season by the specified date

##### Returns

Return the NHL league standings for the specified date with specific team information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL season standing |

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueStandingsSeasonInformationAsync'></a>
### GetLeagueStandingsSeasonInformationAsync() `method`

##### Summary

Returns the NHL league standings for the all NHL seasons with specific league season information

##### Returns

Returns the NHL league standings information for each saeson since 1917-1918

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetLeagueWeekScheduleByDateTimeAsync-System-DateTimeOffset-'></a>
### GetLeagueWeekScheduleByDateTimeAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL league schedule for the specified date

##### Returns

Returns the NHL league schedule for the specified date

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL league schedule, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlLeagueApi-GetSourcesToWatchGamesAsync'></a>
### GetSourcesToWatchGamesAsync() `method`

##### Summary

Returns the collection of countries and where you can watch NHL games with links and more

##### Returns

Returns the collection of countries and where you can watch NHL games with links and more

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamColorsAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamColorsAsync(team) `method`

##### Summary

Returns the hexadecimal code for an NHL team's colors

##### Returns

An NHL team color scheme using hexadecimal codes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamColorsAsync-System-Int32-'></a>
### GetTeamColorsAsync(teamId) `method`

##### Summary

Returns the hexadecimal code for an NHL team's colors

##### Returns

An NHL team color scheme using hexadecimal codes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |

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

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamProspectsByTeamAsync-System-Int32-'></a>
### GetTeamProspectsByTeamAsync(teamId) `method`

##### Summary

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Returns

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamProspectsByTeamAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamProspectsByTeamAsync(team) `method`

##### Summary

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Returns

Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 10 - Toronto Maple Leafs |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamRosterBySeasonYearAsync-System-Int32,System-String-'></a>
### GetTeamRosterBySeasonYearAsync(teamId,seasonYear) `method`

##### Summary

Returns the NHL team roster for a specific team by the team identifier and season year

##### Returns

Returns the NHL team roster for a specific team by the team identifier and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifider, Example: 55 - Seattle Kraken |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20232024 |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamRosterBySeasonYearAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String-'></a>
### GetTeamRosterBySeasonYearAsync(team,seasonYear) `method`

##### Summary

Returns the NHL team roster for a specific team by the team and season year

##### Returns

Returns the NHL team roster for a specific team by the team identifier and season year

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifider, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information, Example: 9 - Ottawa Senators |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information, Example: 20232024 |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamScheduleBySeasonAsync-System-String,System-String-'></a>
### GetTeamScheduleBySeasonAsync(teamAbbreviation,seasonYear) `method`

##### Summary

This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season

##### Returns

A collection of all games in the requested season for the requested NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamAbbreviation | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The required team abbreviation for the NHL team, Example: WSH - Washington |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The eight digit number format for the season, Example: 20232024 |

<a name='M-Nhl-Api-NhlLeagueApi-GetTeamWeekScheduleByDateTimeOffsetAsync-System-String,System-DateTimeOffset-'></a>
### GetTeamWeekScheduleByDateTimeOffsetAsync(teamAbbreviation,dateTimeOffset) `method`

##### Summary

This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season

##### Returns

A collection of all games in the requested season for the requested NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamAbbreviation | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The required team abbreviation for the NHL team, Example: WSH - Washington |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date in which the request schedule for the team and for the week is request for |

<a name='M-Nhl-Api-NhlLeagueApi-GetTvScheduleBroadcastAsync-System-DateTimeOffset-'></a>
### GetTvScheduleBroadcastAsync(dateTimeOffset) `method`

##### Summary

Returns the NHL TV broadcasts for the specified date with information about the broadcasts

##### Returns

Returns the NHL TV broadcasts for the specified date with information about the broadcasts

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTimeOffset | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The date requested for the NHL TV broadcasts, Example: 2024-02-10 |

<a name='M-Nhl-Api-NhlLeagueApi-IsLeagueActiveAsync'></a>
### IsLeagueActiveAsync() `method`

##### Summary

Determines if the NHL league is active or inactive based on the current date and time

##### Returns

Returns true or false based on the current time and date

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-IsPlayoffSeasonActiveAsync'></a>
### IsPlayoffSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL playoff season is active

##### Returns

Returns a result of true or false if the NHL playoff season is active

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-IsPreSeasonActiveAsync'></a>
### IsPreSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL playoff pre season is active or inactive

##### Returns

Returns a result of true or false if the NHL pre-season is active

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlLeagueApi-IsRegularSeasonActiveAsync'></a>
### IsRegularSeasonActiveAsync() `method`

##### Summary

Returns the true or false if the NHL regular season is active or inactive

##### Returns

Returns a result of true or false if the NHL regular season is active

##### Parameters

This method has no parameters.

<a name='T-Nhl-Api-NhlPlayerApi'></a>
## NhlPlayerApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more

<a name='M-Nhl-Api-NhlPlayerApi-#ctor'></a>
### #ctor() `constructor`

##### Summary

The official unofficial NHL Player API providing various NHL information about players, draft prospects, rosters and more

##### Parameters

This constructor has no parameters.

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

<a name='M-Nhl-Api-NhlPlayerApi-GetGoalieInformationAsync-System-Int32-'></a>
### GetGoalieInformationAsync(playerId) `method`

##### Summary

Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8480313 - Logan Thompson |

<a name='M-Nhl-Api-NhlPlayerApi-GetGoalieInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetGoalieInformationAsync(player) `method`

##### Summary

Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8480313 - Logan Thompson, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlPlayerApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlPlayerApi-GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerHeadshotImageAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize-'></a>
### GetPlayerHeadshotImageAsync(player,playerHeadshotImageSize) `method`

##### Summary

Returns the NHL player's head shot image by the selected size

##### Returns

A URI endpoint with the image of an NHL player head shot image

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |
| playerHeadshotImageSize | [Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') | The size of the head shot image, see [PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') for more information |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerHeadshotImageAsync-System-Int32,Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize-'></a>
### GetPlayerHeadshotImageAsync(playerId,playerHeadshotImageSize) `method`

##### Summary

Returns the NHL player's head shot image by the selected size

##### Returns

A URI endpoint with the image of an NHL player head shot image

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |
| playerHeadshotImageSize | [Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') | The size of the head shot image, see [PlayerHeadshotImageSize](#T-Nhl-Api-Models-Enumerations-Player-PlayerHeadshotImageSize 'Nhl.Api.Models.Enumerations.Player.PlayerHeadshotImageSize') for more information |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerInformationAsync-System-Int32-'></a>
### GetPlayerInformationAsync(playerId) `method`

##### Summary

Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerInformationAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum-'></a>
### GetPlayerInformationAsync(player) `method`

##### Summary

Returns the NHL player's profile information including their birth date, birth city, height, weight, position and much more

##### Returns

Returns the NHL player's profile information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| player | [Nhl.Api.Models.Enumerations.Player.PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') | An NHL player id, Example: 8478402 - Connor McDavid, see [PlayerEnum](#T-Nhl-Api-Models-Enumerations-Player-PlayerEnum 'Nhl.Api.Models.Enumerations.Player.PlayerEnum') for more information on NHL players |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId,seasonYear,gameType) `method`

##### Summary

The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more

##### Returns

The collection of player season game logs with each game played including statistics, all available season and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The season year parameter for determining the season for the season, [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for all available seasons |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The game type parameter for determining the game type for the type of player season logs |

<a name='M-Nhl-Api-NhlPlayerApi-GetPlayerSpotlightAsync'></a>
### GetPlayerSpotlightAsync() `method`

##### Summary

Returns the NHL player's in the spotlight based on their recent performances

##### Returns

A collection of players and their information for players in the NHL spotlight

##### Parameters

This method has no parameters.

<a name='M-Nhl-Api-NhlPlayerApi-SearchAllActivePlayersAsync-System-String,System-Int32-'></a>
### SearchAllActivePlayersAsync(query,limit) `method`

##### Summary

Returns only active NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A parameter to limit the number of search results returned when searching for a player |

<a name='M-Nhl-Api-NhlPlayerApi-SearchAllPlayersAsync-System-String,System-Int32-'></a>
### SearchAllPlayersAsync(query,limit) `method`

##### Summary

Returns any active or inactive NHL players based on the search query provided

##### Returns

A collection of all NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | A parameter to limit the number of search results returned when searching for a player |

<a name='T-Nhl-Api-NhlStatisticsApi'></a>
## NhlStatisticsApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more

<a name='M-Nhl-Api-NhlStatisticsApi-#ctor'></a>
### #ctor() `constructor`

##### Summary

The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more

##### Parameters

This constructor has no parameters.

<a name='M-Nhl-Api-NhlStatisticsApi-GetGoalieStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32-'></a>
### GetGoalieStatsisticsLeadersAsync(goalieStatisticsType,seasonYear,gameType,limit) `method`

##### Summary

Returns the NHL goalie statistics leaders in the NHL for a specific goalie statistic type based on the game type and season year

##### Returns

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| goalieStatisticsType | [Nhl.Api.Enumerations.Statistic.GoalieStatisticsType](#T-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType 'Nhl.Api.Enumerations.Statistic.GoalieStatisticsType') | A player statistics type, [GoalieStatisticsType](#T-Nhl-Api-Enumerations-Statistic-GoalieStatisticsType 'Nhl.Api.Enumerations.Statistic.GoalieStatisticsType') for all the types of statisitics |
| seasonYear | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL season year to retrieve the player statistics leaders for, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL game type to retrieve the player statistics leaders for, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit to the number of results returned when reviewing the NHL player sta |

<a name='M-Nhl-Api-NhlStatisticsApi-GetSkaterStatsisticsLeadersAsync-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType,Nhl-Api-Enumerations-Game-GameType,System-String,System-Int32-'></a>
### GetSkaterStatsisticsLeadersAsync(playerStatisticsType,seasonYear,gameType,limit) `method`

##### Summary

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Returns

Returns the current NHL player statistics leaders in the NHL for a specific player statistic type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerStatisticsType | [Nhl.Api.Enumerations.Statistic.PlayerStatisticsType](#T-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType 'Nhl.Api.Enumerations.Statistic.PlayerStatisticsType') | A player statistics type, [PlayerStatisticsType](#T-Nhl-Api-Enumerations-Statistic-PlayerStatisticsType 'Nhl.Api.Enumerations.Statistic.PlayerStatisticsType') for all the types of statisitics |
| seasonYear | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL season year to retrieve the player statistics leaders for, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL game type to retrieve the player statistics leaders for, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |
| limit | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The limit to the number of results returned when reviewing the NHL player sta |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAndGameTypeAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetTeamStatisticsBySeasonAndGameTypeAsync(team,seasonYear,gameType) `method`

##### Summary

Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year

##### Returns

The NHL team season statistics for the specified season and game type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The team enumeration identifier, specifying which the NHL team, [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year to retrieve the team statistics, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL game type to retrieve the team statistics, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAndGameTypeAsync-System-Int32,System-String,Nhl-Api-Enumerations-Game-GameType-'></a>
### GetTeamStatisticsBySeasonAndGameTypeAsync(teamId,seasonYear,gameType) `method`

##### Summary

Returns the NHL team statistics for individual players for a specific NHL team statistic type based on the game type and season year

##### Returns

The NHL team season statistics for the specified season and game type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The NHL season year to retrieve the team statistics, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear 'Nhl.Api.Models.Season.SeasonYear') for more information on valid season years |
| gameType | [Nhl.Api.Enumerations.Game.GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') | The NHL game type to retrieve the team statistics, see [GameType](#T-Nhl-Api-Enumerations-Game-GameType 'Nhl.Api.Enumerations.Game.GameType') for more information on valid game types |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum-'></a>
### GetTeamStatisticsBySeasonAsync(team) `method`

##### Summary

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Returns

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The team enumeration identifier, specifying which the NHL team, [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |

<a name='M-Nhl-Api-NhlStatisticsApi-GetTeamStatisticsBySeasonAsync-System-Int32-'></a>
### GetTeamStatisticsBySeasonAsync(teamId) `method`

##### Summary

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Returns

Returns all the NHL team valid game types for all valid NHL seasons for the selected NHL team

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken |

