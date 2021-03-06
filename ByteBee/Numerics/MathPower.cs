﻿using System;

namespace ByteBee.Numerics
{
    public static class MathPower
    {
        public static double BaseE(double x)
        {
            return Math.Pow(x, MathConstant.Euler);
        }

        public static double Base2(double x)
        {
            return BaseN(x, 2);
        }

        public static double Base3(double x)
        {
            return BaseN(x, 3);
        }

        public static double Base8(double x)
        {
            return BaseN(x, 8);
        }

        public static double Base10(double x)
        {
            return BaseN(x, 10);
        }

        public static double Base16(double x)
        {
            return BaseN(x, 16);
        }

        public static double BaseN(double x, double @base)
        {
            return Math.Pow(x, @base);
        }
    }
}