namespace _02._Array_Creator
{
    using GenericArrayCreator;
    public class StartUp
    {
        static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
        }
    }
}
