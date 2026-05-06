# GorillaTagModTemplate [![Version](https://img.shields.io/nuget/v/bingus.gorillatagmodtemplate) ![Downloads](https://img.shields.io/nuget/dt/bingus.gorillatagmodtemplate)](https://www.nuget.org/packages/bingus.gorillatagmodtemplate)

This is a feature-packed mod template for Gorilla Tag with pre-built utilities and tools for newer mod developers to use.

- Utils for overriding game methods with Harmony / loading Asset Bundles
- BepInEx / MelonLoader support baked in

It is loosely inspired by Graic's mod template.

## Install
> [!NOTE]
> If you are new to NuGet (the .NET package manager), these documentation pages may help you:
> 
> - https://learn.microsoft.com/en-us/nuget/what-is-nuget
> - https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio

To install, run this command from the Terminal:
```bat
dotnet new install bingus.gorillatagmodtemplate
```
You can use your code editor's GUI to create the project, or use the shorthand name of the template when creating via the [.NET CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new):
```ps1
# Make sure you have the template installed or this will error
mkdir MyModName
dotnet new gtmod --Name MyModName --Author MyName --GUID MyName.MyModName
```


