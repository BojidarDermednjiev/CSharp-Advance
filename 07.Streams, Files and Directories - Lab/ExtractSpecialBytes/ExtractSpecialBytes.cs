namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<byte> bytes = new List<byte>();
            List<byte> occurences = new List<byte>();
            using (var reader = new StreamReader(bytesFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    bytes.Add(byte.Parse(line));
            }
            using (var binaryBytes = new FileStream(binaryFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[binaryBytes.Length];
                binaryBytes.Read(buffer, 0, buffer.Length);
                for (int currentByte = 0; currentByte < buffer.Length; currentByte++)
                    if (bytes.Contains(buffer[currentByte]))
                        occurences.Add(buffer[currentByte]);
            }
            using (var outputFile = new FileStream(outputPath, FileMode.Create))
                outputFile.Write(occurences.ToArray(), 0, occurences.Count);
        }
    }
}
