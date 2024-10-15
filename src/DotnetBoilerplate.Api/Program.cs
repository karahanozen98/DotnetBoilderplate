using DotnetBoilerplate.Infrastructure.Extensions;
using DotnetBoilerplate.Application.Extensions;
using DotnetBoilerplate.Infrastructure.Data;
using DotnetBoilerplate.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCQRS();
builder.Services.AddApplicationDbContext(builder.Configuration);
builder.Services.AddValidatorsFromAssembly();
builder.Services.AddGenericRepository();
var app = builder.Build();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dataSeeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
    dataSeeder.SeedData();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.Run();