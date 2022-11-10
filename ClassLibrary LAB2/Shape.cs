using System.Numerics;

namespace ClassLibrary_LAB2
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {

            Random random = new Random();
            int number = random.Next(0, 5);

            switch (number)
            {
                case 1:
                    return new Rectangle(RandomVector2(-10, 10), RandomVector2(1, 5));

                case 2:
                    int randomSize = random.Next(1, 5);
                    return new Rectangle(RandomVector2(-10, 10), new Vector2(randomSize, randomSize));

                case 3:
                    return new Cuboid(RandomVector3(-10, 10), RandomVector3(1, 5));

                case 4:
                    return new Sphere(RandomVector3(-10, 10), random.Next(1, 5));

                default: 
                    return new Circle(RandomVector2(-10, 10), random.Next(1, 5));
            }
        }

        
        private static Vector2 RandomVector2(int min, int max)
        {
            Random random = new Random();
            int x = random.Next(min, max);
            int y = random.Next(min, max);

            return new Vector2(x, y);
        }

        private static Vector3 RandomVector3(int min, int max)
        {
            Random random = new Random();
            int x = random.Next(min, max);
            int y = random.Next(min, max);
            int z = random.Next(min, max);

            return new Vector3(x, y, z);
        }


    }

}