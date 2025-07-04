﻿namespace Webgentle.BookStore.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string? Category { get; set; }
        public int LanguageId { get; set; }
        public int TotalPages { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? Updatedon { get; set; }

        public Language Language { get; set; }
    }
}
