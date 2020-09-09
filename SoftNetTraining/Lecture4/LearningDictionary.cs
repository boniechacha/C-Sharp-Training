using System;
using System.Collections.Generic;
using System.Linq;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningDictionary
    {
        public static void Run()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            data.Add("0712050609", "Chacha");
            data.Add("0678475858", "Mwita");
            data.Add("0876084994", "Ferouz");

            Dictionary<string, int> balances = new Dictionary<string, int>();

            balances.Add("0712050609", 120000);
            balances.Add("0678475858", 4560);
            balances.Add("0876084994", 45367);

            balances["0712050609"] = 2300;

            Console.WriteLine(balances["0712050609"]);


            string content = "This is a very long string with some words. This is very simple sentence with words";
            string[] words = content.Split(" ");
            ConsoleUtil.Display(words);


            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    int currentCount = wordCounts[word];
                    int newCount = currentCount + 1;
                    wordCounts[word] = newCount;
                }
                else
                {
                    wordCounts.Add(word, 1);
                }
            }

            foreach (string word in wordCounts.Keys)
            {
                Console.WriteLine("{0} -> {1}", word, wordCounts[word]);
            }
        }
    }
}