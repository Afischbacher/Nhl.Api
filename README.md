[![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml)
[![Issues](https://img.shields.io/github/issues/Afischbacher/Nhl.Api.svg)](https://github.com/Afischbacher/Nhl.Api/issues)
[![License](https://img.shields.io/github/license/Afischbacher/Nhl.Api)](https://github.com/Afischbacher/Nhl.Api/blob/master/LICENSE)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Afischbacher/Nhl.Api/graphs/commit-activity)


# The Official Unofficial .NET NHL API 
A C# .NET Standard 2.0 library for the .NET NHL API
<br />

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

<br />

## Implementation ⚒

If you are using any type of a inversion of control or dependency injection library such as the built in library within .NET Core, Unity, or AutoFac. It's very simple to implement, or you can create an instance of the `NhlApi` class and use the API as you would like.

### .NET Core
`builder.Services.AddTransient<INhlApi, NhlApi>();`

### Unity
`container.RegisterType<INhlApi, NhlApi>();`

### AutoFac
`builder.RegisterType<NhlApi>().As<INhlApi>();`

### Simple Object Creation
`var nhlApi = new NhlApi();`

<br />

## Usage 🚀

Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.
```
var teams = await _nhlApi.GetTeamsAsync();
...
```
<br />

## Bugs 🐛

If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)

<br />

## Feature Backlog 📈

Here are some of the future items I would like to add and are currently in the backlog:

- [ ] Content Feed for Live Games
- [ ] Player Search within the NHL league
- [ ] Add additional API functionality for ease of searching for various NHL entities
