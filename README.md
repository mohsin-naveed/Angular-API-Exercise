# Gallagher Re: Technical Interview

The project is an ASP.NET Core application with Angular to test basic technical skills of the candidates for Software Engineering positions.

## Structure
Application uses [ASP.NET Core 3.1](https://docs.microsoft.com/en-gb/aspnet/core/web-api/?view=aspnetcore-3.1)  
`ClientApp` inside uses [Angular 8.2.12](https://v8.angular.io/docs)

The project does not use any database. Sample _database_ items are stored in `SanctionedEntities` list in `DatabaseService`. For the purpose of this exercise this is sufficient, we do not expect candidates to embed ORM or CRUD functionality. However if candidates wish to mock a DAL that is acceptable - but the focus of the time spent here should be on C# and Angular development.

## Requirements
- Node.js version 10.9.0 or later
- ASP.NET Core SDK 3.1
- Visual Studio/VS Code IDE

## Getting started
Open the solution in Visual Studio and run IIS Express. This will automatically install the required packages and will open the app in the browser. The Home page will provide you with the details about the content of the application and the tasks you are asked to tackle.

## Scope of exercise
As an insurance organisation, we are prevented from doing business with certain organisations that are subject to sanctions by Government. These sanctioned entities are different across the globe and it is vital we keep track of which organisations are sanctioned in which countries.

This is a simple ASP.Net Core application with Angular, its goal is to keep a track of the number of organisations subject to sanctions in various countries and display these to the user. It includes following tabs:

**Counter**: simple counter which is incremented by pressing a button

**Sanctioned Entities**: table displaying sanctioned entities fetched from the server
Please tackle the following problems - use whatever approaches you'd normally use in your day to day work:

1. Display the counter on the home page
* Number on the Counter page should always match the one on the Home page
* The count should persist when switching between the tabs
2. Add a capability to add a sanctioned entity
* Add a form to provide details of a new sanctioned entity
* The status should use a Bootstrap switch
* No property of the sanctioned entity can be empty
* The code needs to ensure that there cannot be more than one entity with the same name and domicile

## Submitting your work
Please create a pull request for the code you have developed and submit no later than 2 hours before your scheduled interview time. If you have any issues submitting your PR, please contact your recruitment partner.
