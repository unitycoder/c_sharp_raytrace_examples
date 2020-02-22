﻿using static System.Math;

namespace rt_1_in_one_week.Mathematics
{
    public struct Vec3
    {
        private double[] _v;

        public double this[int index] { get => _v[index]; set => _v[index] = value; }
        public double X { get => _v[0]; set => _v[0] = value; }
        public double Y { get => _v[1]; set => _v[1] = value; }
        public double Z { get => _v[2]; set => _v[2] = value; }

        public Vec3(double val) { _v = new double[3] { val, val, val }; }
        public Vec3(double x, double y, double z) { _v = new double[3] { x, y, z }; }
        public Vec3(double[] v) { _v = new double[3] { v[0], v[1], v[2] }; }
        public Vec3(Vec3 v) { _v = (double[])v._v.Clone(); }

        public Vec3 Clone() { return new Vec3(_v);  }

        public static Vec3 operator +(Vec3 a, double b) => new Vec3(a.X + b, a.Y + b, a.Z + b);
        public static Vec3 operator -(Vec3 a, double b) => new Vec3(a.X - b, a.Y - b, a.Z - b);
        public static Vec3 operator *(Vec3 a, double b) => new Vec3(a.X * b, a.Y * b, a.Z * b);
        public static Vec3 operator /(Vec3 a, double b) => new Vec3(a.X / b, a.Y / b, a.Z / b);

        public static Vec3 operator + (Vec3 a, Vec3 b) => new Vec3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vec3 operator -(Vec3 a, Vec3 b) => new Vec3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vec3 operator *(Vec3 a, Vec3 b) => new Vec3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vec3 operator /(Vec3 a, Vec3 b) => new Vec3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

        /// <summary>
        /// [Euclidean distance](https://en.wikipedia.org/wiki/Euclidean_distance)
        /// </summary>
        public double LengthSquare { get => X * X + Y * Y + Z * Z; }
        public double Length { get => Sqrt(LengthSquare); }
        public Vec3 Normalize() { this /= Length; return this; }
        public Vec3 Normalized() { return this / Length; }
        public double DistanceToSquare(Vec3 b) { return (this - b).LengthSquare; }
        public double DistanceTo(Vec3 b) { return (this - b).Length; }
        public static double DistanceSquare(Vec3 a, Vec3 b) { return (a - b).LengthSquare; }
        public static double Distance(Vec3 a, Vec3 b) { return (a - b).Length; }

        /// <summary>
        /// [Dot product](https://en.wikipedia.org/wiki/Dot_product)
        /// </summary>
        public double Dot(Vec3 b) { return X * b.X + Y * b.Y + Z * b.Z; }
        public static double Dot(Vec3 a, Vec3 b) { return a.X * b.X + a.Y * b.Y + a.Z * b.Z; }

        /// <summary>
        /// [Cross product](https://en.wikipedia.org/wiki/Cross_product)
        /// </summary>
        public Vec3 Cross(Vec3 b) { this = Cross(this, b); return this; }
        public static Vec3 Cross(Vec3 a, Vec3 b)
        {
            return new Vec3(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X); 
        }
    }
}
