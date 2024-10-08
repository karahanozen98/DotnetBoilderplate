mkdir src

# Domain

> dotnet new classlib --output src/DotnetBoilerplate.Domain;
> dotnet sln add src/DotnetBoilerplate.Domain/DotnetBoilerplate.Domain.csproj
> rm src/DotnetBoilerplate.Domain/Class1.cs

# Infrastructure

> dotnet new classlib --output src/DotnetBoilerplate.Infrastructure
> dotnet sln add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj
> rm src/DotnetBoilerplate.Infrastructure/Class1.cs
> dotnet add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj package Microsoft.EntityFrameworkCore
> dotnet add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj package Microsoft.EntityFrameworkCore.InMemory
> dotnet add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj package Microsoft.Extensions.Configuration
> dotnet add src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj reference src/DotnetBoilerplate.Domain/DotnetBoilerplate.Domain.csproj

# Core

> dotnet new classlib --output src/DotnetBoilerplate.Core
> dotnet sln add src/DotnetBoilerplate.Core/DotnetBoilerplate.Core.csproj
> rm src/DotnetBoilerplate.Core/Class1.cs
> dotnet add src/DotnetBoilerplate.Core/DotnetBoilerplate.Core.csproj package MediatR

# Application

> dotnet new classlib --output src/DotnetBoilerplate.Application
> dotnet sln add src/DotnetBoilerplate.Application/DotnetBoilerplate.Application.csproj
> rm src/DotnetBoilerplate.Application/Class1.cs
> mkdir src/DotnetBoilerplate.Application/Commands
> mkdir src/DotnetBoilerplate.Application/Queries
> mkdir src/DotnetBoilerplate.Application/Dtos  
> dotnet add src/DotnetBoilerplate.Application reference src/DotnetBoilerplate.Infrastructure/DotnetBoilerplate.Infrastructure.csproj
> dotnet add src/DotnetBoilerplate.Application/DotnetBoilerplate.Application.csproj reference src/DotnetBoilerplate.Core/DotnetBoilerplate.Core.csproj

# Api

> dotnet add src/DotnetBoilerplate.Api reference src/DotnetBoilerplate.Application
