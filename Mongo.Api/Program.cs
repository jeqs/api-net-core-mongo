using Mongo.Application.ARS.Handlers.QueryHandlers;
using Mongo.Infrastructure.AppConfig;
using Mongo.Infrastructure.Services;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<DatabaseSetting>(builder.Configuration.GetSection("DatabaseSetting"));

builder.Services.AddSingleton<ARSService>();

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddMediatR(typeof(GetAllARSHandler).Assembly);

var app = builder.Build();

app.MapGet("/", () => "Mongo.WebApi");

app.MapControllers();

app.Run();
