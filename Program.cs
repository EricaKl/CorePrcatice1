var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Second}/{action=Index1}/{id?}");

//app.Map("/a", x => x.Run(c => c.Response.WriteAsync("End")));
//app.Map("/hello", x => x.Use(async (a, b) =>
//{
//    await a.Response.WriteAsync("Hello"); b();
//}));
//app.Use(async (x, y) =>
//{
//    await x.Response.WriteAsync("Hello1 Hello2"); y();
//});

app.Run();
