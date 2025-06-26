using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Webgentle.BookStore.Models;


namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string  CustomProperty { get; set; }
        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }
        public ViewResult Index()
        {
            Title = "Home page from controller";

            CustomProperty = "Custom Value";

            Book = new BookModel() { Id = 1, Title = "Asp.net Core" };
           
            return View();
        }
        public ViewResult AboutUs()
        {
            Title = "Aboutus page from controller";
            return View();
        }
        public ViewResult ContactUs()   
        {
            return View();
        }

     
    }
}
