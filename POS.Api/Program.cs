using POS.Aplication.Extensions;
using POS.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
var cors = "Cors";

builder.Services.AddInjectionInfrastructure(configuration);
builder.Services.AddInjectionApplication(configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors(cors);

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

public partial class Program { }
