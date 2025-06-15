using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> Getallbooks()
        {
            return Datasource();
        }
        public BookModel Getbookbyid(int Id)
        {
            return Datasource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> Searchbook(string Title, string author)
        {
            //single search
            //return Datasource().Where(i => i.Title == Title && i.Author == author).ToList();
            //multi search
            return Datasource().Where(i => i.Title.Contains(Title) && i.Author.Contains(author)).ToList();

        }
        public List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id =1 , Title = "MVC", Author = "Nithish"},
                new BookModel() {Id =2 , Title = "Dot Net Core", Author = "Nithish"},
                new BookModel() {Id =3 , Title = "C#", Author = "Monika"},
                new BookModel() {Id =4 , Title = "Java", Author = "Webgentle"},
                new BookModel() {Id =5 , Title = "Php", Author = "Webgentle"},

            };


        }


    }
}
