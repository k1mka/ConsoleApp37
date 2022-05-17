using System;

namespace ConsoleApp37
{
    class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x} , Y: {_y}");
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {




        }
    }
}
