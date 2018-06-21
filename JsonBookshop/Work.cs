using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonBookshop
{
    public class Work
    {
        BookshopModel b = new BookshopModel();
        public List<Book> GetBooks()
        {
            return b.Books.ToList<Book>();
        }

        public List<int> GetBookIds()
        {
            List<int> list = new List<int>();
            foreach (Book p in GetBooks())
            {
                list.Add(p.BookID);
            }
            return list;
        }

        public Book GetBook(int id)
        {
            return b.Books.Where(p => p.BookID == id).ToList<Book>()[0];
        }

        public List<Book> FindBooksByCatId(int id)
        {
            return b.Books.Where(p => p.CategoryID == id).ToList<Book>();
        }
    }
}