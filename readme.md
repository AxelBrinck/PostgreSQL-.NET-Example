# ASP.NET.Core example connection with PostgreSQL

## Description

This project is an example of a .NET.Core backend connecting, migrating, and retrieving data via API endpoint to a PostgreSQL instance.

## What we covered here

- **.NET.Core** environent.
- Simple usage about **Entity Framework Core**
- Connection with a **PostgreSQL** instance.
- A simple **migration code** using the tool *dotnet ef*.
- A single **API endpoint**.

## Features to be added in future versions

- Full REST capabilities.
- Hide the connection string from version control.

## How to use

- **Step 1**. You will need a PostgreSQL instance running.

- **Step 2**. Know your credentials to connect with the instance. Of course, it is recommended to not use the database superuser.

- **Step 3**. Make sure you have dotnet installed. You can test this by running `dotnet --version`.

- **Step 4**. Clone this repository.

- **Step 5**. Open _appsettings.json_ and modify the connection string according to your environment and credentials. *The credentials you will see there were used on a testing instance*.

- **Step 6**. We need to restore the dependencies needed. Run `dotnet restore`.

- **Step 7**. There are **migrations** in this project that will help by building the database schema for us. You can execute the migration by running `dotnet ef database update`.

- **Step 8**. Optional: If the previous step did not work. You will need to install *ef* tool, as it is recently not part of the .NET framework anymore. Run `dotnet tool install --global dotnet-ef` to install the ef tool and retry the previous step.

- **Step 9**. Add some dummy data to your PostgreSQL table *Articles*. You will notice that the schema has already been created.

- **Step 10**. Everything is ready! Execute `dotnet run`.

- **Step 11**. You should now be able to see the data from the database by visiting: [http://localhost:5000/api/article]()

## Tools used
- Visual Studio Code
- .NET.Core 3.1
