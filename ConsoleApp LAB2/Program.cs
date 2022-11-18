using System;
using System.Collections.Generic;
using ClassLibrary_LAB2;

namespace Lab2Konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[20];

            float averageArea = 0;

            for (int i = 0; i < 20; i++)
            {
                shapes[i] = Shape.GenerateShape();
                Console.WriteLine(shapes[i]);

                averageArea += shapes[i].Area;

            }

            Console.WriteLine("---");
            Console.WriteLine($"Average Area of Shapes: {averageArea / 20:0.0}");
        }
    }
}
