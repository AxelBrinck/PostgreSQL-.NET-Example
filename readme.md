# ASP .NET core example connection with PostgreSQL

## What we covered here

- **.NET** environent.
- Simple usage about **Entity Framework Core**
- Connection with a **PostgreSQL** instance.
- A simple **migration code** using the tool *dotnet ef*.

## Explanation

## How to use

1. You will need a PostgreSQL instance.

2. Know your credentials to connect with the instance. Ofcourse it is recommended to not use database super user.

3. Make sure you have dotnet installed. You can test this by running the following command:
```
dotnet --version
```

3. Clone this repository.

4. Open _appsettings.json_ and modify the connection string according to your environment and credentials. *The credentials you will see there were used on a testing instance*.

5. We need to restore the dependencies needed. Run the following command.
```
dotnet restore
```

6. There are **migrations** in this project that will help by building the database schema for us. You can execute the migration by running the following command.
```
dotnet ef database update
```

7. Optional: If the previous step did not work. You will need to install *ef* tool, as it is recently not part of the .NET framework anymore. Use the following command to install the ef tool and retry the previous step.
```
dotnet tool install --global dotnet-ef
```

8. Add some dummy data to your PostgreSQL table *Articles*. You will notice that the schema has already been created.

9. Everything is ready!
```
dotnet run
```