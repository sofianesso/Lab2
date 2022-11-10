using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_LAB2
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private float width, height;
        private bool isSquare;


        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.height = size.X;
            this.width = size.Y;

            if (size.X == size.Y)
            {
                isSquare = true;
            }

        }

        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            this.height = width;
            this.width = width;
            isSquare = true;

        }

        public override Vector3 Center => new Vector3(center.X, center.Y, 0f);

        public override float Area => (float)(width * height);

        public override float Circumference => (float)(width * 2) + (height * 2);

        public override string ToString()
        {
            if (isSquare == true)
            {
                return $"square @({center.X:0.0}, {center.Y:0.0}) w = {width:0.0} h = {height:0.0}";
            }
            else
            {
                return $"rectangle @({center.X:0.0}, {center.Y:0.0}) w = {width:0.0} h = {height:0.0}";
            }
        }
    }
}

