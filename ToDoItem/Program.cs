using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ToDoItem.DataBase.Context;

var builder = WebApplication.CreateBuilder(args);

string connection = "ToDoItemDB";

builder.Services.AddDbContext<ToDoDBContext>(opt => opt.UseSqlServer(connection));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "An ASP.NET Core Web API For Managing Pet Store",
    });
});

var app = builder.Build();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
