using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class ArrayOfBooks
    {
        /// <summary>
        /// Method sort array of books. How it will be sort depends on comparer.
        /// </summary>
        /// <param name="comparer">Comparer</param>
        /// <param name="books">Array of books.</param>
        /// <returns>returns a sorted array of books.</returns>
        public static Book[] Sort(ISortBooksArray comparer, Book[] books)
        {
            if (ReferenceEquals(null, books) || ReferenceEquals(null, comparer))
                throw new ArgumentNullException();
            for (int i = 0; i < books.Length - 1; i++)
            {
                if (comparer.Compare(books[i], books[i + 1]) == 1)
                    Swap(ref books, ref i);
            }
            return books;
        }
        /// <summary>
        /// Swap books in array of books.
        /// </summary>
        private static void Swap(ref Book[] books, ref int i)
        {
            Book temp = books[i];
            books[i] = books[i + 1];
            books[i + 1] = temp;
        }
    }
}
