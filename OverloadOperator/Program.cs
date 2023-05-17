using OverloadOperator.Model;
using System;

namespace OverloadOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleWithPoint();
        }
        static void ExampleWithPoint()
        {
            Point V1 = new Point(3, 4, 5);
            Point V2 = new Point(-3, -4, 5);
            V1.PrintV("Координаты первой точки : ");
            V2.PrintV("Координаты второй точки : ");
            Point V3 = V1 + V2;    // ПЕРЕГРУЗКА!
            V3.PrintV("Координаты суммы векторов: ");
            V3 = V1 - V2;           // ПЕРЕГРУЗКА!
            V3.PrintV("Координаты разности : ");
            Console.ReadLine();
        }
    }
}
