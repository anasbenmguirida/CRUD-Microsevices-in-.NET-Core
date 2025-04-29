using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot(); 
var app = builder.Build();
app.UseOcelot().Wait();


app.UseHttpsRedirection();
app.Run();

