﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_3
{
    public struct Complex
    {
        public double im;
        public double re;
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
        public static Complex Plus(Complex z1, Complex z2)
        {
            Complex z;
            z.re = z1.re + z2.re;
            z.im = z1.im + z2.im;
            return z;
        }
        public static Complex Minus(Complex z1, Complex z2)
        {
            Complex z;
            z.re = z1.re - z2.re;
            z.im = z1.im - z2.im;
            return z;
        }
        public static Complex Multi(Complex z1, Complex z2)
        {
            Complex z;
            z.re = z1.re * z2.re - z1.im * z2.im;
            z.im = z1.re * z2.im + z1.im * z2.re;
            return z;
        }
        public static Complex Divide(Complex z1, Complex z2)
        {
            Complex z;
            z.re = (z1.re * z2.re + z1.im * z2.im) / (z2.re * z2.re + z2.im * z2.im);
            z.im = (z2.re * z1.im - z1.re * z2.im) / (z2.re * z2.re + z2.im * z2.im);
            return z;
        }
    }
}

