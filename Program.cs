using System;

namespace NPC_Waypathing_NetCore
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();

            vector2 worldSize = new vector2(10, 5);
            IPoint[,] CollPoints = new IPoint[worldSize.x, worldSize.y];

            for (int i = 0; i < worldSize.y; i++)
            {
                for (int j = 0; j < worldSize.x; j++)
                {
                    CollPoints[j, i] = new PointEmpty(j, i);
                }
            }

            // zero based index, remember
            CollPoints[1, 1] = new PointJunction(1, 1);
            CollPoints[4, 1] = new PointJunction(4, 1);
            CollPoints[9, 1] = new PointTransfer(9, 1);

            CollPoints[4, 2] = new PointEnterance(4, 2);

            CollPoints[1, 4] = new PointTransfer(1, 4);

            for (int i = 0; i < worldSize.y; i++)
            {
                for (int j = 0; j < worldSize.x; j++)
                {
                    if (CollPoints[j, i].type.Equals(TypePoint.Junction)) Console.Write($" T");
                    else if (CollPoints[j, i].type.Equals(TypePoint.Transfer)) Console.Write($" >");
                    else if (CollPoints[j, i].type.Equals(TypePoint.Enterance)) Console.Write($" E");
                    else Console.Write($" x");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
