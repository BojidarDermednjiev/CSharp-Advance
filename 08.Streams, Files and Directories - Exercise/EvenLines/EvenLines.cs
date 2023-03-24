namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            string output = string.Empty;
            var charsToReplace = new[] { '-', ',', '.', '!', '?' };
            string currentLine;
            int counter = default;
            using (var reader = new StreamReader(inputFilePath))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    counter++;
                    if (counter % 2 == 0)
                        continue;
                    StringBuilder sb = new StringBuilder(currentLine);
                    for (int currentSymbol = 0; currentSymbol < sb.Length; currentSymbol++)
                        if (charsToReplace.Contains(sb[currentSymbol]))
                            sb[currentSymbol] = '@';
                    var words = new List<string>(sb.ToString().Split());
                    words.Reverse();
                    output += String.Join(" ", words) + Environment.NewLine;
                }
            }
            return output;
        }
    }
}
