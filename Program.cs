using System.Collections.Generic;
using System;

namespace NPC_Waypathing_NetCore
{
    class Program
    {
        struct WorldSize : vector2
        {
            public int x { get; set; }
            public int y { get; set; }

            public WorldSize(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Point : vector2
        {
            public int x { get; set; }
            public int y { get; set; }
            public bool isPoint { get; set; }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                isPoint = false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine();

            WorldSize worldSize = new WorldSize(10, 5);
            Point[,] CollPoints = new Point[worldSize.x, worldSize.y];

            for (int i = 0; i < worldSize.y; i++)
            {
                for (int j = 0; j < worldSize.x; j++)
                {
                    CollPoints[j, i] = new Point(j, i);
                }
            }

            // zero based index, remember
            CollPoints[1, 1].isPoint = true;
            CollPoints[4, 1].isPoint = true;
            CollPoints[9, 1].isPoint = true;
            CollPoints[4, 2].isPoint = true;
            CollPoints[1, 4].isPoint = true;
            CollPoints[9, 4].isPoint = true;

            for (int i = 0; i < worldSize.y; i++)
            {
                for (int j = 0; j < worldSize.x; j++)
                {
                    if (CollPoints[j, i].isPoint) Console.Write($" o");
                    else Console.Write($" x");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hello World!");
        }
    }
}
