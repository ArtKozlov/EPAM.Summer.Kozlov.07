﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Rectangle: Figure
    {
        public double Width { get; }
        public double Height { get; }
        /// <summary>
        /// a,b are sides of rectangle.
        /// </summary>
        public Rectangle(double a, double b)
        {
            Width = a;
            Height = b;
        }

        /// <summary>
        /// Method using for  find a perimeter of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Perimeter() => 2 * (Width + Height);
        /// <summary>
        /// Method using for  find a area of figure.
        /// </summary>
        /// <returns>returns a number in double format.</returns>
        public override double Area() => Width * Height;
    }
}