﻿using rt_2_the_next_week.Mathematics;

namespace rt_2_the_next_week.Scenes
{
    public class MaterialsScene
        : IScene
    {
        public Camera Camera { get; }
        public IHitable World { get; }

        public MaterialsScene(double aspect)
        {
            IHitable[] hitables = {
                            new Sphere(Vec3.Create(0, -100.5, 0), 100, new Lambertian(ConstantTexture.Create(0.8, 0.8, 0.0))),
                            new Sphere(Vec3.Create(0, 0, 0), 0.5, new Lambertian(ConstantTexture.Create(0.1, 0.2, 0.5))),
                            new Sphere(Vec3.Create(1, 0, 0), 0.5, new Metal(ConstantTexture.Create(0.8, 0.6, 0.2), 0.3)),
                            new Sphere(Vec3.Create(-1, 0, 0), 0.5, new Dielectric(1.5)),
                            new Sphere(Vec3.Create(-1, 0, 0), -0.45, new Dielectric(1.5))
                        };
            World = new BVHNode(hitables, 0, 1);
            Camera = Camera.CreateLookAt(Vec3.Create(0.25, 0.5, 2.2), Vec3.Create(0.1, 0.0, 0), Vec3.Create(0, 1, 0), 45, aspect, 0, 1);
        }
    }
}

