using System.Threading.Channels;

namespace task_oop
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public bool CheckedOut { get; set; }
        public BType BookType { get; set; }
        public BStatus BookStatus { get; set; }

        public Book() => BookType = BType.Paper;        //constructor to set type to paper 

        public void SetTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
                Title = title; 
            else
                throw new ArgumentException("Title cannot be empty.");
        }

        public void SetAuthor(string author)
        {
            if (!string.IsNullOrWhiteSpace(author))
                Author = author;
            else
                throw new ArgumentException("Author cannot be empty.");
        }

        public void SetISBN(string isbn)
        {
            if (!string.IsNullOrWhiteSpace(isbn))
                ISBN = isbn;
            else
                throw new ArgumentException("ISBN cannot be empty.");
        }

        public void SetBookStatus(string choice)
        {
            switch (choice)
            {
                case "Available": BookStatus = BStatus.Available; break;
                case "CheckedOut": BookStatus = BStatus.CheckedOut; break;
                case "Reserved": BookStatus = BStatus.Reserved; break;
                default: throw new ArgumentException("invalid choice....");
            }
        }

        public void MakeAvailable() => CheckedOut = false;
        public void MakeCheckedOut() => CheckedOut = true;

        public override string ToString()=>
                $"Title: {Title}      Author: {Author}" +
                $"\nISBN: {ISBN}      CheckedOut: {CheckedOut}" +
                $"\nBook Type: {BookType}         Book Status: {BookStatus}";
    }
}
