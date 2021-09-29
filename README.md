[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml)
[![Issues](https://img.shields.io/github/issues/Afischbacher/Nhl.Api.svg)](https://github.com/Afischbacher/Nhl.Api/issues)
[![Total Lines](https://sloc.xyz/github/Afischbacher/Nhl.Api)](https://GitHub.com/Afischbacher/Nhl.Api)
[![License](https://img.shields.io/github/license/Afischbacher/Nhl.Api)](https://github.com/Afischbacher/Nhl.Api/blob/master/LICENSE)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Afischbacher/Nhl.Api/graphs/commit-activity)

# The Official Unofficial .NET NHL API 
A C# .NET Standard 2.0 library for the .NET NHL API
## Installing Nhl.Api 🏒
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

### .NET Core
`builder.Services.AddTransient<INhlApi, NhlApi>();`

### Unity
`container.RegisterType<INhlApi, NhlApi>();`

### AutoFac
`builder.RegisterType<NhlApi>().As<INhlApi>();`

### Simple Object Creation
`var nhlApi = new NhlApi();`

## Documentation 📖
Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.

## Contents

-  [INhlApi](#T-Nhl-Api-INhlApi  'Nhl.Api.INhlApi')

-  [GetActiveFranchisesAsync()](#M-Nhl-Api-INhlApi-GetActiveFranchisesAsync  'Nhl.Api.INhlApi.GetActiveFranchisesAsync')

-  [GetActiveTeamsAsync()](#M-Nhl-Api-INhlApi-GetActiveTeamsAsync  'Nhl.Api.INhlApi.GetActiveTeamsAsync')

-  [GetConferenceByIdAsync(conferenceId)](#M-Nhl-Api-INhlApi-GetConferenceByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetConferenceByIdAsync(System.Int32)')

-  [GetConferencesAsync()](#M-Nhl-Api-INhlApi-GetConferencesAsync  'Nhl.Api.INhlApi.GetConferencesAsync')

-  [GetDivisionByIdAsync(divisionId)](#M-Nhl-Api-INhlApi-GetDivisionByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetDivisionByIdAsync(System.Int32)')

-  [GetDivisionsAsync()](#M-Nhl-Api-INhlApi-GetDivisionsAsync  'Nhl.Api.INhlApi.GetDivisionsAsync')

-  [GetDraftByYear(year)](#M-Nhl-Api-INhlApi-GetDraftByYear-System-String-  'Nhl.Api.INhlApi.GetDraftByYear(System.String)')

-  [GetEventTypesAsync()](#M-Nhl-Api-INhlApi-GetEventTypesAsync  'Nhl.Api.INhlApi.GetEventTypesAsync')

-  [GetFranchiseByIdAsync()](#M-Nhl-Api-INhlApi-GetFranchiseByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetFranchiseByIdAsync(System.Int32)')

-  [GetFranchisesAsync()](#M-Nhl-Api-INhlApi-GetFranchisesAsync  'Nhl.Api.INhlApi.GetFranchisesAsync')

-  [GetGameScheduleByDateAsnyc(date)](#M-Nhl-Api-INhlApi-GetGameScheduleByDateAsnyc-System-Nullable{System-DateTime}-  'Nhl.Api.INhlApi.GetGameScheduleByDateAsnyc(System.Nullable{System.DateTime})')

-  [GetGameScheduleByDateAsnyc(year,month,day)](#M-Nhl-Api-INhlApi-GetGameScheduleByDateAsnyc-System-Int32,System-Int32,System-Int32-  'Nhl.Api.INhlApi.GetGameScheduleByDateAsnyc(System.Int32,System.Int32,System.Int32)')

-  [GetGameStatusesAsync()](#M-Nhl-Api-INhlApi-GetGameStatusesAsync  'Nhl.Api.INhlApi.GetGameStatusesAsync')

-  [GetGameTypesAsync()](#M-Nhl-Api-INhlApi-GetGameTypesAsync  'Nhl.Api.INhlApi.GetGameTypesAsync')

-  [GetInactiveFranchisesAsync()](#M-Nhl-Api-INhlApi-GetInactiveFranchisesAsync  'Nhl.Api.INhlApi.GetInactiveFranchisesAsync')

-  [GetInactiveTeamsAsync()](#M-Nhl-Api-INhlApi-GetInactiveTeamsAsync  'Nhl.Api.INhlApi.GetInactiveTeamsAsync')

-  [GetLeagueAwardByIdAsync(leagueAwardId)](#M-Nhl-Api-INhlApi-GetLeagueAwardByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetLeagueAwardByIdAsync(System.Int32)')

-  [GetLeagueAwardsAsync()](#M-Nhl-Api-INhlApi-GetLeagueAwardsAsync  'Nhl.Api.INhlApi.GetLeagueAwardsAsync')

-  [GetLeagueProspectByIdAsync()](#M-Nhl-Api-INhlApi-GetLeagueProspectByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetLeagueProspectByIdAsync(System.Int32)')

-  [GetLeagueProspectsAsync()](#M-Nhl-Api-INhlApi-GetLeagueProspectsAsync  'Nhl.Api.INhlApi.GetLeagueProspectsAsync')

-  [GetLeagueStandingTypesAsync()](#M-Nhl-Api-INhlApi-GetLeagueStandingTypesAsync  'Nhl.Api.INhlApi.GetLeagueStandingTypesAsync')

-  [GetLeagueStandingsAsync(date)](#M-Nhl-Api-INhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-  'Nhl.Api.INhlApi.GetLeagueStandingsAsync(System.Nullable{System.DateTime})')

-  [GetLeagueVenueByIdAsync(venueId)](#M-Nhl-Api-INhlApi-GetLeagueVenueByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetLeagueVenueByIdAsync(System.Int32)')

-  [GetLeagueVenuesAsync()](#M-Nhl-Api-INhlApi-GetLeagueVenuesAsync  'Nhl.Api.INhlApi.GetLeagueVenuesAsync')

-  [GetPlayTypesAsync()](#M-Nhl-Api-INhlApi-GetPlayTypesAsync  'Nhl.Api.INhlApi.GetPlayTypesAsync')

-  [GetPlayerByIdAsync(playerId)](#M-Nhl-Api-INhlApi-GetPlayerByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetPlayerByIdAsync(System.Int32)')

-  [GetPlayoffTournamentTypesAsync()](#M-Nhl-Api-INhlApi-GetPlayoffTournamentTypesAsync  'Nhl.Api.INhlApi.GetPlayoffTournamentTypesAsync')

-  [GetSeasonByYearAsync(seasonYear)](#M-Nhl-Api-INhlApi-GetSeasonByYearAsync-System-String-  'Nhl.Api.INhlApi.GetSeasonByYearAsync(System.String)')

-  [GetSeasonsAsync()](#M-Nhl-Api-INhlApi-GetSeasonsAsync  'Nhl.Api.INhlApi.GetSeasonsAsync')

-  [GetStatisticTypesAsync()](#M-Nhl-Api-INhlApi-GetStatisticTypesAsync  'Nhl.Api.INhlApi.GetStatisticTypesAsync')

-  [GetTeamByIdAsync(teamId)](#M-Nhl-Api-INhlApi-GetTeamByIdAsync-System-Int32-  'Nhl.Api.INhlApi.GetTeamByIdAsync(System.Int32)')

-  [GetTeamStatisticsByIdAsync(teamId,seasonYear)](#M-Nhl-Api-INhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-  'Nhl.Api.INhlApi.GetTeamStatisticsByIdAsync(System.Int32,System.String)')

-  [GetTeamsAsync()](#M-Nhl-Api-INhlApi-GetTeamsAsync  'Nhl.Api.INhlApi.GetTeamsAsync')

-  [GetTournamentTypesAsync()](#M-Nhl-Api-INhlApi-GetTournamentTypesAsync  'Nhl.Api.INhlApi.GetTournamentTypesAsync')

-  [NhlApi](#T-Nhl-Api-NhlApi  'Nhl.Api.NhlApi')

-  [GetActiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetActiveFranchisesAsync  'Nhl.Api.NhlApi.GetActiveFranchisesAsync')

-  [GetActiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetActiveTeamsAsync  'Nhl.Api.NhlApi.GetActiveTeamsAsync')

-  [GetConferenceByIdAsync(conferenceId)](#M-Nhl-Api-NhlApi-GetConferenceByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetConferenceByIdAsync(System.Int32)')

-  [GetConferencesAsync()](#M-Nhl-Api-NhlApi-GetConferencesAsync  'Nhl.Api.NhlApi.GetConferencesAsync')

-  [GetDivisionByIdAsync(divisionId)](#M-Nhl-Api-NhlApi-GetDivisionByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetDivisionByIdAsync(System.Int32)')

-  [GetDivisionsAsync()](#M-Nhl-Api-NhlApi-GetDivisionsAsync  'Nhl.Api.NhlApi.GetDivisionsAsync')

-  [GetDraftByYear(year)](#M-Nhl-Api-NhlApi-GetDraftByYear-System-String-  'Nhl.Api.NhlApi.GetDraftByYear(System.String)')

-  [GetEventTypesAsync()](#M-Nhl-Api-NhlApi-GetEventTypesAsync  'Nhl.Api.NhlApi.GetEventTypesAsync')

-  [GetFranchiseByIdAsync(franchiseId)](#M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetFranchiseByIdAsync(System.Int32)')

-  [GetFranchisesAsync()](#M-Nhl-Api-NhlApi-GetFranchisesAsync  'Nhl.Api.NhlApi.GetFranchisesAsync')

-  [GetGameScheduleByDateAsnyc(date)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsnyc-System-Nullable{System-DateTime}-  'Nhl.Api.NhlApi.GetGameScheduleByDateAsnyc(System.Nullable{System.DateTime})')

-  [GetGameScheduleByDateAsnyc(year,month,day)](#M-Nhl-Api-NhlApi-GetGameScheduleByDateAsnyc-System-Int32,System-Int32,System-Int32-  'Nhl.Api.NhlApi.GetGameScheduleByDateAsnyc(System.Int32,System.Int32,System.Int32)')

-  [GetGameStatusesAsync()](#M-Nhl-Api-NhlApi-GetGameStatusesAsync  'Nhl.Api.NhlApi.GetGameStatusesAsync')

-  [GetGameTypesAsync()](#M-Nhl-Api-NhlApi-GetGameTypesAsync  'Nhl.Api.NhlApi.GetGameTypesAsync')

-  [GetInactiveFranchisesAsync()](#M-Nhl-Api-NhlApi-GetInactiveFranchisesAsync  'Nhl.Api.NhlApi.GetInactiveFranchisesAsync')

-  [GetInactiveTeamsAsync()](#M-Nhl-Api-NhlApi-GetInactiveTeamsAsync  'Nhl.Api.NhlApi.GetInactiveTeamsAsync')

-  [GetLeagueAwardByIdAsync()](#M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetLeagueAwardByIdAsync(System.Int32)')

-  [GetLeagueAwardsAsync()](#M-Nhl-Api-NhlApi-GetLeagueAwardsAsync  'Nhl.Api.NhlApi.GetLeagueAwardsAsync')

-  [GetLeagueProspectByIdAsync()](#M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetLeagueProspectByIdAsync(System.Int32)')

-  [GetLeagueProspectsAsync()](#M-Nhl-Api-NhlApi-GetLeagueProspectsAsync  'Nhl.Api.NhlApi.GetLeagueProspectsAsync')

-  [GetLeagueStandingTypesAsync()](#M-Nhl-Api-NhlApi-GetLeagueStandingTypesAsync  'Nhl.Api.NhlApi.GetLeagueStandingTypesAsync')

-  [GetLeagueStandingsAsync(date)](#M-Nhl-Api-NhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-  'Nhl.Api.NhlApi.GetLeagueStandingsAsync(System.Nullable{System.DateTime})')

-  [GetLeagueVenueByIdAsync(id)](#M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetLeagueVenueByIdAsync(System.Int32)')

-  [GetLeagueVenuesAsync()](#M-Nhl-Api-NhlApi-GetLeagueVenuesAsync  'Nhl.Api.NhlApi.GetLeagueVenuesAsync')

-  [GetPlayTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayTypesAsync  'Nhl.Api.NhlApi.GetPlayTypesAsync')

-  [GetPlayerByIdAsync(playerId)](#M-Nhl-Api-NhlApi-GetPlayerByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetPlayerByIdAsync(System.Int32)')

-  [GetPlayoffTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetPlayoffTournamentTypesAsync  'Nhl.Api.NhlApi.GetPlayoffTournamentTypesAsync')

-  [GetSeasonByYearAsync(seasonYear)](#M-Nhl-Api-NhlApi-GetSeasonByYearAsync-System-String-  'Nhl.Api.NhlApi.GetSeasonByYearAsync(System.String)')

-  [GetSeasonsAsync()](#M-Nhl-Api-NhlApi-GetSeasonsAsync  'Nhl.Api.NhlApi.GetSeasonsAsync')

-  [GetStatisticTypesAsync()](#M-Nhl-Api-NhlApi-GetStatisticTypesAsync  'Nhl.Api.NhlApi.GetStatisticTypesAsync')

-  [GetTeamByIdAsync(teamId)](#M-Nhl-Api-NhlApi-GetTeamByIdAsync-System-Int32-  'Nhl.Api.NhlApi.GetTeamByIdAsync(System.Int32)')

-  [GetTeamStatisticsByIdAsync(teamId,seasonYear)](#M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-  'Nhl.Api.NhlApi.GetTeamStatisticsByIdAsync(System.Int32,System.String)')

-  [GetTeamsAsync()](#M-Nhl-Api-NhlApi-GetTeamsAsync  'Nhl.Api.NhlApi.GetTeamsAsync')

-  [GetTournamentTypesAsync()](#M-Nhl-Api-NhlApi-GetTournamentTypesAsync  'Nhl.Api.NhlApi.GetTournamentTypesAsync')

  

<a  name='T-Nhl-Api-INhlApi'></a>

## INhlApi `type`

  

##### Namespace

  

Nhl.Api

  

##### Summary

  

The Unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more

  

<a  name='M-Nhl-Api-INhlApi-GetActiveFranchisesAsync'></a>

### GetActiveFranchisesAsync() `method`

  

##### Summary

  

Returns all active NHL franchises

  

##### Returns

  

A collection of all active NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetActiveTeamsAsync'></a>

### GetActiveTeamsAsync() `method`

  

##### Summary

  

Returns all active NHL teams

  

##### Returns

  

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetConferenceByIdAsync-System-Int32-'></a>

### GetConferenceByIdAsync(conferenceId) `method`

  

##### Summary

  

Returns all of the NHL conferences

  

##### Returns

  

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference  'Nhl.Api.Models.Conference.Conference') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| conferenceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL conference id, Example: 6 - Eastern Conference |

  

<a  name='M-Nhl-Api-INhlApi-GetConferencesAsync'></a>

### GetConferencesAsync() `method`

  

##### Summary

  

Returns all of the NHL conferences

  

##### Returns

  

A collection of all the NHL conferences, see [Conference](#T-Nhl-Api-Models-Conference-Conference  'Nhl.Api.Models.Conference.Conference') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetDivisionByIdAsync-System-Int32-'></a>

### GetDivisionByIdAsync(divisionId) `method`

  

##### Summary

  

Returns an NHL division by the division id

  

##### Returns

  

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division  'Nhl.Api.Models.Division.Division') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| divisionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL division id, Example: 17 - Atlantic divison |

  

<a  name='M-Nhl-Api-INhlApi-GetDivisionsAsync'></a>

### GetDivisionsAsync() `method`

  

##### Summary

  

Returns all of the NHL divisions

  

##### Returns

  

A collection of all the NHL divisions, see [Division](#T-Nhl-Api-Models-Division-Division  'Nhl.Api.Models.Division.Division') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetDraftByYear-System-String-'></a>

### GetDraftByYear(year) `method`

  

##### Summary

  

Returns the NHL league draft based on a specific year based on the 4 character draft year, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear  'Nhl.Api.Models.Draft.DraftYear') for more information. Some NHL draft years responses provide very large JSON payloads

  

##### Returns

  

The NHL league draft, which includes draft rounds, player information and more, see [LeagueDraft](#T-Nhl-Api-Models-Draft-LeagueDraft  'Nhl.Api.Models.Draft.LeagueDraft') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | The specified year of the NHL draft, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear  'Nhl.Api.Models.Draft.DraftYear') for all NHL draft years |

  

<a  name='M-Nhl-Api-INhlApi-GetEventTypesAsync'></a>

### GetEventTypesAsync() `method`

  

##### Summary

  

Return's all the event types within the NHL

  

##### Returns

  

A collection of event types within the NHL, see [EventType](#T-Nhl-Api-Models-Event-EventType  'Nhl.Api.Models.Event.EventType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetFranchiseByIdAsync-System-Int32-'></a>

### GetFranchiseByIdAsync() `method`

  

##### Summary

  

Returns an NHL franchise by the franchise id

  

##### Returns

  

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetFranchisesAsync'></a>

### GetFranchisesAsync() `method`

  

##### Summary

  

Returns all NHL franchises, including information such as team name, location and more

  

##### Returns

  

A collection of all NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetGameScheduleByDateAsnyc-System-Nullable{System-DateTime}-'></a>

### GetGameScheduleByDateAsnyc(date) `method`

  

##### Summary

  

Return's the NHL game schedule based on the provided [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime  'System.DateTime'). If the date is null, it will provide today's current NHL game schedule

  

##### Returns

  

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule  'Nhl.Api.Models.Game.GameSchedule') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable  'System.Nullable{System.DateTime}') | The requested date for the NHL game schedule |

  

<a  name='M-Nhl-Api-INhlApi-GetGameScheduleByDateAsnyc-System-Int32,System-Int32,System-Int32-'></a>

### GetGameScheduleByDateAsnyc(year,month,day) `method`

  

##### Summary

  

Return's the NHL game schedule based on the provided year, month and day

  

##### Returns

  

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule  'Nhl.Api.Models.Game.GameSchedule') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested year for the NHL game schedule |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested month for the NHL game schedule |
| day | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested day for the NHL game schedule |

  

<a  name='M-Nhl-Api-INhlApi-GetGameStatusesAsync'></a>

### GetGameStatusesAsync() `method`

  

##### Summary

  

Returns all of the valid NHL game statuses of an NHL game

  

##### Returns

  

A collection of NHL game statues, see [GameStatus](#T-Nhl-Api-Models-Game-GameStatus  'Nhl.Api.Models.Game.GameStatus') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetGameTypesAsync'></a>

### GetGameTypesAsync() `method`

  

##### Summary

  

Returns all of the NHL game types within a season and within special events

  

##### Returns

  

A collection of NHL and other sporting event game types, see [GameType](#T-Nhl-Api-Models-Game-GameType  'Nhl.Api.Models.Game.GameType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetInactiveFranchisesAsync'></a>

### GetInactiveFranchisesAsync() `method`

  

##### Summary

  

Returns all inactive NHL franchises

  

##### Returns

  

A collection of all inactive NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetInactiveTeamsAsync'></a>

### GetInactiveTeamsAsync() `method`

  

##### Summary

  

Returns all inactive NHL teams

  

##### Returns

  

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueAwardByIdAsync-System-Int32-'></a>

### GetLeagueAwardByIdAsync(leagueAwardId) `method`

  

##### Summary

  

Returns an NHL award by the award id

Example: 1 - Stanley Cup

  

##### Returns

  

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award  'Nhl.Api.Models.Award.Award') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| leagueAwardId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL league award identifier |


<a  name='M-Nhl-Api-INhlApi-GetLeagueAwardsAsync'></a>

### GetLeagueAwardsAsync() `method`

  

##### Summary

  

Returns all of the NHL awards, including the description, history, and images

  

##### Returns

  

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award  'Nhl.Api.Models.Award.Award') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueProspectByIdAsync-System-Int32-'></a>

### GetLeagueProspectByIdAsync() `method`

  

##### Summary

  

Returns an NHL prospect profile by their prospect id

  

##### Returns

  

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile  'Nhl.Api.Models.Player.ProspectProfile') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueProspectsAsync'></a>

### GetLeagueProspectsAsync() `method`

  

##### Summary

  

Returns all the NHL league prospects The NHL prospects response provides a very large JSON payload

  

##### Returns

  

A collection of all the NHL prospects, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile  'Nhl.Api.Models.Player.ProspectProfile') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueStandingTypesAsync'></a>

### GetLeagueStandingTypesAsync() `method`

  

##### Summary

  

Returns all of the NHL league standing types, this includes playoff and preseason standings

  

##### Returns

  

A collection of all the NHL standing types, see [LeagueStandingType](#T-Nhl-Api-Models-Standing-LeagueStandingType  'Nhl.Api.Models.Standing.LeagueStandingType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-'></a>

### GetLeagueStandingsAsync(date) `method`

  

##### Summary

  

Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings

  

##### Returns

  

A collection of all the leauge standings

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable  'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings |

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueVenueByIdAsync-System-Int32-'></a>

### GetLeagueVenueByIdAsync(venueId) `method`

  

##### Summary

  

Returns an NHL venue by the venue id

Example: 5058 - Canada Life Centre

  

##### Returns

  

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue  'Nhl.Api.Models.Venue.LeagueVenue') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| venueId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The specified id of an NHL venue, |

  

<a  name='M-Nhl-Api-INhlApi-GetLeagueVenuesAsync'></a>

### GetLeagueVenuesAsync() `method`

  

##### Summary

  

Returns all of the NHL venue's, including arenas and stadiums This is not a comprehnsive list of all NHL stadiums and arenas

  

##### Returns

  

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue  'Nhl.Api.Models.Venue.LeagueVenue') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetPlayTypesAsync'></a>

### GetPlayTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the play types within the duration of an NHL game

  

##### Returns

  

A collection of distinct play types, see [PlayType](#T-Nhl-Api-Models-Game-PlayType  'Nhl.Api.Models.Game.PlayType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetPlayerByIdAsync-System-Int32-'></a>

### GetPlayerByIdAsync(playerId) `method`

  

##### Summary

  

Returns an NHL player by their player id, includes information such as age, weight, position and more

  

##### Returns

  

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player  'Nhl.Api.Models.Player.Player') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | An NHL player id, Example: 8478402 - Connor McDavid |

  

<a  name='M-Nhl-Api-INhlApi-GetPlayoffTournamentTypesAsync'></a>

### GetPlayoffTournamentTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the different types of playoff tournaments in the NHL

  

##### Returns

  

A collection of tournament types, see [PlayoffTournamentType](#T-Nhl-Api-Models-Game-PlayoffTournamentType  'Nhl.Api.Models.Game.PlayoffTournamentType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetSeasonByYearAsync-System-String-'></a>

### GetSeasonByYearAsync(seasonYear) `method`

  

##### Summary

  

Returns the NHL season information based on the provided season years

  

##### Returns

  

An NHL season based on the provided season year, Example - "20172018"

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | See [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear  'Nhl.Api.Models.Season.SeasonYear') for all valid season year arguments |

  

<a  name='M-Nhl-Api-INhlApi-GetSeasonsAsync'></a>

### GetSeasonsAsync() `method`

  

##### Summary

  

Returns all of the NHL seasons since the inception of the league in 1917-1918

  

##### Returns

  

A collection of seasons since the inception of the NHL

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetStatisticTypesAsync'></a>

### GetStatisticTypesAsync() `method`

  

##### Summary

  

Returns all distinct types of NHL statistics types

  

##### Returns

  

A collection of all the various NHL statistics types, see [StatisticTypes](#T-Nhl-Api-Models-Statistics-StatisticTypes  'Nhl.Api.Models.Statistics.StatisticTypes') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetTeamByIdAsync-System-Int32-'></a>

### GetTeamByIdAsync(teamId) `method`

  

##### Summary

  

Returns an NHL team by the team id

  

##### Returns

  

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL team id, Example: 10 - Toronto Maple Leafs |

  

<a  name='M-Nhl-Api-INhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-'></a>

### GetTeamStatisticsByIdAsync(teamId,seasonYear) `method`

  

##### Summary

  

Returns a specified NHL team's statistics for the the specified season, the most recent season statistics will be returned

  

##### Returns

  

A collection of all the specified NHL team statistics for the specified season

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL team id, example: Toronto Maple Leafs - 10 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear  'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, example: 20202021 |

  

<a  name='M-Nhl-Api-INhlApi-GetTeamsAsync'></a>

### GetTeamsAsync() `method`

  

##### Summary

  

Returns all active and inactive NHL teams

  

##### Returns

  

A collection of all NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-INhlApi-GetTournamentTypesAsync'></a>

### GetTournamentTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the different types of tournaments in the hockey

  

##### Returns

  

A collection of tournament types, see [TournamentType](#T-Nhl-Api-Models-Game-TournamentType  'Nhl.Api.Models.Game.TournamentType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='T-Nhl-Api-NhlApi'></a>

## NhlApi `type`

  

##### Namespace

  

Nhl.Api

  

##### Summary

  

The Unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more

  

<a  name='M-Nhl-Api-NhlApi-GetActiveFranchisesAsync'></a>

### GetActiveFranchisesAsync() `method`

  

##### Summary

  

Returns all active NHL franchises

  

##### Returns

  

A collection of all active NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetActiveTeamsAsync'></a>

### GetActiveTeamsAsync() `method`

  

##### Summary

  

Returns all active NHL teams

  

##### Returns

  

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetConferenceByIdAsync-System-Int32-'></a>

### GetConferenceByIdAsync(conferenceId) `method`

  

##### Summary

  

Returns all of the NHL conferences

  

##### Returns

  

An NHL conference, see [Conference](#T-Nhl-Api-Models-Conference-Conference  'Nhl.Api.Models.Conference.Conference') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| conferenceId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL conference id, example: Eastern Conference is the number 6 |

  

<a  name='M-Nhl-Api-NhlApi-GetConferencesAsync'></a>

### GetConferencesAsync() `method`

  

##### Summary

  

Returns all of the NHL conferences

  

##### Returns

  

A collection of all the NHL conferences, see [Conference](#T-Nhl-Api-Models-Conference-Conference  'Nhl.Api.Models.Conference.Conference') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetDivisionByIdAsync-System-Int32-'></a>

### GetDivisionByIdAsync(divisionId) `method`

  

##### Summary

  

Returns an NHL division by the division id

  

##### Returns

  

Returns an NHL division, see [Division](#T-Nhl-Api-Models-Division-Division  'Nhl.Api.Models.Division.Division') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| divisionId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL division id, example: Atlantic divison is the number 17 |

  

<a  name='M-Nhl-Api-NhlApi-GetDivisionsAsync'></a>

### GetDivisionsAsync() `method`

  

##### Summary

  

Returns all of the NHL divisions

  

##### Returns

  

A collection of all the NHL divisions, see [Division](#T-Nhl-Api-Models-Division-Division  'Nhl.Api.Models.Division.Division') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetDraftByYear-System-String-'></a>

### GetDraftByYear(year) `method`

  

##### Summary

  

Returns the NHL league draft based on a specific year based on the 4 character draft year, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear  'Nhl.Api.Models.Draft.DraftYear') for more information. Some responses provide very large JSON payloads

  

##### Returns

  

The NHL league draft, which includes draft rounds, player information and more, see [LeagueDraft](#T-Nhl-Api-Models-Draft-LeagueDraft  'Nhl.Api.Models.Draft.LeagueDraft') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | The specified year of the NHL draft, see [DraftYear](#T-Nhl-Api-Models-Draft-DraftYear  'Nhl.Api.Models.Draft.DraftYear') for all NHL draft years |

  

<a  name='M-Nhl-Api-NhlApi-GetEventTypesAsync'></a>

### GetEventTypesAsync() `method`

  

##### Summary

  

Return's all the event types within the NHL

  

##### Returns

  

A collection of event types within the NHL, see [EventType](#T-Nhl-Api-Models-Event-EventType  'Nhl.Api.Models.Event.EventType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetFranchiseByIdAsync-System-Int32-'></a>

### GetFranchiseByIdAsync(franchiseId) `method`

  

##### Summary

  

Returns an NHL franchise by the franchise id

  

##### Returns

  

An NHL franchise, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| franchiseId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL franchise id, example: Montréal Canadiens - 1 |

  

<a  name='M-Nhl-Api-NhlApi-GetFranchisesAsync'></a>

### GetFranchisesAsync() `method`

  

##### Summary

  

Returns all NHL franchises, including information such as team name, location and more

  

##### Returns

  

A collection of all NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetGameScheduleByDateAsnyc-System-Nullable{System-DateTime}-'></a>

### GetGameScheduleByDateAsnyc(date) `method`

  

##### Summary

  

Return's the NHL game schedule based on the provided [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime  'System.DateTime'). If the date is null, it will provide today's current NHL game schedule

  

##### Returns

  

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule  'Nhl.Api.Models.Game.GameSchedule') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable  'System.Nullable{System.DateTime}') | The requested date for the NHL game schedule |

  

<a  name='M-Nhl-Api-NhlApi-GetGameScheduleByDateAsnyc-System-Int32,System-Int32,System-Int32-'></a>

### GetGameScheduleByDateAsnyc(year,month,day) `method`

  

##### Summary

  

Return's the NHL game schedule based on the provided year, month and day

  

##### Returns

  

NHL game schedule, see [GameSchedule](#T-Nhl-Api-Models-Game-GameSchedule  'Nhl.Api.Models.Game.GameSchedule') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| year | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested year for the NHL game schedule |
| month | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested month for the NHL game schedule |
| day | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The requested day for the NHL game schedule |

  

<a  name='M-Nhl-Api-NhlApi-GetGameStatusesAsync'></a>

### GetGameStatusesAsync() `method`

  

##### Summary

  

Returns all of the valid NHL game statuses of an NHL game

  

##### Returns

  

A collection of NHL game statues, see [GameStatus](#T-Nhl-Api-Models-Game-GameStatus  'Nhl.Api.Models.Game.GameStatus') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetGameTypesAsync'></a>

### GetGameTypesAsync() `method`

  

##### Summary

  

Returns all of the NHL game types within a season and within special events

  

##### Returns

  

A collection of NHL and other sporting event game types, see [GameType](#T-Nhl-Api-Models-Game-GameType  'Nhl.Api.Models.Game.GameType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetInactiveFranchisesAsync'></a>

### GetInactiveFranchisesAsync() `method`

  

##### Summary

  

Returns all inactive NHL franchises

  

##### Returns

  

A collection of all inactive NHL franchises, see [Franchise](#T-Nhl-Api-Models-Franchise-Franchise  'Nhl.Api.Models.Franchise.Franchise') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetInactiveTeamsAsync'></a>

### GetInactiveTeamsAsync() `method`

  

##### Summary

  

Returns all inactive NHL teams

  

##### Returns

  

A collection of all active NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueAwardByIdAsync-System-Int32-'></a>

### GetLeagueAwardByIdAsync() `method`

  

##### Summary

  

Returns an NHL award by the award id

  

##### Returns

  

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award  'Nhl.Api.Models.Award.Award') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueAwardsAsync'></a>

### GetLeagueAwardsAsync() `method`

  

##### Summary

  

Returns all of the NHL awards, including the description, history, and images

  

##### Returns

  

A collection of all the NHL awards, see [Award](#T-Nhl-Api-Models-Award-Award  'Nhl.Api.Models.Award.Award') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueProspectByIdAsync-System-Int32-'></a>

### GetLeagueProspectByIdAsync() `method`

  

##### Summary

  

Returns an NHL prospect profile by their prospect id

  

##### Returns

  

An NHL prospect, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile  'Nhl.Api.Models.Player.ProspectProfile') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueProspectsAsync'></a>

### GetLeagueProspectsAsync() `method`

  

##### Summary

  

Returns all the NHL league prospects The NHL prospects response provides a very large JSON payload

  

##### Returns

  

A collection of all the NHL prospects, see [ProspectProfile](#T-Nhl-Api-Models-Player-ProspectProfile  'Nhl.Api.Models.Player.ProspectProfile') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueStandingTypesAsync'></a>

### GetLeagueStandingTypesAsync() `method`

  

##### Summary

  

Returns all of the NHL league standing types, this includes playoff and preseason standings

  

##### Returns

  

A collection of all the NHL standing types, see [LeagueStandingType](#T-Nhl-Api-Models-Standing-LeagueStandingType  'Nhl.Api.Models.Standing.LeagueStandingType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueStandingsAsync-System-Nullable{System-DateTime}-'></a>

### GetLeagueStandingsAsync(date) `method`

  

##### Summary

  

Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings

  

##### Returns

  

A collection of all the leauge standings

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable  'System.Nullable{System.DateTime}') | The NHL league standings date for the request NHL standings |

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueVenueByIdAsync-System-Int32-'></a>

### GetLeagueVenueByIdAsync(id) `method`

  

##### Summary

  

Returns an NHL venue by the venue id

  

##### Returns

  

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue  'Nhl.Api.Models.Venue.LeagueVenue') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The specified id of an NHL venue, example: 5058 - Canada Life Centre |

  

<a  name='M-Nhl-Api-NhlApi-GetLeagueVenuesAsync'></a>

### GetLeagueVenuesAsync() `method`

  

##### Summary

  

Returns all of the NHL venue's, including arenas and stadiums This is not a comprehnsive list of all NHL stadiums and arenas

  

##### Returns

  

A collection of NHL stadiums and arenas, see [LeagueVenue](#T-Nhl-Api-Models-Venue-LeagueVenue  'Nhl.Api.Models.Venue.LeagueVenue') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetPlayTypesAsync'></a>

### GetPlayTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the play types within the duration of an NHL game

  

##### Returns

  

A collection of distinct play types, see [PlayType](#T-Nhl-Api-Models-Game-PlayType  'Nhl.Api.Models.Game.PlayType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetPlayerByIdAsync-System-Int32-'></a>

### GetPlayerByIdAsync(playerId) `method`

  

##### Summary

  

Returns an NHL player by their player id, includes information such as age, weight, position and more

  

##### Returns

  

An NHL player profile, see [Player](#T-Nhl-Api-Models-Player-Player  'Nhl.Api.Models.Player.Player') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| playerId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | An NHL player id, example: 8478402 is Connor McDavid |

  

<a  name='M-Nhl-Api-NhlApi-GetPlayoffTournamentTypesAsync'></a>

### GetPlayoffTournamentTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the different types of playoff tournaments in the NHL

  

##### Returns

  

A collection of tournament types, see [PlayoffTournamentType](#T-Nhl-Api-Models-Game-PlayoffTournamentType  'Nhl.Api.Models.Game.PlayoffTournamentType') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetSeasonByYearAsync-System-String-'></a>

### GetSeasonByYearAsync(seasonYear) `method`

  

##### Summary

  

Returns the NHL season information based on the provided season years

  

##### Returns

  

An NHL season based on the provided season year, example: '20172018'

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | See [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear  'Nhl.Api.Models.Season.SeasonYear') for all valid season year arguments |

  

<a  name='M-Nhl-Api-NhlApi-GetSeasonsAsync'></a>

### GetSeasonsAsync() `method`

  

##### Summary

  

Returns all of the NHL seasons since the inception of the league in 1917-1918

  

##### Returns

  

A collection of seasons since the inception of the NHL

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetStatisticTypesAsync'></a>

### GetStatisticTypesAsync() `method`

  

##### Summary

  

Returns all distinct types of NHL statistics types

  

##### Returns

  

A collection of all the various NHL statistics types, see [StatisticTypes](#T-Nhl-Api-Models-Statistics-StatisticTypes  'Nhl.Api.Models.Statistics.StatisticTypes') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetTeamByIdAsync-System-Int32-'></a>

### GetTeamByIdAsync(teamId) `method`

  

##### Summary

  

Returns an NHL team by the team id

  

##### Returns

  

An NHL team with information including name, location, division and more, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL team id, example: Toronto Maple Leafs - 10 |

  

<a  name='M-Nhl-Api-NhlApi-GetTeamStatisticsByIdAsync-System-Int32,System-String-'></a>

### GetTeamStatisticsByIdAsync(teamId,seasonYear) `method`

  

##### Summary

  

Returns a specified NHL team's statistics for the the specified season, the most recent season statistics will be returned

  

##### Returns

  

A collection of all the specified NHL team statistics for the specified season

  

##### Parameters

  

| Name | Type | Description |
| ---- | ---- | ----------- |
| teamId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32  'System.Int32') | The NHL team id, example: Toronto Maple Leafs - 10 |
| seasonYear | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String  'System.String') | The NHL season year, see [SeasonYear](#T-Nhl-Api-Models-Season-SeasonYear  'Nhl.Api.Models.Season.SeasonYear') for all valid seasons, example: 20202021 |

  

<a  name='M-Nhl-Api-NhlApi-GetTeamsAsync'></a>

### GetTeamsAsync() `method`

  

##### Summary

  

Returns all active and inactive NHL teams

  

##### Returns

  

A collection of all NHL teams, see [Team](#T-Nhl-Api-Models-Team-Team  'Nhl.Api.Models.Team.Team') for more information

  

##### Parameters

  

This method has no parameters.

  

<a  name='M-Nhl-Api-NhlApi-GetTournamentTypesAsync'></a>

### GetTournamentTypesAsync() `method`

  

##### Summary

  

Returns a collection of all the different types of tournaments in the hockey

  

##### Returns

  

A collection of tournament types, see [TournamentType](#T-Nhl-Api-Models-Game-TournamentType  'Nhl.Api.Models.Game.TournamentType') for more information

  

##### Parameters

  

This method has no parameters.

## Bugs 🐛
If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

## Feature Backlog 📈
Here are some of the future items I would like to add and are currently in the backlog:

- [ ] Content Feed for Live Games
- [ ] Player Search within the NHL league
- [ ] Add additional API functionality for ease of searching for various NHL entities
