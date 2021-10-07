
# [Project name]

## Introduction / Motivation

The reason for making this project is to develop skils in LINQ, SQL, DotNET, and EF Core

## Technical Details

**FBT** : Folder By Type  
**FBF** : Folder By Feature  

|Project Name|Language|Folder Structure|
|-|-|-|
|**|* *|*FBF*|
|*Off-Black.Service*|*.Net 5.0*|*FBT*|
|*Off-Black.Repository*|*.Net 5.0*|*FBT*| 

### Technologies and prerequisites

*This chapter contains some information for what is needed to have experience with. what technologies is used? Important libraries, tools, software and version control.*

- [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
- [ASP.Net 5.0](https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-5.0&tabs=windows)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Razor Pages](https://www.learnrazorpages.com/)
- [Log4Net](https://logging.apache.org/log4net/)
- [xUnit](https://docs.microsoft.com/en-us/ef/core/testing/in-memory)
- Basic knowledge of VSTS, GIT and LINQ


## Solution Architecture

*This chapter contains a drawing and explanation of the solution architecture. What standards, and patterns is used? What version and software is used?*

This solution is realized as a ASP.NET Core 5.0 project.

The solution is built with a 3-tier architecture. It starts with a presentation layer, and for this case it is the web layer. 
This layer calls down to the service layer with all the business logic, without presentation layer specific code. 
The next layer is the repository that handles the database and sql execution, and it is only accessible by the service layer. 
But there is a little flaw in this design, and it means that the presentation layer also have access to the repository, 
because it is needed for dependency injection in [Startup.cs](Proje/Startup.cs)

## ER-Diagram

![E R Diagram](Documentation/ER-Diagram.png)

## Implementation

*This chapter contains information about how the application works with flowcharts (overall flow of a function or end to end flow), text. Important knowledge for a developer to know for developing on the tool. I could be information about authentication, complex logic or sections of the software that works on a special way.*


## Deployment

1. Open the project in Visual Studio and publish **Project**
2. Select "**IIS, FTP, etc**" when prompted for a publish target and use the following options:

- Publish method: File System.
- Target location: Create a new folder and use it as the target
- Configuration: Release
- Target Framework: netcoreapp5.0
- Deployment Mode: Self-Contained
- Target Runtime: win-x64

Copy the files to the IIS Server's share, after the publish is finished.


## Responsible People  


|Name|E-mail|Role|
|-|-|-|
|Peter Hymoller|Peter.hymoller@danfoss.com|Developer|