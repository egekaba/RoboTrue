using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using RoboTrue.DataAcsess.Contexts;
using RoboTrue.UI.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SqlDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ErpApp1")));
builder.Services.AddHttpContextAccessor();

builder.Services.AddErpService();
//builder.Services.AddSession(options =>
//{
//    options.Cookie.Name = ".AdventureWorks.Session";
//    options.IdleTimeout = TimeSpan.FromSeconds(10);
//    options.Cookie.IsEssential = true;
//});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/LoginPanel/Login";
    x.LogoutPath = "/LoginPanel/Logout";
    x.AccessDeniedPath = "/LoginPanel/AccessDenied";
    x.Cookie.Name = "ErpLoginCookie"; // Cookie Adi
    x.ExpireTimeSpan = TimeSpan.FromMinutes(20); // Cookie nin ge�erlilik Suresi
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
///app.UseSession();
app.UseAuthentication();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LoginPanel}/{action=Login}/{id?}");

app.Run();
