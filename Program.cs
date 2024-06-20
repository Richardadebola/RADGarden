using RADGarden.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RADGarden.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RADGardenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RADGardenContext") ?? throw new InvalidOperationException("Connection string 'RADGardenContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
