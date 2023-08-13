using Microsoft.Extensions.Options;
using Test;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<AppOptions>(builder.Configuration.GetSection(AppOptions.Section));

var app = builder.Build();

var options = app.Services.GetRequiredService<IOptions<AppOptions>>().Value;

app.MapGet("/", () => $"Hello {options.Name}!");

app.Run();
