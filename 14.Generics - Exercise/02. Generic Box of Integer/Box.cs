namespace _02._Generic_Box_of_Integer
{
    public class Box<T>
    {
        private T boxValue;
        public T BoxValue { get => boxValue; set => boxValue = value; }
        public Box(T boxValue)
        {
            BoxValue = boxValue;
        }
        public override string ToString()
            => $"{BoxValue.GetType()}: {BoxValue}";
    }
}
