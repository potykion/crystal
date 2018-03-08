# Info

Crystal database admin and site.

# Code generation

To generate models:
```
dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=Crystal;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c CrystalContext -o Models -t HeadTablLanguage -t HeadTablInvariant
```

# References

1. [Running Entity Framework (Core) commands in Rider](https://blog.jetbrains.com/dotnet/2017/08/09/running-entity-framework-core-commands-rider/)
2. [EF Core .NET Command-line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
3. [Getting Started with EF Core on ASP.NET Core with an Existing Database](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db)
4. [Connection Strings](https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings)
