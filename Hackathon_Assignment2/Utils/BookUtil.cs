using Hackathon_Assignment2.Entities;

namespace Hackathon_Assignment2.Utils
{
    public static class BookUtil
    {
        public static Book ParseBook(string line)
        {
            var parts = line.Split("\"");
            string title = parts[1];
            string authorSection = parts[2];

            string author = authorSection.Replace("by", "").Trim().Split()[0];
            return new Book { Title = title, FirstAuthor = author };
        }
    }
}