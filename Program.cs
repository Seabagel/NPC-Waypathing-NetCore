using System;

namespace NPC_Waypathing_NetCore
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine();

            vector2 worldSize = new vector2(10, 5);
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
                    if (CollPoints[j, i].isPoint) Console.Write($" T");
                    else Console.Write($" x");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hello World!");
        }
    }
}
