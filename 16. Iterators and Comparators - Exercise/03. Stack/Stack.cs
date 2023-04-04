namespace _03._Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Stack<T> : IEnumerable<T>
    {
        public List<T> Items;

        public Stack()
        {
            this.Items = new List<T>();
        }

        public void Push(params T[] elements)
        {
            this.Items.AddRange(elements);
        }

        public T Pop()
        {
            if (this.Items.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }
            else
            {
                T element = this.Items[this.Items.Count - 1];
                this.Items.RemoveAt(this.Items.Count - 1);
                return element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int currentElement = this.Items.Count - 1; currentElement >= 0; currentElement--)
                yield return this.Items[currentElement];
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
