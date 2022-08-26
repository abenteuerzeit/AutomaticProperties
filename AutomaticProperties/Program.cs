using System;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon { NumSides = 3 };
            Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };

            Console.WriteLine($"Square: the number of sides is {square.NumSides}, the length of each side is {square.SideLength}");
            Console.WriteLine($"Triangle: the number of sides is {triangle.NumSides}, the length of each side is {triangle.SideLength}");
            Console.WriteLine($"Pentagon: the number of sides is {pentagon.NumSides}, the length of each side is {pentagon.SideLength}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
