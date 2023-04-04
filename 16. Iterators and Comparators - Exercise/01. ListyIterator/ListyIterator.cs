namespace _01._ListyIterator
{
    using System;
    using System.Collections.Generic;
    public class ListyIterator<T>
    {
        private int currentIndex;
        public List<T> Elements;
        public ListyIterator(params T[] entries)
        {
            Elements = new List<T>(entries);
            this.currentIndex = 0;
        }
        public bool Move()
            => currentIndex < Elements.Count - 1 ? IfIsTrue() : false;

        private bool IfIsTrue()
        {
            currentIndex++; return true;
        }
        public bool HasNext()
            => currentIndex < Elements.Count - 1;
        public void Print()
        {
            Console.WriteLine(Elements.Count != 0 ? $"{Elements[currentIndex]}" : "Invalid Operation");
        }
    }
}
