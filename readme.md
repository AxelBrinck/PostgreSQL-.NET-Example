# ASP.NET.Core example connection with PostgreSQL

## Description

This project is an example of a .NET.Core backend connecting, migrating, and retrieving data via API endpoint to a PostgreSQL instance.

## What we covered here

- **ASP.NET.Core 3.1** environent.
- Simple usage about **Entity Framework Core**
- Connection with a **PostgreSQL** instance.
- **Migration code** using the tool *dotnet ef*.
- A single **API endpoint**.

## Requirements

- PostgreSQL instance running.
- Know your credentials to connect with the instance.
- ASP.NET.Core framework installed. Check by running `dotnet --version`.
- *ef* tool to execute migrations. Run `dotnet tool install --global dotnet-ef` to install it. *This was bundled in previous versions of .NET*.

## How to use

- **Step 1**. We need to restore the required dependencies. Run `dotnet restore`.

- **Step 2**. Open _appsettings.json_ and modify the connection string according to your environment and credentials. *The credentials you will see there were used on a testing instance*.


- **Step 3**. There is a **migration** code in this project that will help us by building the database schema. You can execute this migration by running `dotnet ef database update`.

- **Step 4**. Add some dummy data to your PostgreSQL table *Articles*. You will notice that the schema has already been created.

- **Step 5**. Everything is ready! Execute `dotnet run`.

- You should now be able to see the data from the database by visiting: [http://localhost:5000/api/article]()

## Tools used
- Visual Studio Code
- .NET.Core 3.1
