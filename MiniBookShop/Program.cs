using Microsoft.EntityFrameworkCore;
using MiniBookShop.Application.Abstract;
using MiniBookShop.Application.Concrete;
using MiniBookShop.DataAccess.Abstract;
using MiniBookShop.DataAccess.Context;
using MiniBookShop.DataAccess.Implementation;
using MiniBookShop.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton<ICartSessionService, CartSessionService>();

builder.Services.AddScoped<IUserDal, EFUserDal>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IBookDal, EFBookDal>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<ICartService, CartService>();

builder.Services.AddDbContext<ShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

var staticFiles = app.UseStaticFiles();
app.MapControllers();
app.MapFallbackToFile("/index.html");

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
