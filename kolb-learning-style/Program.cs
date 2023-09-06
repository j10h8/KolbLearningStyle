using kolb_learning_style.Data;
using kolb_learning_style.Repositories;
using kolb_learning_style.Services;
//using BlazorBootstrap;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IResultService, ResultService>();
builder.Services.AddScoped<IResultRepository, ResultRepository>();
//builder.Services.AddBlazorBootstrap();


//builder.Services.AddScoped<BootstrapModalService>();
//builder.Services.AddScoped<BootstrapCssClasses>();

// Add MainDbContext
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();
