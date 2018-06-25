using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonBookshop
{
    public class Work
    {
        static BookshopModel b = new BookshopModel();
        public static List<Book> GetBooks()
        {
            return b.Books.ToList<Book>();
        }

        public static List<int> GetBookIds()
        {
            List<int> list = new List<int>();
            foreach (Book p in GetBooks())
            {
                list.Add(p.BookID);
            }
            return list;
        }

        public static Book GetBook(int id)
        {
            return b.Books.Where(p => p.BookID == id).ToList<Book>()[0];
        }

        public static List<Book> FindBooksByCatId(int id)
        {
            return b.Books.Where(p => p.CategoryID == id).ToList<Book>();
        }

        public static List<Book> FindBooksByTitle(String title)
        {
            return b.Books.Where(p => p.Title.ToLower().Contains(title.ToLower())).ToList<Book>();
        }

        public static void UpdateBook(Book book)
        {
            b.Entry(book).State = System.Data.Entity.EntityState.Modified;
            b.SaveChanges();
        }

        public static List<Category> Categories()
        {
            return b.Categories.ToList<Category>();
        }
    }
}