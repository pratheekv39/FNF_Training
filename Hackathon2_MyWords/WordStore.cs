using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon2_MyWords
{


    public static class WordStore
    {
        private static Dictionary<string, string> Words = new Dictionary<string, string>();

        public static void AddWord(string word, string meaning)
        {
            word = word.ToLower();
            if (!Words.ContainsKey(word))
            {
                Words[word] = meaning;
            }
        }

        public static bool WordExists(string word)
        {
            return Words.ContainsKey(word.ToLower());
        }

        public static string GetMeaning(string word)
        {
            word = word.ToLower();
            return Words.ContainsKey(word) ? Words[word] : null;
        }

        public static Dictionary<string, string> GetAllWords()
        {
            return Words;
        }
    }
}