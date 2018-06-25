using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace JsonBookshop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/BooksId", ResponseFormat = WebMessageFormat.Json)]
        List<int> GetBookIds();

        [OperationContract]
        [WebGet(UriTemplate = "/Books/{id}", ResponseFormat = WebMessageFormat.Json)]
        WCF_Book GetBook(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/Books", ResponseFormat = WebMessageFormat.Json)]
        List<WCF_Book> GetBooks();

        [OperationContract]
        [WebGet(UriTemplate = "/BooksCat/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<WCF_Book> FindBooksByCatId(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/title/{title}", ResponseFormat = WebMessageFormat.Json)]
        List<WCF_Book> FindBooksByTitle(string title);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Update", Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        void Update(WCF_Book b);

        [OperationContract]
        [WebGet(UriTemplate = "/Categories", ResponseFormat = WebMessageFormat.Json)]
        List<WCF_Category> ListCategories();
    }

    [DataContract]
    public class WCF_Book
    {
        int bookID;
        string title;
        int categoryID;
        string isbn;
        string author;
        int stock;
        decimal price;
        string synopsis;
        decimal swDiscount;
        decimal finalPrice;
        string categoryName;

        [DataMember]
        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember]
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        [DataMember]
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        [DataMember]
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public string Synopsis
        {
            get { return synopsis; }
            set { synopsis = value; }
        }

        [DataMember]
        public decimal SWDiscount
        {
            get { return swDiscount; }
            set { swDiscount = value; }
        }

        [DataMember]
        public decimal FinalPrice
        {
            get { return finalPrice; }
            set { finalPrice = value; }
        }

        [DataMember]
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public WCF_Book(int BookID, string Title, int CategoryID, string ISBN, string Author, int Stock, decimal Price, string Synopsis, decimal SWDiscount, decimal FinalPrice, string CategoryName)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.CategoryID = CategoryID;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Stock = Stock;
            this.Price = Price;
            this.Synopsis = Synopsis;
            this.SWDiscount = SWDiscount;
            this.FinalPrice = FinalPrice;
            this.CategoryName = CategoryName;
        }

        public WCF_Book(int BookID, string Title, int CategoryID, string ISBN, string Author, int Stock, decimal Price, string Synopsis, decimal SWDiscount, decimal FinalPrice)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.CategoryID = CategoryID;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Stock = Stock;
            this.Price = Price;
            this.Synopsis = Synopsis;
            this.SWDiscount = SWDiscount;
            this.FinalPrice = FinalPrice;
        }
    }

    [DataContract]
    public class WCF_Category
    {
        int catID;
        string catName;
        [DataMember]
        public int CatID
        {
            get { return catID; }
            set { catID = value; }
        }
        [DataMember]
        public string CatName
        {
            get { return catName; }
            set { catName = value; }
        }

        public WCF_Category(int catID, string catName)
        {
            this.CatID = catID;
            this.CatName = catName;
        }
    }
}
