using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class CompareByAuthor: ISortBooksArray
    {
        /// <summary>
        /// Method use author property of books for compare.
        /// </summary>
        public int Compare(Book lhs, Book rhs)
        {
            if (ReferenceEquals(null, lhs) || ReferenceEquals(null, rhs))
                throw new ArgumentNullException();
            if (string.Compare(lhs.Author, rhs.Author) == 1)
                return 1;
            if (string.Compare(lhs.Author, rhs.Author) == 0)
                return 0;
            return -1;
        }
    }
}
