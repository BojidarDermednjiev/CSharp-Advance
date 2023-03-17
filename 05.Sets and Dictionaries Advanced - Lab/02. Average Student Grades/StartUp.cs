namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int numberOfStudents;
            Dictionary<string, List<double>> dataGrade;
            GetInfo(out numberOfStudents, out dataGrade);
            Engine(numberOfStudents, dataGrade);
            IO(dataGrade);
        }

        private static void GetInfo(out int numberOfStudents, out Dictionary<string, List<double>> dataGrade)
        {
            numberOfStudents = int.Parse(Console.ReadLine());
            dataGrade = new Dictionary<string, List<double>>();
        }

        private static void Engine(int numberOfStudents, Dictionary<string, List<double>> dataGrade)
        {
            for (int currentStudent = 0; currentStudent < numberOfStudents; currentStudent++)
            {
                var entryStudent = Console.ReadLine();
                string nameOfStudent = entryStudent.Split().First();
                double grade = double.Parse(entryStudent.Split().Last());
                if (!dataGrade.ContainsKey(nameOfStudent))
                    dataGrade.Add(nameOfStudent, new List<double>());
                dataGrade[nameOfStudent].Add(grade);
            }
        }

        private static void IO(Dictionary<string, List<double>> dataGrade)
        {
            foreach (var grade in dataGrade)
                Console.WriteLine($"{grade.Key} -> " + String.Join(" ", grade.Value.Select(grade => $"{grade:f2}")) + $" (avg: {grade.Value.Average():f2})");
        }
    }
}
