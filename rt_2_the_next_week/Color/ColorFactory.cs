﻿using System;
using System.Drawing;
using rt_2_the_next_week.Mathematics;

namespace rt_2_the_next_week.Color
{
    public static class ColorFactory
    {
        public static System.Drawing.Color Create(Vec3 v)
        {
            Func<double, int> toColor = (v) => (int)(Math.Min(v * 255.0, 255.0) + 0.5);
            return System.Drawing.Color.FromArgb(toColor(v.X), toColor(v.Y), toColor(v.Z));
        }

        public static System.Drawing.Color CreateSquare(Vec3 v)
        {
            Func<double, int> toColor = (v) => (int)(Math.Min(Math.Sqrt(Math.Max(0.0, v)) * 255.0, 255.0) + 0.5);
            return System.Drawing.Color.FromArgb(toColor(v.X), toColor(v.Y), toColor(v.Z));
        }
    }
}