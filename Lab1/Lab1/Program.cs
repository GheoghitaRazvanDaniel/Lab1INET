using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {   
        // Exercitiul 2
        public static void SentenceWords(string sentence)
        {
            char[] separators = {' ', ',', '.', '?', '!', ';', '\"', '`', '\'' };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string multipleTest = (words.Length > 1 || words.Length == 0) ? "words" : "word";
            Console.WriteLine("This sentence contains " + words.Length + " " + multipleTest);
            var countWords = new Dictionary<string, uint>();
            foreach (string word in words)
            {
                if(countWords.ContainsKey(word))
                {
                    countWords[word]++;
                }
                else
                {
                    countWords.Add(word, 1);
                }
            }
            foreach(string w in countWords.Keys)
            {
                Console.WriteLine(w + " - " + countWords[w] + " times");
            }
        }
        static void Main(string[] args)
        {
            // Teste pentru clasa Manager
            var start = "Oct 1, 2021";
            var end = "Oct 4, 2021";

            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);
            Console.WriteLine(DateTime.Now);
            Manager manager = new Manager("Gheorghita", "Razvan", startTime, endTime, 500.00);
            Console.WriteLine(manager.GetFullName());
            Console.WriteLine(manager.IsActive());
            Console.WriteLine(manager.Salutation());

            // Teste pentru clasa Architect
            start = "Feb 1, 2021";
            end = "4 Feb, 2021";
            startTime = DateTime.Parse(start);
            endTime = DateTime.Parse(end);
            Console.WriteLine(endTime);

            Architect architect = new Architect("Gheorghita","Daniel", startTime, endTime, 200.00);
            Console.WriteLine(architect.GetFullName());
            Console.WriteLine(architect.IsActive());
            Console.WriteLine(architect.Salutation());

            // Teste pentru functia SentenceWords()
            var sentence1 = "This is a a sentence.";
            var sentence2 = "This is a phrase. It should take into account the full stop.";
            var sentence3 = "Hello!";
            
            Console.WriteLine("Sentence 1: " + sentence1);
            SentenceWords(sentence1);

            Console.WriteLine("Sentence 2: " + sentence2);
            SentenceWords(sentence2);

            Console.WriteLine("Sentence 3: " + sentence3);
            SentenceWords(sentence3);
            
        }   
    }
}
