using Microsoft.EntityFrameworkCore;
using Miles.Core.Repositories;
using Miles.Data.Context;
using Miles.Data.Repositories;
using Miles.Service.Profiles.Categories;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Miles.Service.Validations.Categories;
using System.Text.Json.Serialization;
using Miles.Core.Entities.BaseEntities;
using Miles.Core.Entities;
using Miles.App.ServiceRegistrations;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Json;
using Serilog.Sinks.MSSqlServer;
using Telegram.Bot;
using Miles.Service.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Register(builder.Configuration);
builder.Services.SendMessage();
builder.Services.AddRazorPages();
builder.Host.UseSerilog();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseDeveloperExceptionPage();


app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "admin/{controller=Account}/{action=Login}/{id?}"
        );
    endpoints.MapControllerRoute(
       name: "default",
       pattern: "{controller=Home}/{action=Index}/{id?}"
       );
}
);
app.Run();
