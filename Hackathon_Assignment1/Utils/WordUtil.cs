using System.Text.RegularExpressions;

namespace Hackathon_Assignment1.Utils
{
    public static class WordUtil
    {
        public static List<string> ExtractWords(string input)
        {
            return Regex.Matches(input.ToLower(), @"\b[a-z]+\b")
                        .Select(m => m.Value)
                        .ToList();
        }
    }
}
