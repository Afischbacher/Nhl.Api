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

## Documentation 📖
Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.


## Contents

- [NhlApi](#T-Nhl-Api-NhlApi 'Nhl.Api.NhlApi')
  - [GetActiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetActiveFranchisesAsync 'Nhl.Api.NhlApi.GetActiveFranchisesAsync')
  - [GetActiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetActiveTeamsAsync 'Nhl.Api.NhlApi.GetActiveTeamsAsync')
  - [GetAllTeamsStatisticsBySeasonAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetAllTeamsStatisticsBySeasonAsync-System-String- 'Nhl.Api.NhlApi.GetAllTeamsStatisticsBySeasonAsync(System.String)')
  - [GetConferenceByIdAsync(conferenceId)](#M-Nhl-Api-NhlApi-GetConferenceByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetConferenceByIdAsync(System.Int32)')
  - [GetConferenceByIdAsync(conference)](#M-Nhl-Api-NhlApi-GetConferenceByIdAsync-Nhl-Api-Models-Enumerations-Conference-ConferenceEnum- 'Nhl.Api.NhlApi.GetConferenceByIdAsync(Nhl.Api.Models.Enumerations.Conference.ConferenceEnum)')
  - [GetConferencesAsync()](#M-Nhl-Api-NhlApi-GetConferencesAsync 'Nhl.Api.NhlApi.GetConferencesAsync')
  - [GetDivisionByIdAsync(divisionId)](#M-Nhl-Api-NhlApi-GetDivisionByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetDivisionByIdAsync(System.Int32)')
  - [GetDivisionByIdAsync(division)](#M-Nhl-Api-NhlApi-GetDivisionByIdAsync-Nhl-Api-Models-Enumerations-Division-DivisionEnum- 'Nhl.Api.NhlApi.GetDivisionByIdAsync(Nhl.Api.Models.Enumerations.Division.DivisionEnum)')
  - [GetDivisionsAsync()](#M-Nhl-Api-NhlApi-GetDivisionsAsync 'Nhl.Api.NhlApi.GetDivisionsAsync')
  - [GetDraftByYear(year)](#M-Nhl-Api-NhlApi-GetDraftByYear-System-String- 'Nhl.Api.NhlApi.GetDraftByYear(System.String)')
  - [GetEventTypesAsync()](#M-Nhl-Api-NhlApi-GetEventTypesAsync 'Nhl.Api.NhlApi.GetEventTypesAsync')
  - [GetFranchiseByIdAsync(franchiseId)](#M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetFranchiseByIdAsync(System.Int32)')
  - [GetFranchiseByIdAsync(franchise)](#M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-Nhl-Api-Models-Enumerations-Franchise-FranchiseEnum- 'Nhl.Api.NhlApi.GetFranchiseByIdAsync(Nhl.Api.Models.Enumerations.Franchise.FranchiseEnum)')
  - [GetFranchisesAsync()](#M-Nhl-Api-NhlApi-GetFranchisesAsync 'Nhl.Api.NhlApi.GetFranchisesAsync')
  - [GetGameScheduleAsync()](#M-Nhl-Api-NhlApi-GetGameScheduleAsync 'Nhl.Api.NhlApi.GetGameScheduleAsync')
  - [GetGameScheduleByDateAsync(date)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Nullable{System-DateTime}- 'Nhl.Api.NhlApi.GetGameScheduleByDateAsync(System.Nullable{System.DateTime})')
  - [GetGameScheduleByDateAsync(year,month,day)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsync-System-Int32,System-Int32,System-Int32- 'Nhl.Api.NhlApi.GetGameScheduleByDateAsync(System.Int32,System.Int32,System.Int32)')
  - [GetGameScheduleForTeamByDateAsync(team,startDate,endDate)](#M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-DateTime,System-DateTime- 'Nhl.Api.NhlApi.GetGameScheduleForTeamByDateAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.DateTime,System.DateTime)')
  - [GetGameScheduleForTeamByDateAsync(teamId,startDate,endDate)](#M-Nhl-Api-NhlApi-GetGameScheduleForTeamByDateAsync-System-Int32,System-DateTime,System-DateTime- 'Nhl.Api.NhlApi.GetGameScheduleForTeamByDateAsync(System.Int32,System.DateTime,System.DateTime)')
  - [GetGameStatusesAsync()](#M-Nhl-Api-NhlApi-GetGameStatusesAsync 'Nhl.Api.NhlApi.GetGameStatusesAsync')
  - [GetGameTypesAsync()](#M-Nhl-Api-NhlApi-GetGameTypesAsync 'Nhl.Api.NhlApi.GetGameTypesAsync')
  - [GetGoalieStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetGoalieStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetGoalieStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlApi-GetGoalieStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlApi.GetGoalieStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetInactiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetInactiveFranchisesAsync 'Nhl.Api.NhlApi.GetInactiveFranchisesAsync')
  - [GetInactiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetInactiveTeamsAsync 'Nhl.Api.NhlApi.GetInactiveTeamsAsync')
  - [GetLeagueAwardByIdAsync(awardId)](#M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLeagueAwardByIdAsync(System.Int32)')
  - [GetLeagueAwardByIdAsync(leagueAward)](#M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-Nhl-Api-Models-Enumerations-Award-AwardEnum- 'Nhl.Api.NhlApi.GetLeagueAwardByIdAsync(Nhl.Api.Models.Enumerations.Award.AwardEnum)')
  - [GetLeagueAwardsAsync()](#M-Nhl-Api-NhlApi-GetLeagueAwardsAsync 'Nhl.Api.NhlApi.GetLeagueAwardsAsync')
  - [GetLeagueProspectByIdAsync(prospectId)](#M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetLeagueProspectByIdAsync(System.Int32)')
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
  - [GetLiveGameFeedById(liveGameFeedId)](#M-Nhl-Api-NhlApi-GetLiveGameFeedById-System-Int32- 'Nhl.Api.NhlApi.GetLiveGameFeedById(System.Int32)')
  - [GetPlayTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayTypesAsync 'Nhl.Api.NhlApi.GetPlayTypesAsync')
  - [GetPlayerByIdAsync(playerId)](#M-Nhl-Api-NhlApi-GetPlayerByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetPlayerByIdAsync(System.Int32)')
  - [GetPlayerByIdAsync(player)](#M-Nhl-Api-NhlApi-GetPlayerByIdAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum- 'Nhl.Api.NhlApi.GetPlayerByIdAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum)')
  - [GetPlayerStatisticsBySeasonAsync(playerId,seasonYear)](#M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetPlayerStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetPlayerStatisticsBySeasonAsync(player,seasonYear)](#M-Nhl-Api-NhlApi-GetPlayerStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Player-PlayerEnum,System-String- 'Nhl.Api.NhlApi.GetPlayerStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Player.PlayerEnum,System.String)')
  - [GetPlayoffTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayoffTournamentTypesAsync 'Nhl.Api.NhlApi.GetPlayoffTournamentTypesAsync')
  - [GetSeasonByYearAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetSeasonByYearAsync-System-String- 'Nhl.Api.NhlApi.GetSeasonByYearAsync(System.String)')
  - [GetSeasonsAsync()](#M-Nhl-Api-NhlApi-GetSeasonsAsync 'Nhl.Api.NhlApi.GetSeasonsAsync')
  - [GetStatisticTypesAsync()](#M-Nhl-Api-NhlApi-GetStatisticTypesAsync 'Nhl.Api.NhlApi.GetStatisticTypesAsync')
  - [GetTeamByIdAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamByIdAsync-System-Int32- 'Nhl.Api.NhlApi.GetTeamByIdAsync(System.Int32)')
  - [GetTeamByIdAsync(team)](#M-Nhl-Api-NhlApi-GetTeamByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum- 'Nhl.Api.NhlApi.GetTeamByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum)')
  - [GetTeamLogoAsync(teamId,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-System-Int32,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(System.Int32,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamLogoAsync(teamEnum,teamLogoType)](#M-Nhl-Api-NhlApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType- 'Nhl.Api.NhlApi.GetTeamLogoAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,Nhl.Api.Models.Team.TeamLogoType)')
  - [GetTeamStatisticsByIdAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsByIdAsync(System.Int32,System.String)')
  - [GetTeamStatisticsByIdAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsByIdAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamStatisticsBySeasonAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-System-Int32,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(System.Int32,System.String)')
  - [GetTeamStatisticsBySeasonAsync(team,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsBySeasonAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,System-String- 'Nhl.Api.NhlApi.GetTeamStatisticsBySeasonAsync(Nhl.Api.Models.Enumerations.Team.TeamEnum,System.String)')
  - [GetTeamsAsync()](#M-Nhl-Api-NhlApi-GetTeamsAsync 'Nhl.Api.NhlApi.GetTeamsAsync')
  - [GetTeamsByIdsAsync(teamIds)](#M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{System-Int32}- 'Nhl.Api.NhlApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{System.Int32})')
  - [GetTeamsByIdsAsync(teams)](#M-Nhl-Api-NhlApi-GetTeamsByIdsAsync-System-Collections-Generic-IEnumerable{Nhl-Api-Models-Enumerations-Team-TeamEnum}- 'Nhl.Api.NhlApi.GetTeamsByIdsAsync(System.Collections.Generic.IEnumerable{Nhl.Api.Models.Enumerations.Team.TeamEnum})')
  - [GetTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetTournamentTypesAsync 'Nhl.Api.NhlApi.GetTournamentTypesAsync')
  - [SearchAllPlayersAsync(query)](#M-Nhl-Api-NhlApi-SearchAllPlayersAsync-System-String- 'Nhl.Api.NhlApi.SearchAllPlayersAsync(System.String)')
  - [SearchLeagueTeamRosterMembersAsync(query)](#M-Nhl-Api-NhlApi-SearchLeagueTeamRosterMembersAsync-System-String- 'Nhl.Api.NhlApi.SearchLeagueTeamRosterMembersAsync(System.String)')

<a name='T-Nhl-Api-NhlApi'></a>
## NhlApi `type`

##### Namespace

Nhl.Api

##### Summary

The official unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more

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

<a name='M-Nhl-Api-NhlApi-GetDraftByYear-System-String-'></a>
### GetDraftByYear(year) `method`

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

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule 'Nhl.Api.Models.Game.GameSchedule') for more information

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

Returns all of the NHL league standing types, this includes playoff and preseason standings

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

<a name='M-Nhl-Api-NhlApi-GetLiveGameFeedById-System-Int32-'></a>
### GetLiveGameFeedById(liveGameFeedId) `method`

##### Summary

Returns the live game feed content for an NHL game

##### Returns

A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| liveGameFeedId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The live game feed id, Example: 2021020087 |

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

Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The NHL team identifier - Seattle Kraken: 55 |
| teamLogoType | [Nhl.Api.Models.Team.TeamLogoType](#T-Nhl-Api-Models-Team-TeamLogoType 'Nhl.Api.Models.Team.TeamLogoType') | The NHL team logo image type, based on the background of light or dark |

<a name='M-Nhl-Api-NhlApi-GetTeamLogoAsync-Nhl-Api-Models-Enumerations-Team-TeamEnum,Nhl-Api-Models-Team-TeamLogoType-'></a>
### GetTeamLogoAsync(teamEnum,teamLogoType) `method`

##### Summary

Returns an the NHL team logo based a dark or light preference using the NHL team enumeration

##### Returns

Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamEnum | [Nhl.Api.Models.Enumerations.Team.TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') | The NHL team identifier, 55 - Seattle Kraken, see [TeamEnum](#T-Nhl-Api-Models-Enumerations-Team-TeamEnum 'Nhl.Api.Models.Enumerations.Team.TeamEnum') for more information |
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

Returns all of the active rostered NHL players based on the search query provided+

##### Returns

A collection of all rostered and active NHL players based on the search query provided

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" |


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
