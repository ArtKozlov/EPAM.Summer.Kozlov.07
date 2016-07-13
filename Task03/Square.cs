using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Square: Rectangle
    {
        public double ASide { get; }
        /// <summary>
        /// a is side of square.
        /// </summary>
        public Square(double a):base(a,a)
        {
            ASide = a;
        }

        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Perimeter() => ASide * 4;
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Area() => Math.Pow(ASide, 2);
    }
}
