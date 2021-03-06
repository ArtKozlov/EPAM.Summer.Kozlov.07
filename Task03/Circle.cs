﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Circle: IShape
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
        public double GetPerimeter() => 2 * Radius * Math.PI;
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
