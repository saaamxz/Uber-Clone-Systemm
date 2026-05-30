using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UberProject.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// إضافة قاعدة البيانات للخدمات
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// إضافة دعم الـ Controllers والـ Views
builder.Services.AddControllersWithViews();
// 1. أضيفي الخدمات دي قبل builder.Build()
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

// 2. أضيفي السطر ده بعد app.UseStaticFiles()

// بناء التطبيق
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
