using System.Threading.Channels;

namespace task_oop
{
    public enum BStatus
    {
        Available,
        CheckedOut,
        Reserved
    }
    public enum BType
    {
        Paper,
        Electronic,
        Audio
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetAuthor("Abdalrahman b");
            book.SetTitle("Clean Code b");
            book.SetISBN("999-9999999 b");
            book.CheckedOut = false;
            book.MakeAvailable();
            book.MakeCheckedOut();
            book.BookStatus=BStatus.Available;
            //book.BookStatus = BStatus.aaaaaa;         //Status must be one of the Bstatus Enum or compile error
            book.SetBookStatus("Available");
            //book.SetBookStatus("aaaaaa");             //Status string must be one of the Bstatus Enum or Argument exception 
            Console.WriteLine(book + "\n");

            EBook ebook = new EBook();
            ebook.SetAuthor("Abdalrahman E");
            ebook.SetTitle("Clean Code E");
            ebook.SetISBN("999-9999999 E");
            ebook.CheckedOut = false;
            ebook.SetFormat("PDF E");
            ebook.SetSize(888);
            ebook.Download();
            ebook.BookStatus=BStatus.CheckedOut;
            //ebook.BookStatus=BStatus.aaaaaa;         //Status must be one of the Bstatus Enum or gives compile error
            ebook.SetBookStatus("CheckedOut");      
            //ebook.SetBookStatus("aaaaaa");           //Status string must be one of the Bstatus Enum or throws Argument exception 
            Console.WriteLine(ebook + "\n");

            AudioBook audiobook = new AudioBook();
            audiobook.SetAuthor("Abdalrahman a");
            audiobook.SetTitle("Clean Code a");
            audiobook.SetISBN("999-9999999 a");
            audiobook.CheckedOut = false;
            audiobook.SetDuration(999);
            audiobook.SetNarratorName("elegail a");
            audiobook.StartPlaying();
            audiobook.BookStatus=BStatus.Reserved;
            //audiobook.BookStatus=BStatus.aaaaaa;        //Status must be one of the Bstatus Enum or compile error
            audiobook.SetBookStatus("Reserved");
            //audiobook.SetBookStatus("aaaaaa");          //Status string must be one of the Bstatus Enum or Argument exception 
            Console.WriteLine(audiobook + "\n");

            Console.ReadKey();
        }
    }
}
