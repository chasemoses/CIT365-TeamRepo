using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mega_Desk_Web_App.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Mega_Desk_Web_AppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Mega_Desk_Web_AppContext") ?? throw new InvalidOperationException("Connection string 'Mega_Desk_Web_AppContext' not found.")));

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
