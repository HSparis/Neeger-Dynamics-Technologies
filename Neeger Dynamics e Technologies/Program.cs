using Microsoft.EntityFrameworkCore;
using Neeger_Dynamics_e_Technologies.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NeegerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
//public class Startup
//{
//    public IConfiguration Configuration { get; }

//    public void ConfigureServices(IServiceCollection services)
//        => services.AddDbContext<NeegerContext>(gs => gs.UseSqlServer(Configuration.GetConnectionString("NeegerDB")).EnableSensitiveDataLogging());


//    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//    {
//    }


//}
