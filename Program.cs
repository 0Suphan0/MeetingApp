var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();  // bo� projeye mvc yap�s�n� dahil ettik..

app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "Hello World!");


app.Run();
