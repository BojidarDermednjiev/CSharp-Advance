namespace LineNumbers
{
    using System.IO;
    using System.Runtime.ConstrainedExecution;

    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                using (var writer = new StreamWriter(outputFilePath))
                {
                    int currentLine = default;
                    string inputLine;
                    while ((inputLine = reader.ReadLine()) != null)
                        writer.WriteLine($"{++currentLine}. {inputLine}");
                }
            }
        }
    }
}
