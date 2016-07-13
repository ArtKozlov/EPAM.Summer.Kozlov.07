using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Triangle: Figure
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }
        public double Height { get; }
        /// <summary>
        /// a,b,c are sides of triangle. h is height of triangle.
        /// </summary>
        public Triangle(double a, double b, double c, double h)
        {
            ASide = a;
            BSide = b;
            CSide = c;
            Height = h;
        }

        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double GetPerimeter() => ASide + BSide + CSide;
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double GetArea() => (ASide * Height) / 2;
    }
}
