![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml/badge.svg)


# The Official Unofficial .NET NHL API
-------------------------------------------------------------------------------------------------

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

## Usage 🚀

Once registered using your dependency injection library of choice or just using the simple instance of the NHL API. Explore the API and see the all the possibilities.
```
var teams = await _nhlApi.GetTeamsAsync();
...
```

## Bugs 🐛

If you have any issues with the library or suggestions, please feel free to create an issue and it will be adressed as soon as possible :)
