using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> orders = new Stack<T>();
        public int Count { get => orders.Count; }
        public void Add(T order)
        { 
            orders.Push(order);
        }
        public T Remove()
            => orders.Pop();
    }
}
