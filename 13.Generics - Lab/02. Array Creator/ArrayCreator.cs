namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T element)
        { 
            var array = new T[length];
            for (int currentElement = 0; currentElement < array.Length; currentElement++)
                array[currentElement] = element;
            return array;
        }
    }
}
