using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_LAB2
{
    public class Sphere : Shape3D
    {
        private float radius;
        private Vector3 center;
        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public override Vector3 Center => new Vector3(center.X, center.Y, center.Z);

        public override float Area =>
            (float)(4 * Math.PI * (Math.Pow(radius, 2)));

        public override float Volume =>
            (float)((4 * Math.PI * (Math.Pow(radius, 3))) / 3);

        public override string ToString()
        {
            return $"sphere @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}): r = {radius:0.0}";
        }
    }
}
