using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Northwind.DAL.Repositories;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddScoped<INorthwindDBRepo, NorthwindDBRepo>();
builder.Services.AddCors(new Action<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>(options =>
{
    options.AddDefaultPolicy(new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy
    {
        Headers = { "Content-Type" },
        Methods = { "GET", "POST", "PUT", "DELETE" },
        Origins = { "*" },
        SupportsCredentials = true
    });
}));

builder.Build().Run();

