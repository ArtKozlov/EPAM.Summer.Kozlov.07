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
        public bool Compare(Book lhs, Book rhs)
        {
            if (ReferenceEquals(null, lhs) || ReferenceEquals(null, rhs))
                throw new NullReferenceException();
            if (lhs.Pages > rhs.Pages)
                return true;
            return false;
        }
    }
}
