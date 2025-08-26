using Hackathon_Assignment1.Data;
using Hackathon_Assignment1.Entities;

namespace Hackathon_Assignment1.UI
{
    public static class UIHandler
    {
        public static void Run()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine() ?? string.Empty;

            var result = WordManager.GetSortedFrequencies(input);
            if (result.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var word in result)
            {
                Console.WriteLine($"{word.Frequency} {word.Text}");
            }
        }
    }
}