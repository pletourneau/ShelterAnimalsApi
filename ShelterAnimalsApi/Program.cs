using ShelterAnimalsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddApiVersioning(opt =>
//                                     {
//                                         opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1,0);
//                                         opt.AssumeDefaultVersionWhenUnspecified = true;
//                                         opt.ReportApiVersions = true;
//                                         opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
//                                                                                         new HeaderApiVersionReader("x-api-version"),
//                                                                                         new MediaTypeApiVersionReader("x-api-version"));
//                                     });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ShelterAnimalsApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHttpsRedirection();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
