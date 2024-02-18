var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();  // boþ projeye mvc yapýsýný dahil ettik..

app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "Hello World!");


app.Run();
