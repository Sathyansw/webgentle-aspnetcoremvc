using Microsoft.AspNetCore.Mvc;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.Getallbooks();
            return View();
        }
        public BookModel Getbook(int id)
        {
            return _bookRepository.Getbookbyid(id);
        }
        public List<BookModel> Searchbooks(string bookName, string authorname)
        {
            return _bookRepository.Searchbook(bookName, authorname);
        }
    }
}
