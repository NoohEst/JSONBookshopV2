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
    }

    [DataContract]
    public class WCF_Book
    {
        [DataMember]
        public int BookID;

        [DataMember]
        public string Title;

        [DataMember]
        public int CategoryID;

        [DataMember]
        public string ISBN;

        [DataMember]
        public string Author;

        [DataMember]
        public int Stock;

        [DataMember]
        public decimal Price;

        [DataMember]
        public string Synopsis;

        [DataMember]
        public decimal SWDiscount;

        [DataMember]
        public decimal FinalPrice;

        [DataMember]
        public string CategoryName;

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
    }
}
