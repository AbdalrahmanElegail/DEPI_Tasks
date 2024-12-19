namespace task_oop
{
    public class EBook : Book
    {
        public double Size { get; private set; }
        public string Format { get; private set; }

        public void SetSize(double size)
        {
            if (size > 0)
                Size = size;
            else
                throw new ArgumentException("Size cannot be negative or zero.");
        }

        public void SetFormat(string format)
        {
            if (!string.IsNullOrWhiteSpace(format))
                Format = format;
            else
                throw new ArgumentException("Format cannot be empty.");
        }

        public void Download() => Console.WriteLine("Downloading...");
        public override string ToString() =>
            $"Title: {Title}      Author: {Author}" +
            $"\nISBN: {ISBN}      CheckedOut: {CheckedOut}" +
            $"\nSize: {Size}                Format: {Format}";
    }
}
