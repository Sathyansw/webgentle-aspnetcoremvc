using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Webgentle.BookStore.Data;
using Webgentle.BookStore.Repository;
var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<BookStoreContext>(
    options => options.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True; Encrypt=false"));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<BookRepository, BookRepository>();
builder.Services.AddScoped<LanguageRepository, LanguageRepository>();


var app = builder.Build();



app.UseStaticFiles();



app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();

    //endpoints.MapControllerRoute(
    //    name: "Default",
    //    pattern: "bookApp/{controller=Home}/{action=Index}/{id?}");

});




app.Run();
