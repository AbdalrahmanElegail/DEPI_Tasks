using System.Drawing;

namespace task_oop
{
    internal class AudioBook : Book
    {
        public int Duration { get; private set; }
        public string NarratorName { get; private set; }
        public AudioBook() => BookType = BType.Audio;   //constructor to set type to audio

        public void SetDuration(int duration)
        {
            if (duration > 0)
                Duration = duration;
            else
                throw new ArgumentException("duration cannot be negative or zero.");
        }

        public void SetNarratorName(string narratorname)
        {
            if (!string.IsNullOrWhiteSpace(narratorname))
                NarratorName = narratorname;
            else
                throw new ArgumentException("Narrator Name cannot be empty.");
        }

        public void StartPlaying() => Console.WriteLine("Audio book is playing...");

        public override string ToString() =>
               $"Title: {Title}      Author: {Author}" +
               $"\nISBN: {ISBN}      CheckedOut: {CheckedOut}" +
               $"\nDuration: {Duration}            Narrator Name: {NarratorName}" +
               $"\nBook Type: {BookType}         Book Status: {BookStatus}";

    }
}
