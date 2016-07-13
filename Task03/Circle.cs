using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Circle: Figure
    {
        public double Radius { get; }
        /// <summary>
        /// r is radius of circle.
        /// </summary>
        public Circle(double r)
        {
            Radius = r;
        }

        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Perimeter() => 2 * Radius * Math.PI;
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Area() => Math.PI * Math.Pow(Radius, 2);
    }
}
