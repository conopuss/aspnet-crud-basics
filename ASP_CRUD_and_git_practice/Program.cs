
using ASP_CRUD_and_git_practice.Data;
using ASP_CRUD_and_git_practice.Middleware;
using ASP_CRUD_and_git_practice.Models;
using ASP_CRUD_and_git_practice.Repositories;
using ASP_CRUD_and_git_practice.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductRepository , ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<ConnectionDB>(options=>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


//builder.Services.AddDbContext<ConnectionDB>(options=>
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();



app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseExceptionHandler("/Product/Error");

app.UseMiddleware<ExceptionMiddleware>();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");




app.Run();
