﻿using System;

namespace Course
{
    internal class triangulo
    {
        public double A;
        public double B;
        public double C;

        public double area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
