# EntityFrameworkQueries

## Getting Started
- VS 2022
- .NET 6
- [AP Database](create_ap.sql) installed

You may need to change the DB connection string located in the APContext class.
By default it points to mssqllocaldb. If your AP script is not installed on mssgllocaldb, update the string.
```csharp
optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
```
