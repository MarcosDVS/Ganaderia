using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Ganaderia.Data;
using Ganaderia.Data.Context;
using Ganaderia.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
#region Configuracion de la base de datos SQLite
builder.Services.AddSqlite<GanaderiaDbContext>("Data Source=.//Data//Context//GanaderiaDb.sqlite");
builder.Services.AddScoped<IGanaderiaDbContext,GanaderiaDbContext>();
#endregion
//builder.Services.AddScoped<IVacaService,VacaService>();

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

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<GanaderiaDbContext>();
        if (db.Database.EnsureCreated())
        {
            
        }
}

app.Run();



