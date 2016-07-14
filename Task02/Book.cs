using System;

namespace Task02
{
    public sealed class Book: IEquatable<Book>, IComparable<Book>
    {

        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public int YearOfPublish { get; set; }
        /// <summary>
        /// The constructor receives 4 fields as parameters: author, title, number of pages and year of publication of the book.
        /// </summary>
        public Book(string author, string title, int pages, int yearOfPublish)
        {
            if(author==null || title==null)
                throw new ArgumentNullException();
            Author = author;
            Title = title;
            Pages = pages;
            YearOfPublish = yearOfPublish;
        }
        /// <summary>
        /// The constructor receives object of the book.
        /// </summary>
        public Book(Book otherBook)
        {
            if (ReferenceEquals(otherBook,null))
                throw new ArgumentNullException();
            Author = otherBook.Author;
            Title = otherBook.Title;
            Pages = otherBook.Pages;
            YearOfPublish = otherBook.YearOfPublish;
        }

        #region implements interfaces
        /// <summary>
        /// Method compare two books.
        /// </summary>
        /// <param name="other">This is book from which we will compare.</param>
        public bool Equals(Book other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return (other.Author == Author)&&(other.Title == Title)&&
                (other.Pages == Pages)&&(other.YearOfPublish==YearOfPublish);
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            if (other.Pages > Pages) return 1;
            if (other.Pages < Pages) return -1;
            return 0;
        }
        #endregion

        #region implements object methods
        /// <summary>
        /// Override Equals method of object method.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            Book book = obj as Book;
            if (book == null)
                return false;
            return Equals(book);
        }
        /// <summary>
        /// Override GetHashCode method of object method.
        /// </summary>
        /// <returns>returns a hashcode.</returns>
        public override int GetHashCode() => ToString().GetHashCode();
        /// <summary>
        /// Override ToString method of object method.
        /// </summary>
        /// <returns>returns a string value.</returns>
        public override string ToString() => $"Book {Title} published in {YearOfPublish} by {Author} and has {Pages} pages.";
        #endregion

        /// <summary>
        /// Method sort array of books. How it will be sort depends on comparer.
        /// </summary>
        /// <param name="books">Array of books.</param>
        /// <param name="comparer">Comparer</param>
        /// <returns>returns a sorted array of books.</returns>
        public static Book[] Sort(Book[] books, ISortBooksArray comparer)
        {
            if (ReferenceEquals(null, books) || ReferenceEquals(null, comparer))
                throw new ArgumentNullException();
            for (int i = 0; i < books.Length - 1; i++)
            {
                if (comparer.Compare(books[i], books[i + 1]))
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
