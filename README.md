![Build/Test](https://github.com/Afischbacher/Nhl.Api/actions/workflows/dotnet.yml/badge.svg)


# The Official Unofficial .NET NHL API
-------------------------------------------------------------------------------------------------

## Installing Nhl.Api

You should install Nhl.Api with NuGet:

```
Install-Package Nhl.Api
```

Or via the .NET Core command line interface:

```
dotnet add package Nhl.Api
```

Either commands, from Package Manager Console or .NET Core CLI, will download and install all required dependencies.

## Implementation

If you are using any type of a inversion of control or dependency injection library such as the one in .NET Core or Unity, it's very simple to implement, or you can create an instance of the `NhlApi` class and use the API

### .NET Core
`builder.Services.AddTransient<INhlApi, NhlApi>();`

### Unity
`container.RegisterType<INhlApi, NhlApi>();`

### Simple Object Creation
`var nhlApi = new NhlApi();`
