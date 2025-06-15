using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();



app.UseStaticFiles();



app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});




app.Run();
