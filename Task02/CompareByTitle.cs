using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class CompareByTitle: ISortBooksArray
    {
        /// <summary>
        /// Method use title property of books for compare.
        /// </summary>
        public bool Compare(Book lhs, Book rhs)
        {
            if (ReferenceEquals(null, lhs) || ReferenceEquals(null, rhs))
                throw new NullReferenceException();
            if (string.Compare(lhs.Title, rhs.Title) == 1)
                return true;
            return false;
        }
    }
}
