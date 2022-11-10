using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_LAB2
{
    public class Circle : Shape2D
    {
        private Vector2 center;
        private float radius;

        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override string ToString() => $"circle @({center.X:0.0},{center.Y:0.0}) r: {radius:0.0}";

        public override Vector3 Center => new Vector3(center.X, center.Y, 0f);

        public override float Area => (float)(radius * radius * Math.PI);

        public override float Circumference => (float)(radius * 2 * Math.PI);

    }

}
