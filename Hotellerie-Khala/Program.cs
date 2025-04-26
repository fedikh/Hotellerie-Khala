using Microsoft.EntityFrameworkCore;
using Models.HotellerieModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Ajouter le service DbContext avec la chaîne de connexion "HotellerieConnection"
builder.Services.AddDbContext<HotellerieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotellerieConnection"))
);

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

// Démarrer directement sur HotelsController, action Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Hotels}/{action=Index}/{id?}");

app.Run();
