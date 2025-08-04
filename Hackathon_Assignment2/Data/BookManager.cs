using Hackathon_Assignment2.Entities;
using Hackathon_Assignment2.Utils;

namespace Hackathon_Assignment2.Data
{
    public static class BookManager
    {
        public static List<string> SortTitles(List<string> input)
        {
            var books = input.Select(BookUtil.ParseBook).ToList();

            return books.OrderBy(b => b.FirstAuthor)
                        .ThenBy(b => b.Title)
                        .Select(b => b.Title)
                        .ToList();
        }
    }
}