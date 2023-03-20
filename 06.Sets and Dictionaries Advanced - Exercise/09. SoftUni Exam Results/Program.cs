namespace _09._SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            Dictionary<string, int> studentDict, languageDict;
            Data(out studentDict, out languageDict);
            Engine(studentDict, languageDict);
            IO(studentDict, languageDict);
        }
        private static void Data(out Dictionary<string, int> studentDict, out Dictionary<string, int> languageDict)
        {
            studentDict = new Dictionary<string, int>();
            languageDict = new Dictionary<string, int>();
        }
        private static void Engine(Dictionary<string, int> studentDict, Dictionary<string, int> languageDict)
        {
            string inputLineFromConsole;
            while ((inputLineFromConsole = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = inputLineFromConsole.Split("-");
                if (tokens[1] == "banned")
                {
                    studentDict.Remove(tokens[0]);
                    continue;
                }
                string student, language;
                int points;
                GetInfo(tokens, out student, out language, out points);
                if (!studentDict.ContainsKey(student))
                    studentDict.Add(student, 0);
                if (studentDict[student] < points)
                    studentDict[student] = points;

                if (!languageDict.ContainsKey(language))
                    languageDict.Add(language, 0);
                languageDict[language]++;
            }
        }
        private static void GetInfo(string[] tokens, out string student, out string language, out int points)
        {
            student = tokens[0];
            language = tokens[1];
            points = int.Parse(tokens[2]);
        }
        private static void IO(Dictionary<string, int> studentDict, Dictionary<string, int> languageDict)
        {
            Console.WriteLine("Results:");
            foreach (var student in studentDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine($"{student.Key} | {student.Value}");
            Console.WriteLine("Submissions:");
            foreach (var language in languageDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine($"{language.Key} - {language.Value}");
        }
    }
}
