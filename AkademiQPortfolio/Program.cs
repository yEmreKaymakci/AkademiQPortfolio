using AkademiQPortfolio.Data;
using Microsoft.EntityFrameworkCore; // Bu kütüphaneyi eklemeyi unutma

var builder = WebApplication.CreateBuilder(args);

// 1. Connection String'i appsettings.json'dan al
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. DbContext'i bu ayarla servise ekle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

// Fetch istekleri için CORS ayarý (JS tarafýnda sorun yaþamamak için)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// 3. Statik Dosyalar (CSS, JS, Resimler) için standart kod budur:
app.UseStaticFiles();

app.UseRouting();

// CORS'u aktif et
app.UseCors("AllowAll");

app.UseAuthorization();

// .NET 9 kullanmýyorsan MapStaticAssets yerine standart routing yeterlidir
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();