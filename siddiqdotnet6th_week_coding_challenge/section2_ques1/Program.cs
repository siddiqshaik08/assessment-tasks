using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using siddiq_6thassessment.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<siddiq_6thassessmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("siddiq_6thassessmentContext") ?? throw new InvalidOperationException("Connection string 'siddiq_6thassessmentContext' not found.")));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
