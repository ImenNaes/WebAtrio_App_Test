using Microsoft.EntityFrameworkCore;
using WebAtrio_App_Test.EF;
using WebAtrio_App_Test.Repository.Implementations;
using WebAtrio_App_Test.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"));
});
builder.Services.AddScoped<IPersonneRepository,PersonneRepository>();
builder.Services.AddScoped<IEmploiRepository,EmploiRepository>();
builder.Services.AddScoped<IPersonneEmploiRepository,PersonneEmploiRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  //  app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
