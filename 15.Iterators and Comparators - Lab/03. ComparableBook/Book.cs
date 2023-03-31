﻿namespace IteratorsAndComparators
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

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
        public int CompareTo([AllowNull]Book other)
        {
            int result = Year.CompareTo(other.Year);
            if(result == 0)
                result = Title.CompareTo(other.Title);
            return result;
        }
        public override string ToString()
            => $"{Title} - {Year}";
    }
}
