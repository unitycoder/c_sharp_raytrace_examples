﻿namespace rt_1_in_one_week.Mathematics
{
    public class HitRecord
    {
        private double  _t;
        private Vec3 _p;
        private Vec3 _normal;

        public double T { get => _t; }
        public Vec3 P { get => _p; }
        public Vec3 Normal { get => _normal; }

        public HitRecord(double t, Vec3 p, Vec3 normal)
        {
            _t = t;
            _p = p;
            _normal = normal;
        }
    }
}
