using Microsoft.EntityFrameworkCore;
using PlatformDemoDB.Data;
using PlatformDemoDB.Interfaces;
using PlatformDemoDB.Domain;
using PlatformDemoDB.Services;
using PlatformDemoDB.Data.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient(typeof(IServicePlanTimesheetsRepo), typeof(ServicePlanTimesheetsRepo));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb") ??
        throw new InvalidOperationException("Connection string 'LocalDb' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    DbInitializer.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
