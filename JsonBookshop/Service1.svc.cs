using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JsonBookshop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<int> GetBookIds()
        {
            return Work.GetBookIds();
        }

        public WCF_Book GetBook(string id)
        {
            int n = Int32.Parse(id);
            Book p = Work.GetBook(n);
            decimal swDiscount = (p.SWdiscount.HasValue ? p.SWdiscount.Value : 0);
            decimal finalPrice = (p.finalprice.HasValue ? p.finalprice.Value : 0);

            return new WCF_Book(p.BookID, p.Title, p.CategoryID, p.ISBN, p.Author, p.Stock, p.Price, p.Synopsis, swDiscount, finalPrice, p.Category.Name);
        }

        public List<WCF_Book> GetBooks()
        {
            List<Book> books = Work.GetBooks();
            List<WCF_Book> booksreturn = new List<WCF_Book>();
            foreach(Book p in books)
            {
                decimal swDiscount = (p.SWdiscount.HasValue ? p.SWdiscount.Value : 0);
                decimal finalPrice = (p.finalprice.HasValue ? p.finalprice.Value : 0);

                booksreturn.Add(new WCF_Book(p.BookID, p.Title, p.CategoryID, p.ISBN, p.Author, p.Stock, p.Price, p.Synopsis, swDiscount, finalPrice, p.Category.Name));
            }
            return booksreturn;
        }

        public List<WCF_Book> FindBooksByCatId(string id)
        {
            int n = Int32.Parse(id);
            List<Book> booksCat= Work.FindBooksByCatId(n);
            List<WCF_Book> b1 = new List<WCF_Book>();
            foreach(Book p in booksCat){
                decimal swDiscount = (p.SWdiscount.HasValue ? p.SWdiscount.Value : 0);
                decimal finalPrice = (p.finalprice.HasValue ? p.finalprice.Value : 0);

                b1.Add(new WCF_Book(p.BookID, p.Title, p.CategoryID, p.ISBN, p.Author, p.Stock, p.Price, p.Synopsis, swDiscount, finalPrice, p.Category.Name));
            }
            return b1;
        }

        public List<WCF_Book> FindBooksByTitle(string title)
        {
            List<Book> booksCat =  Work.FindBooksByTitle(title);
            List<WCF_Book> b1 = new List<WCF_Book>();
            foreach (Book p in booksCat)
            {
                decimal swDiscount = (p.SWdiscount.HasValue ? p.SWdiscount.Value : 0);
                decimal finalPrice = (p.finalprice.HasValue ? p.finalprice.Value : 0);

                b1.Add(new WCF_Book(p.BookID, p.Title, p.CategoryID, p.ISBN, p.Author, p.Stock, p.Price, p.Synopsis, swDiscount, finalPrice, p.Category.Name));
            }
            return b1;
        }

        public void Update(WCF_Book b)
        {
            Book book = new Book
            {
                BookID=b.BookID,
                Title=b.Title,
                CategoryID = b.CategoryID,
                ISBN = b.ISBN,
                Author = b.Author,
                Stock = b.Stock,
                Price = b.Price,
                Synopsis = b.Synopsis,
                SWdiscount = b.SWDiscount,
                finalprice = b.FinalPrice
        };
            Work.UpdateBook(book);
        }

        public List<WCF_Category> ListCategories()
        {
            List<WCF_Category> catlist = new List<WCF_Category>();
            List<Category> oldlist = Work.Categories();
            foreach(Category c in oldlist)
            {
                catlist.Add(new WCF_Category(c.CategoryID, c.Name));
            }
            return catlist;
        }
    }
}
