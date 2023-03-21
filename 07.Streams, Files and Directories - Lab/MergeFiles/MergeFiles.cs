namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<int> listWithNumber = new List<int>();
            using (var reader = new StreamReader(firstInputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (!String.IsNullOrWhiteSpace(line))
                        listWithNumber.Add(int.Parse(line));
            }
            using (var reader = new StreamReader(secondInputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (!String.IsNullOrWhiteSpace(line))
                        listWithNumber.Add(int.Parse(line));
            }
            using (var writer = new StreamWriter(outputFilePath))
                writer.WriteLine(String.Join(Environment.NewLine, listWithNumber.OrderBy(x => x)));
        }
    }
}
