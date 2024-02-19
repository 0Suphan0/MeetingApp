var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  // boþ projeye mvc yapýsýný dahil ettik..


var app = builder.Build();


//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


app.Run();
