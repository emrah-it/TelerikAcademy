using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountWords
{
    internal class CountWords
    {
        private static void Main()
        {
            string[] readedWords = ReadFromFileText(@"words.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = ReadFromFileText(@"test.txt");

            Dictionary<string, int> result = CountGivenWordAndText(text, readedWords);
        }

        private static Dictionary<string, int> CountGivenWordAndText(string text, string[] readedWords)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in readedWords)
            {
                string regex = @"\b" + item + @"\b";
                MatchCollection matches = Regex.Matches(text, regex);

                result.Add(item, matches.Count);
            }

            var newOne = result.OrderByDescending(x => x.Value);
            SaveToFile("result.txt", newOne);
            return result;
        }

        private static void SaveToFile(string fileName, IOrderedEnumerable<KeyValuePair<string, int>> newOne)
        {
            StreamWriter write = new StreamWriter(fileName);
            using (write)
            {
                foreach (var item in newOne)
                {
                    write.WriteLine("{0}, {1}", item.Key, item.Value);
                }
            }
        }

        private static string ReadFromFileText(string fileName)
        {
            string readedWords;
            StreamReader readFromFile = new StreamReader(fileName);

            using (readFromFile)
            {
                readedWords = readFromFile.ReadToEnd();
            }
            return readedWords;
        }
    }
}