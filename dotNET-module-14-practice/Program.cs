using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_14_practice
{
    class Program
    {
        static void ex1()
        {
            Console.WriteLine("\nЗАДАЧА №1\n");

            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится " +
                      "В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует " +
                      "пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            // Удаление знаков препинания и преобразование в нижний регистр
            char[] separators = { ' ', '.', ',', '-', '\n', '\r' };
            string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Количества вхождений слов в тексте
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Вывод
            Console.WriteLine("Слово\t\tЧастота");
            foreach (var pair in wordCount.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
        }
        static void Main(string[] args)
        {
            ex1();
        }
    }
}
