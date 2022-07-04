using System;

namespace OperatorExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalcArea(radius);

            Console.WriteLine($"The area of your circle with a radius of {radius} is {areaOfCircle}.");
        }
        
        public static double CalcArea (double radius )
        {
            return Math.PI * (radius * radius);
        }
    }
}
