namespace OddLines
{
    using System;
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = default;
                var writer = new StreamWriter(outputFilePath);
                string inputLine;
                using (writer)
                {
                    while ((inputLine = Console.ReadLine()) != null)
                    {
                        if (counter % 2 == 0)
                            writer.WriteLine(inputLine);
                        counter++;
                    }
                }
            }
        }
    }
}
