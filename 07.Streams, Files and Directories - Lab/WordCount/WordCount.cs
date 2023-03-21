namespace WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            char[] separators = { ' ', '.', ',', '-', '?', '!' };
            string[] collectionForMatchesWords;
            string[] inputText;
            var mathesWords = new Dictionary<string, int>();
            using (var reader = new StreamReader(wordsFilePath))
                collectionForMatchesWords = reader.ReadToEnd().Split();
            using (var reader = new StreamReader(textFilePath))
                inputText = reader.ReadToEnd().Split(separators);
            using (var writer = new StreamWriter(outputFilePath))
                foreach (var word in collectionForMatchesWords)
                    foreach (var currentWord in inputText)
                        if (word.ToLower() == currentWord.ToLower())
                        {
                            if (!mathesWords.ContainsKey(word))
                                mathesWords.Add(word, 0);
                            mathesWords[word]++;
                        }
            using (var writer = new StreamWriter(outputFilePath))
                foreach (var word in mathesWords.OrderByDescending(x => x.Value))
                    writer.WriteLine($"{word.Key} - {word.Value}");

        }
    }
}
