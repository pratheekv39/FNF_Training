using Hackathon_Assignment1.Entities;
using Hackathon_Assignment1.Utils;

namespace Hackathon_Assignment1.Data
{
    public static class WordManager
    {
        public static List<Word> GetSortedFrequencies(string input)
        {
            var words = WordUtil.ExtractWords(input);
            if (words.Count == 0) return new List<Word>();

            var freq = words.GroupBy(w => w)
                            .Select(g => new Word { Text = g.Key, Frequency = g.Count() })
                            .ToList();

            return freq.OrderByDescending(w => w.Frequency)
                       .ThenByDescending(w => w.Text)
                       .ToList();
        }
    }
}
