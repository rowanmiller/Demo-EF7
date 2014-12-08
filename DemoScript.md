The demo is broken up into a series of sections that showcase a specific features. Each section has a corresponding slide in the slide deck, which you can use to provide a quick summary of the feature before demoing it. This also helps break up the long demo section of the talk into logical 5-10min chunks, which helps folks keep up to speed.

### One Time Setup

**Install Prerequisites**
* Visual Studio 2013
* [SQLite for Windows Phone 8.1](http://visualstudiogallery.msdn.microsoft.com/5d97faf6-39e3-4048-a0bc-adde2af75d1b)
* [SQLite for Windows Runtime (Windows 8.1) ](http://visualstudiogallery.msdn.microsoft.com/1d04f82f-2fe9-4727-a2f9-a2db127ddc9a)
* [Azure Storage Explorer](https://azurestorageexplorer.codeplex.com/)
 * Setup access to CycleSales storage account (details are in App/Web.config files of project)
* The EF7 NuGet packages use some new metadata that is only supported in NuGet 2.8.3 or later.
 * Download and install VS2013 Update 4 or just install the [latest version of NuGet](https://visualstudiogallery.msdn.microsoft.com/4ec1526c-4a8c-4a84-b702-b21a8f5293ca)
 * Restart VS
* SQL Server Profiler (or some other profiling tool)
 
**Get the Source**
* Clone this Git repo to your local machine
* Note that there are two branches in this repo:
 * **WithPackages** is set as the default branch and has all the required NuGet packages checked in. This allows you to easily setup a local NuGet feed to protect from network outages, slow WiFi, etc.
 * **master** contains just the source. You'll need to do a bit of leg work if you want to actually run these samples, but it comes without all the bloat of having binaries checked in.

**Register the Code Snippets**
 * Open VS -> Tools -> Code Snippets Manager...
 * Make sure **Visual C#** is selected in the dropdown and add the **CodeSnippets** directory from your local clone of this repository

**Setup Local NuGet Feed**
 * To insulate against network outages, slow WiFi, etc. the WithPackages branch includes a local copy of the required NuGet packages. 
 * You need to [setup a local NuGet feed on your machine](http://docs.nuget.org/docs/creating-packages/hosting-your-own-nuget-feeds) that points to the **LocalNuGetFeed** folder in your local copy of this repo.
 * During the demo you should disable everything apart from the local feed - nothing worse than getting an unexpected package upgrade, or long pauses due to a slow network. 
 
**Optional**
* Install [ZoomIt](http://technet.microsoft.com/en-us/sysinternals/bb897434.aspx) and get familiar with how to use it - it's a great tool for making you demos look professional.

### Every Time Setup

**Reset the Repo**
Reset the repo to ensure it's cleaned up from any previous run thrus of the demo. How you do this will depend on what Git tools you have installed. Here is how to do it using the Git command line:
 * Open a console to the local repo directoy and run the following commands 
 * `git reset --hard`
 * `git clean -fdx`
 
**Open the Solutions**
* Open ```StartingSourceUnicornClicker\UnicornClicker.sln``` and ```StartingSource\CycleSales\CycleSales.sln``` in Visual Studio
* Run **Get-ExecutionPolicy** in Package Manager Console (PMC) in both instances of VS and ensure it returns **RemoteSigned**
 * Occasionally PMC sets the **Restricted** execution policy and won't allow running install scripts from the NuGet packages. It's really hard to recover from, **don't skip this step, especially before your presentation!**
 * Running VS as an administrator seems to minimize occurrences of this issue, so you may want to do that.
* In both instances, click **Restore Packages** in Package Manager Console
* Make sure the correct startup projects are selected:
 * UnicornClicker: UnicornClicker.WindowsPhone
 * CycleSales: CycleSales.WinForms
* Ctrl+F5 the UnicornClicker app so that the phone emulator is fired up and running the app.
 
**Reset Databases**
* Delete the CycleSales database from **(localdb)\v11.0** (the apps will recreate it when you run them).
* If you are going to demo the Windows Store UnicornClicker app then delete any leftover SQLite databases
 * Go to %LOCALAPPDATA% in the file system, search for ```GameHistory.db```, and delete any results

**Start SQL profiling**
* Open **SQL Server Profiler**
* Start a trace against **(localdb)\v11.0)**
 
### Demo 1: EF7 for Phone/Store

Intro to the app:
* Play a game in the UnicornClicker app
* Go back to main screen and show score history
* Discuss that score history is volatile and lost when app is closed
* Drop to VS and show that ```GamesService.cs``` in Shared project uses a static list to store history

Setup SQLite context:
* Install ```EntityFramework.SQLite``` package
* Open ```GameContext.cs``` and explain that it's a boiler plate context (same as past versions of EF) ready to be padded out.
 * Optionally show that ```Game.cs``` is just a POCO class
* Explain ```OnConfiguring``` is a new method that allows config for that context from code.
* Implement OnConfiguring:
 * ```s_CreateSQLiteConnectionString``` code snippet
 * ```options.UseSQLite(connection);```
 * 
 
Implement game service:
* Open ```GameService.cs```
* Implement saving game
```
using (var db = new GameContext())
{
    db.Games.Add(game);
    db.SaveChanges();
}
```
* Implement querying games
```
using (var db = new GameContext())
{
    var topGames = db.Games
        .OrderByDescending(g => g.ClicksPerSecond)
        .Take(3);

    return topGames;
}
```
 
Use migrations to create database:
* Good time to explain EF7 can target an existing database or create one for you (folks think we only support new databases when we demo migrations).
* In Package Manager Console **make sure the WindowsPhone project is selected** and run ```Add-Migration InitialSchema```
* Move the ```Migrations``` folder and it's content to the Shared project
* Discuss that on desktop you would use ```Apply-Migrations``` to create the dev database, but this one needs to be created on the actual device.
 * In ```App.xaml.cs``` update the TODO in the constructor to apply migrations at startup; ```db.Database.AsRelational().ApplyMigrations();```

Demo the app:
* Ctrl+F5 the app, play a game and show the history
* Optionally, close the app (hold down <- button on phone emulator to do this), reopen, and show scores are still there
* Optionally, launch the Windows Store app and show the same functionality there

### Demo 2: SQL generation improvements

Intro to CycleSales:
* Explain that Cycle Sales is a bicycle company, this is an internal application for managing their products
* Run the WinForms app and show the **Manage Products** screen
* Show ```CycleSales\CycleSalesModel\CycleSalesContext.cs``` and explain:
 * Extra constructor and conditional logic in OnConfiguring are to help with unit testing (coming later in demo)
 * ```UseSqlServer(...)``` is available because you have the SQL Server provider installed
 * ```ForRelational()``` in ```OnModelCreating()``` lets you setup stuff that is specific to relational data stores and is available because you have a relational provider installed.
 
Client evaluation in queries:
* Show ```PriceService.cs``` and that ```CalculateForeignPrices(...)``` makes use of extensive .NET code (to calculate and round the prices)
 * EF6 couldn't run this query because it couldn't process this in the database
* Use the **Foreign Prices*** functionality
* Swap to SQL Profiler and show that only parts of the query were run in the database
 * Also note how simple the query is
 
Batch updates
* Open the **Manage Products** screen and edit a couple of the descriptions
* Click the Save button
* Swap to profiler and show that both updates are done in a single command

### Demo 3: Testing with InMemory

* Show ```CycleSales.Tests\PriceConvertorTests.cs``` and explain it current hits a database
* Install the ```EntityFramework.InMemory``` NuGet package
* ```s_SetupInMemoryOptions``` code snippet replaces the TODO at the top of the test
* Swap to use the context constructor that takes options ```using (var db = new CycleSalesContext(options))```
* Run test and show it passes

### Demo 4: Azure Table Storage

Intro:
* Show CycleSales account in Azure Storage Explorer
* Open the WarrantyInfo table and show it contains warranty data keyed on ModelNo and SerialNo
 
Connect using EF7
* Install ```EntityFramework.AzureTableStorage``` NuGet package
* Open ```CycleSales\WarrantyModel\WarrantyContext.cs```
* Update ```OnConfiguring``` to use ATS ```options.UseAzureTableStorage(connection);```
* ```s_ConfigurePartitionAndRowKey``` code snippet replaces TODO in ```OnModelCreating```

Show it working:
* Ctrl+F5 and open **Warranty Lookup**
* Search for TTT200/FR12789
* Update the Notes field and click Save
* Show data updated in Storage Explorer
