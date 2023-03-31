namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Library : IEnumerable<Book>
    {
        class LibraryIterator : IEnumerator<Book>
        {
            public List<Book> Books { get; set; }

            public int currentIndex { get; set; }

            public Book Current => this.Books[currentIndex];

            object IEnumerator.Current => this.Current;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.Books = new List<Book>(books);
            }

            public void Dispose() { }

            public bool MoveNext()
                => ++this.currentIndex < this.Books.Count();

            public void Reset()
                => this.currentIndex = -1;
        }

        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
            => new LibraryIterator(this.Books);

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
