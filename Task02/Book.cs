using System;
using System.CodeDom;

namespace Task02
{
    public sealed class Book: IEquatable<Book>, IComparable<Book>
    {

        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public int YearOfPublish { get; set; }

        public Book(string author, string title, int pages, int yearOfPublish)
        {
            if(author==null || title==null)
                throw new ArgumentNullException();
            Author = author;
            Title = title;
            Pages = pages;
            YearOfPublish = yearOfPublish;
        }
        public Book(Book otherBook)
        {
            if (ReferenceEquals(otherBook,null))
            throw new NullReferenceException();
            Author = otherBook.Author;
            Title = otherBook.Title;
            Pages = otherBook.Pages;
            YearOfPublish = otherBook.YearOfPublish;
        }

#region implements interfaces
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
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            Book book = obj as Book;
            if (book == null)
                return false;
            return Equals(book);
        }

        public override int GetHashCode() => ToString().GetHashCode();

        public override string ToString() => $"Book {Title} published in {YearOfPublish} by {Author} and has {Pages} pages.";
#endregion

        public static Book[] Sort(Book[] books, ISortBooksArray comparer)
        {
            if (ReferenceEquals(null, books) || ReferenceEquals(null, comparer))
                throw new NullReferenceException();
            for (int i = 0; i < books.Length - 1; i++)
            {
                if (comparer.Compare(books[i], books[i + 1]))
                    Swap(ref books, i);
            }
            return books;
        }

        private static void Swap(ref Book[] books, int i)
        {
            Book temp = books[i];
            books[i] = books[i + 1];
            books[i + 1] = temp;
        }
    }
}
