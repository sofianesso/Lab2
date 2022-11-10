using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_LAB2
{
    public class Cuboid : Shape3D
    {
        private float width, height, length;
        private Vector3 center;
        private bool isCube = false;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.width = size.X;
            this.height = size.Y;
            this.length = size.Z;

            if (size.X == size.Y && size.Y == size.Z)
            {
                isCube = true;
            }
            

        }


        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.width = width;
            this.height = width;
            this.length = width;

            isCube = true;

        }

        public override Vector3 Center => new Vector3(center.X, center.Y, center.Z);

        
        public override float Area => (float)((2 * length * width) + (2 * length * height) + (2 * height * width));

        public override float Volume
        {

            get
            {
                if (isCube == true)
                {
                   
                    return (float)(Math.Pow(length, 3));
                }
                else
                  
                    return (float)(width * height * length);
            }
        }

        public override string ToString()
        {
            if (isCube == true)
            {
                return $"cube @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}) w = {width:0.0}, h = {height:0.0}, l = {length:0.0}";
            }
            else
            {
                return $"cuboid @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}) w = {width:0.0}, h = {height:0.0}, l = {length:0.0}";
            }
        }



    }
}
