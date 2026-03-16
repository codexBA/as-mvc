# AS.WebForms Solution

This repository contains a Visual Studio solution with multiple .NET projects:

- `AS.WebForms`: ASP.NET Web Forms app.
- `AS.MVCFramework`: ASP.NET MVC (classic .NET Framework) app.
- `AS.DbFirst`: .NET Framework class library using Entity Framework (Database First).
- `AS.MVC_Core`: ASP.NET Core MVC app.

## Getting started

- Open the solution in Visual Studio.
- Restore NuGet packages:
  - Visual Studio: **Build > Restore NuGet Packages**
  - or `nuget restore` / `dotnet restore` depending on the project.
- Build and run the desired startup project.

## Repo hygiene

This repo includes a `.gitignore` to prevent committing build outputs (`bin/`, `obj/`), IDE user files (`.vs/`, `*.user`), test results, and other local artifacts.

