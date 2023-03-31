namespace IteratorsAndComparators
{
    using System;
    using System.Collections.Generic;
    public class Book
    {
        private string title;
        private int year;
        private List<string> authors;
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get => title; set => title = value; }
        public int Year { get => year; set => year = value; }
        public List<string> Authors { get => authors; set => authors = value; }
        public override string ToString()
         => $"{Title} - {Year} - {String.Join(", ", Authors)}";
    }
}
