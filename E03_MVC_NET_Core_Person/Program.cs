using E03_MVC_NET_Core_Person.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// TODO MRS: ler connection string de appsettings.json
var connectionString = builder.Configuration.GetConnectionString("E03ConnectionString");

// TODO MRS: configurar a EF 
builder.Services.AddDbContext<E03Context>(options =>
options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
