namespace IteratorsAndComparators
{
    using System.Collections.Generic;
    public class Library
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }
        public List<Book> Books { get => books; set => books = value; }
    }
}
