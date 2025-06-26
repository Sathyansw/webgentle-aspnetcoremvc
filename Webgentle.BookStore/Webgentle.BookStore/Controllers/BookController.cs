using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        private readonly LanguageRepository _languageRepository = null;

        public BookController(BookRepository bookRepository, LanguageRepository languageRepository)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.Getallbooks();
            return View(data);
        }

        [Route("book-details/{id}", Name ="bookDetailsRoute")]
        public async Task<ViewResult> Getbook(int id)
        {
            

            var data = await  _bookRepository.Getbookbyid(id);
            return View(data);
        }
        public List<BookModel> Searchbooks(string bookName, string authorname)
        {
            return _bookRepository.Searchbook(bookName, authorname);
        }

        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        
        {
            var model = new BookModel();


            ViewBag.Language = new SelectList(await _languageRepository.Getlanguages(), "Id", "Name");


            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult>  AddNewBook(BookModel bookModel)
        {

            if(ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }



            ViewBag.Language = new SelectList(await _languageRepository.Getlanguages(), "Id", "Name");


            return View();
        }


       
    }
}
