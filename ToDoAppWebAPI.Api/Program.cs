using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ToDoAppWebAPI.Api;
using ToDoAppWebAPI.Api.Interfaces;
using ToDoAppWebAPI.Api.Managers;
using ToDoAppWebAPI.Data;
using ToDoAppWebAPI.Data.Interfaces;
using ToDoAppWebAPI.Data.Repositories;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("LocalToDoConnection");

builder.Services.AddControllers();

builder.Services.AddDbContext<ToDoDbContext>(options =>
    options.UseSqlServer(connectionString)
        .UseLazyLoadingProxies()
        .ConfigureWarnings(x => x.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)));

builder.Services.AddScoped<ITodoItemRepository, ToDoItemRepository>();
builder.Services.AddAutoMapper(typeof(AutomapperConfigurationProfile));
builder.Services.AddScoped<ITodoItemRepository, ToDoItemRepository>();
builder.Services.AddScoped<ITodoItemManager, ToDoItemManager>();

var app = builder.Build();
app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
