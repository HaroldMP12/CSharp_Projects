using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data.Context;
using ProyectoFinal.Data.Daos;
using ProyectoFinal.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ShopContext>(options =>
                                    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb")));

builder.Services.AddTransient<ICategoriesDb , CategoriesDb>();

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
