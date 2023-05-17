using System;

namespace OverloadOperator.Model
{
    internal class Point
    {
        /// <summary>
        /// Координаты точки в трехмерном пространстве
        /// </summary>
        public int x, y, z;
        /// <summary>
        /// Инициализирует начало координат
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Перегрузка бинарную операцию + (сложение векторов)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Point operator +(Point v1, Point v2)
        {
            Point v = new Point();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        /// <summary>
        /// Перегрузка бинарную операцию - (разность векторов)
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Point operator -(Point v1, Point v2)
        {
            Point v = new Point();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        /// <summary>
        /// Печать на консоль
        /// </summary>
        /// <param name="s"></param>
        public void PrintV(string s)
        {
            Console.WriteLine($"{s} {x} {y} {z}");
        }
    }
}
