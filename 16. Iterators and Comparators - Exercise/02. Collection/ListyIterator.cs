namespace _02._Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class ListyIterator<T> : IEnumerable<T>
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
        public void PrintAll()
        {
            Console.WriteLine(Elements.Count != 0 ? String.Join(" ", Elements) : "Invalid Operation!");
        }
        public void Print()
        {
            Console.WriteLine(Elements.Count != 0 ? $"{Elements[currentIndex]}" : "Invalid Operation");
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int currentElement = 0; currentElement < this.Elements.Count; currentElement++)
                yield return this.Elements[currentElement];
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
