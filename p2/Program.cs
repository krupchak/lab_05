using System;
using System.Collections.Generic;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");

            float length = float.Parse(input[0]);
            float width = float.Parse(input[1]);
            float height = float.Parse(input[2]);

            Box box = new Box(length, width, height);

            box.Output();
        }
    }
}
