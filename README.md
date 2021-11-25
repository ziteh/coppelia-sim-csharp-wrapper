# CoppeliaSim C# API

The CoppeliaSim (V-REP) remote control API for C#. Using [CoppeliaSim Legacy remote API](https://www.coppeliarobotics.com/helpFiles/en/legacyRemoteApiOverview.htm).

## Demo

[Demo video (YouTube)](https://youtu.be/4fqbw-M2QbY)

## Usage

### Client Side (i.e. C# Application)

1. Download the DLL file from [Releases](https://github.com/ziteh/coppelia-sim-csharp-api/releases). You can also build it from [source code](/CoppeliaSimCSharpAPI/CoppeliaSimCSharpAPI.cpp).
2. Copy and paste DLL file into your runtime path, e.g. `$(ProjectDir)x64/Debug/`.
3. Add `using System.Runtime.InteropServices;` at the beginning of code, use [`[DllImport()]`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-6.0) attribute to import DLL functions. [Example](/CoppeliaSimCSharpAPI.TestForm/Api.cs).
4. Write your own code. [Example](/CoppeliaSimCSharpAPI.TestForm/Form1.cs).

### Server Side (i.e. CoppeliaSim)

1. Add [`simRemoteApi.start()`](https://www.coppeliarobotics.com/helpFiles/en/remoteApiServerSide.htm) into your CoppeliaSim Lua script. For [example](/coppeliasim_ur5_script.lua):
```lua
function sysCall_init()
    simRemoteApi.start(3000) -- Start remote API server on port 3000

    corout=coroutine.create(coroutineMain)
end

-- Some code here...
```

2. Start simulation to enabling the remote API server.

## Reference
- [CoppeliaRobotics/bubbleRobClient](https://github.com/CoppeliaRobotics/bubbleRobClient)

## Dependency
- [CoppeliaRobotics/include](https://github.com/CoppeliaRobotics/include)
- [CoppeliaRobotics/remoteApi](https://github.com/CoppeliaRobotics/remoteApi)
