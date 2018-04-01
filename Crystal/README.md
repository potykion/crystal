# Info

Crystal database admin.

# Code generation

To generate db context and models:
```
dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=Crystal;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c CrystalContext -o Models -t HeadTablLanguage -t HeadTablInvariant
```

To generate pages:
```
dotnet aspnet-codegenerator razorpage -m HeadTablInvariant -dc CrystalContext -udl -outDir Pages\HeadTabl --referenceScriptLibraries
```

# References

1. [Running Entity Framework (Core) commands in Rider](https://blog.jetbrains.com/dotnet/2017/08/09/running-entity-framework-core-commands-rider/)
2. [EF Core .NET Command-line Tools](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)
3. [Getting Started with EF Core on ASP.NET Core with an Existing Database](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db)
4. [Connection Strings](https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings)
5. [Adding a model to a Razor Pages app](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/model)
6. [Reading related data - EF Core with Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/read-related-data)
7. [Updating related data - EF Core Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/update-related-data#create-a-base-class-to-share-common-code)
8. [Razor syntax for ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor)
9. [Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages)
10. [Anchor Tag Helper](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/anchor-tag-helper)
11. [Bootstrap](http://getbootstrap.com/docs/3.3/)
12. [How to get query string parameter from MVC Razor markup?](https://stackoverflow.com/questions/11248064/how-to-get-query-string-parameter-from-mvc-razor-markup)
13. [Razor Page - How to redirect to another folder's page using asp-for tag helper](https://stackoverflow.com/questions/45703640/razor-page-how-to-redirect-to-another-folders-page-using-asp-for-tag-helper)