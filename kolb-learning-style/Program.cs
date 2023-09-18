using DinkToPdf;
using DinkToPdf.Contracts;
using kolb_learning_style.Data;
using kolb_learning_style.Models;
using kolb_learning_style.Repositories;
using kolb_learning_style.Services;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IResultService, ResultService>();
builder.Services.AddScoped<IResultRepository, ResultRepository>();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<IEmailRepository, EmailRepository>();
builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
builder.Services.AddScoped<EmailSettings>();
builder.Services.AddSignalR(e =>
{
	e.MaximumReceiveMessageSize = 102400000;
});


// Add MainDbContext
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<MainDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

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
