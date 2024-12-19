using System.Net;
using System.Transactions;
using System.Xml.Linq;

namespace classTask
{
    public class Book                         (string _Title, string _Author, string _ISBN, int _Year)   // new    
    {                                                                                                    // way
        public string title { get; set; }     = _Title;                                                  // to
        public string author { get; set; }    = _Author;                                                 // make
        public string ISBN { get; set; }      = _ISBN;                                                   // constructor
        public int year { get; set; }         = _Year;                                                   // .


        //public Book(string _Title, string _Author, string _ISBN, int _Year)    // .
        //{                                                                      // old
        //    Title = _Title;                                                    // way
        //    Author = _Author;                                                  // to
        //    ISBN = _ISBN;                                                      // make
        //    Year = _Year;                                                      // constructor
        //}                                                                      // .

        public void DisplayInfo()
        {
            Console.WriteLine($"Title : {title}\nAuthor: {author}\nISBN  : {ISBN}\nYear  : {year}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("clean code", "Robert C. Martin", "978-0136083252", 2008);
            book.DisplayInfo();


            Console.ReadKey();
        }
    }
}
