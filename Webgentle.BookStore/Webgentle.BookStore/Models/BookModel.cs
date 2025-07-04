﻿using System.ComponentModel.DataAnnotations;
using Webgentle.BookStore.Enums;
using Webgentle.BookStore.Helpers;

namespace Webgentle.BookStore.Models
{
    public class BookModel
    {
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Enter your EmailAddress")]
        //[EmailAddress]
        //public string MyField { get; set; }
        public int Id { get; set; }
        //[StringLength(100, MinimumLength =5)]
        //[Required(ErrorMessage ="Please enter the title of your book")]

        [MyCustomValidation("abc")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the author name")]
        public string Author { get; set; }
        //[StringLength(500)]
        public string  Description { get; set; }
        public string? Category { get; set; }
        //[Required(ErrorMessage ="Please choose the language of your book")]
        public int LanguageId { get; set; }

        public string? Language { get; set; }


        [Required(ErrorMessage = "Please enter the total pages")]
        [Display(Name ="Total pages of book")]
        public int? TotalPages { get; set; }
    }
}
