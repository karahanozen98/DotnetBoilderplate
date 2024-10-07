mkdir src


> dotnet new classlib --output src/DotnetBoilerplate.Domain;
> DotnetBoilderplate % dotnet sln add src/DotnetBoilerplate.Domain/DotnetBoilerplate.Domain.csproj

> dotnet new classlib --output src/DotnetBoilerplate.Infrastructure;
> DotnetBoilderplate % dotnet sln add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj
> rm -rf src/DotnetBoilerplate.Infrastructure/Class1.cs