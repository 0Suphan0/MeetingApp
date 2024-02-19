var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  // bo� projeye mvc yap�s�n� dahil ettik..


var app = builder.Build();


//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


app.Run();
