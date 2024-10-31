using Microsoft.EntityFrameworkCore;
using Web_Server_Application_Final_Project.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MovieContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieContext")));

//builder.Services.AddDbContext<CameraContext>(
//    options => options.UseSqlServer(builder.Configuration.GetConnectionString("CameraContext")));

builder.Services.AddDbContext<GameContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("GameContext")));

//builder.Services.AddDbContext<PlaceContext>(
//    options => options.UseSqlServer(builder.Configuration.GetConnectionString("PlaceContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
