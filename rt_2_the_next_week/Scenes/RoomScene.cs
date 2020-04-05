﻿using rt_2_the_next_week.Mathematics;

namespace rt_2_the_next_week.Scenes
{
    public class RoomScene
        : IScene
    {
        public Camera Camera { get; }
        public IHitable World { get; }

        public RoomScene(double aspect)
        {
            var red = new Lambertian(ConstantTexture.Create(0.65, 0.05, 0.05));
            var white = new Lambertian(ConstantTexture.Create(0.73, 0.73, 0.73));
            var green = new Lambertian(ConstantTexture.Create(0.12, 0.45, 0.12));
            var light = new DiffuseLight(ConstantTexture.Create(15, 15, 15));
            IHitable[] hitables = {
                            new FlipNormals(new YZRect(0, 555, 0, 555, 555, green)),
                            new YZRect(0, 555, 0, 555, 0, red),
                            new XZRect(213, 343, 227, 332, 554, light),
                            new FlipNormals(new XZRect(0, 555, 0, 555, 555, white)),
                            new XZRect(0, 555, 0, 555, 0, white),
                            new FlipNormals(new XYRect(0, 555, 0, 555, 555, white))
                        };
            World = new BVHNode(hitables, 0, 1);
            var lookFrom = Vec3.Create(278, 278, -800);
            var lookAt = Vec3.Create(278, 278, 0);
            double dist_to_focus = 10;
            double aderpture = 0;
            double vfov = 40;
            Camera = Camera.CreateLookAt(lookFrom, lookAt, Vec3.Create(0, 1, 0), vfov, aspect, aderpture, dist_to_focus);
        }

        public Vec3 Sky(Ray r) => Vec3.Create(0);
    }
}
