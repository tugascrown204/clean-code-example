using System;

namespace CleanCodeExample
{
    class Program
    {
        /// <summary>
        /// Calculate the area of a circle given the radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>The area of the circle.</returns>
        static double CalculateAreaOfCircle(double radius)
        {
            const double PI = Math.PI;
            return PI * Math.Pow(radius, 2);
        }

        static void Main(string[] args)
        {
            double radius = 5.0;
            double area = CalculateAreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with radius {radius} is {area:F2}");
        }
    }
}
