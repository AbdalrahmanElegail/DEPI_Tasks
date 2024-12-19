namespace task_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetAuthor("Abdalrahman B");
            book.SetTitle("Clean Code B");
            book.SetISBN("999-9999999 B");
            book.CheckedOut = false;
            book.MakeAvailable();
            book.MakeCheckedOut();
            //book.SetAuthor(" ");          //Author can't be empty
            //book.SetTitle("");            //Title can't be empty
            //book.SetISBN(null);           //ISBN can't be empty
            Console.WriteLine(book+"\n");

            EBook ebook = new EBook();
            ebook.SetAuthor("Abdalrahman E");
            ebook.SetTitle("Clean Code E");
            ebook.SetISBN("999-9999999 E");
            ebook.CheckedOut = false;
            ebook.SetFormat("PDF E");
            ebook.SetSize(999);
            ebook.Download();
            //writtenbook.SetFormat(" ");         //Format can't be empty
            //writtenbook.SetSize(-15);           //Size can't be negative or zero
            Console.WriteLine(ebook+"\n");

            AudioBook audiobook = new AudioBook();
            audiobook.SetAuthor("Abdalrahman A");
            audiobook.SetTitle("Clean Code A");
            audiobook.SetISBN("999-9999999 A");
            audiobook.CheckedOut = false;
            audiobook.SetDuration(999);            
            audiobook.SetNarratorName("elegail A");
            audiobook.StartPlaying();
            //audiobook.SetDuration(-999);         //duration can't be negative or zero
            //audiobook.SetNarratorName("");       //narrator name can't be empty
            Console.WriteLine(audiobook+"\n");

            Console.ReadKey();
        }
    }
}
