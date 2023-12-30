using Via.Application;
using Via.Infrastructer;
using Via.MVC.Extensions;
using Via.Persistence;
using ViabelliWebProject.Packages.Core.CrossCuttingConcerns.Exceptions.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddApplicationServices();
builder.Services.AddInfrastructerServices();
builder.Services.AddPersistenceServices(builder.Configuration);

//Cacheleme Servisleri baðlantýsý
//builder.Services.AddCache(Via.Domain.Enums.CacheType.Redis, builder.Configuration, "SadýkDockerRedis_Win");
builder.Services.AddCache(Via.Domain.Enums.CacheType.InMemory, builder.Configuration);


//Log ýslemýnde kulalndýgýmýz ýcýn buraya ekledýk bunu 
builder.Services.AddHttpContextAccessor();



builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Global hata yönetimi 
if (app.Environment.IsProduction())
    app.UseGlobalExceptionMidleware();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
