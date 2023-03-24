namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var output = new StringBuilder();
            int lineCounter = 1;
            string line;
            using (var reader = new StreamReader(inputFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    MatchCollection letterMatches = Regex.Matches(line, @"[A-Za-z]");
                    MatchCollection punctuationMatches = Regex.Matches(line, @"[-.!,?']");
                    output.Append($"Line {lineCounter}: ")
                        .Append(line)
                        .Append($" ({letterMatches.Count})({punctuationMatches.Count})")
                        .AppendLine();
                    lineCounter++;
                }
            }
            using (var writer = new StreamWriter(outputFilePath))
                writer.Write(output);
        }
    }
}
