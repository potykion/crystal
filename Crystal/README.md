# Info

Crystal database admin.

# Commands

To generate db context and models:
```
dotnet ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=Crystal;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -c CrystalContext -o Models -f
```

To minify js:
```
dotnet bundle
```

To deploy app:
```
dotnet publish
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
14. [Asp action route data](https://stackoverflow.com/questions/39096582/asp-action-route-data)
15. [Globalization and localization in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization)
16. [Localization on _Layout.cshtml](https://stackoverflow.com/questions/43564843/localization-on-layout-cshtml?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa)
17. [ASP.NET Core Localization with help of SharedResources](https://stackoverflow.com/questions/42647384/asp-net-core-localization-with-help-of-sharedresources?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa)
18. [Use cookie authentication without ASP.NET Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie?tabs=aspnetcore2x)
19. [Introduction to Identity on ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?tabs=visual-studio%2Caspnetcore2x)
20. [Role-based authorization in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-2.1)
21. [ASP.NET Core 2.0 - Razor - Authorize](https://stackoverflow.com/questions/46879041/asp-net-core-2-0-razor-authorize)
22. [View-based authorization in ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/security/authorization/views?view=aspnetcore-2.1&tabs=aspnetcore2x)
23. [Razor Pages route and app convention features in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/razor-pages-conventions?view=aspnetcore-2.1)
24. [URL Rewriting Middleware in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-2.1&tabs=aspnetcore2x)
25. [Add search to ASP.NET Core Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/search?view=aspnetcore-2.1)
26. [dotnet publish](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish?tabs=netcore2x)
27. [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)