using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public abstract class Figure
    {
        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public abstract double GetPerimeter();
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public abstract double GetArea();
    }
}
