using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset PublishedDate { get; set; }

        public decimal Price { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public BookDBContext() : base("name=BookDBContext")
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}