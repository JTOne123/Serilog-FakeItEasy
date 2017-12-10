# Serilog-FakeItEasy

#### Overview

This library is used to help remove some tribal knowledge required to Fake/Mock calls to Serilog methods in it's ```static Log``` class.
There is a setter/getter ```Log.Logger``` that once set with an ```ILogger``` uses it internally to power the ```Log``` classes methods for logging. 
Unfortunetly, ```Log.Logger``` also has a getter which allows you to perform the same calls as ```Log``` but they follow a slightly different logic path.
This means that if some of your team is using ```Log.Information(...)``` and others are using ```Log.Logger.Information(...)``` you will be requred
to mock/fake different methods when testing to get the same result. This library is an attempt and bridging that gap to make testing your logic in corrispondance
with logging more uniform.

Example:

Setting Logger -
```cs
Log.Logger = new LoggerConfiguration()
                 .WriteTo.LiterateConsole()
                 .WriteTo.RollingFile("SomeLogFile.txt")
                 .CreateLogger();

//Valid and Recommended [Requires mocking/faking a method '.Write(...)]
//This method was found because the source code is open source.
Log.Information("I'll make it to the logs ya'll!");

//Also valid and simply requires mocking/faking .Information(...) and is obvious.
//This is the non-prefered way and not in the Serilog examples.
Log.Logger.Information("I'll also make it to the logs not end result difference.");
```

<br/>

#### Examples

> See Example tests and usage in the [Serilog-FakeItEasy.Examples Project](Serilog-FakeItEasy.Examples/ReadMe.md)


#### Requirements
* [Visual Studio](https://www.visualstudio.com)
* [.NET Standard 2](https://github.com/dotnet/standard)
* [Examples - .NET Core](https://www.microsoft.com/net/core#windowscmd)

#### Feature
* [Serilog - Logging](https://serilog.net)
* [FakeItEasy - Faking/Mocking Framework](https://fakeiteasy.github.io)

#### Helpful Links
* [Markdown Style Guide](https://guides.github.com/features/mastering-markdown/)