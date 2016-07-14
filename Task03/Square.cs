using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Square: IShape
    {
        public double ASide { get; }
        /// <summary>
        /// a is side of square.
        /// </summary>
        public Square(double a)
        {
            ASide = a;
        }

        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public double GetPerimeter() => ASide * 4;
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public double GetArea() => Math.Pow(ASide, 2);
    }
}
