using Hackathon_Assignment2.Data;

namespace Hackathon_Assignment2.UI
{
    public static class UIHandler
    {
        public static void Run()
        {
            Console.WriteLine("Enter book details. Type 'end' to finish:");

            List<string> inputLines = new();
            string? line;
            while ((line = Console.ReadLine())?.Trim().ToLower() != "end")
            {
                inputLines.Add(line);
            }

            var result = BookManager.SortTitles(inputLines);
            Console.WriteLine("\nSorted Titles:");
            result.ForEach(Console.WriteLine);
        }
    }
}