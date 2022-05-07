using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWord = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordOfSynonyms = new Dictionary<string, List<string>>();

            for (
                int i = 0; i < numOfWord; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordOfSynonyms.ContainsKey(word))
                {
                    wordOfSynonyms[word] = new List<string>();
                }

                wordOfSynonyms[word].Add(synonym);
            }

            foreach (var word in wordOfSynonyms)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
