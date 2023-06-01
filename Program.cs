using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Порахувати, скільки разів кожне слово зустрічається в заданому тексті.
//Результат записати до колекції Dictionary<TKey, TValue>

namespace Dictionary
{
    internal class Program
    {
        public static string[] SplitToWords(string text)
        {
            var wordSeparators = new char[] { ' ', ',', '.', '!', '?', ':', ';', '-' };
            string[] words = text.ToLower().Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        public static Dictionary<string, int> CountWords(string[] words)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (countWords.ContainsKey(word))
                {
                    countWords[word]++;
                }
                else
                {
                    countWords[word] = 1;
                }
            }
            return countWords;
        }

        static void Main(string[] args)
        {
            string text = "To be, or not to be, that is the question:";
            Dictionary<string, int> countWords = CountWords(SplitToWords(text));
            foreach (var pair in countWords)
            {
                Console.WriteLine($"Ключ : {pair.Key}\tЗначение : {pair.Value}");
            }
        }
    }
}
