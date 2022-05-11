using Microsoft.EntityFrameworkCore;
using MyIF.Data;
using MyIF.Services;

var builder = WebApplication.CreateBuilder(args);

//Configurações para usar o EF Core no ASP.NET

builder.Services.AddDbContext<MyIFContext>(
    options => options.UseMySql(
        builder.Configuration.GetConnectionString("ConnectDb"),

        ServerVersion.AutoDetect( builder.Configuration.GetConnectionString("ConnectDb"))
    )
);

builder.Services.AddScoped<CourseService>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
