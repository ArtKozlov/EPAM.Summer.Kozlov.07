using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class CompareByPages: ISortBooksArray
    {
        /// <summary>
        /// Method use pages property of books for compare.
        /// </summary>
        public int Compare(Book lhs, Book rhs)
        {
            if (ReferenceEquals(null, lhs) || ReferenceEquals(null, rhs))
                throw new NullReferenceException();
            if (lhs.Pages > rhs.Pages)
                return 1;
            if (lhs.Pages == rhs.Pages)
                return 0;
            return -1;
        }
    }
}
