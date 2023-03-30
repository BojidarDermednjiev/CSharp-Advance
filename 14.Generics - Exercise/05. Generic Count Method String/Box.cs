namespace _05._Generic_Count_Method_String
{
    using System.Linq;
    using System.Collections.Generic;
    public class Box<T>
    {
        private T boxValue;
        public T BoxValue { get => boxValue; set => boxValue = value; }
        public Box(T boxValue)
        {
            BoxValue = boxValue;
        }
        public static int GetCountLargerElements(List<Box<T>> list, T item)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            var finalValue = list.Where(x => comparer.Compare(x.boxValue, item) > 0).ToList().Count;
            return finalValue;
        }
    }
}
