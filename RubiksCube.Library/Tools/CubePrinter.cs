using RubiksCubeSolver.Enums;
using RubiksCubeSolver.Models;
using System;

namespace RubiksCubeSolver
{
    internal static class CubePrinter
    {
        public static void Print(Cube cube)
        {
            Console.WriteLine("Cube State:");
            Console.WriteLine();

            static char C(Colour color) => color.ToString()[0];

            var top = cube.Faces[Aspect.Top].Stickers;
            var left = cube.Faces[Aspect.Left].Stickers;
            var front = cube.Faces[Aspect.Front].Stickers;
            var right = cube.Faces[Aspect.Right].Stickers;
            var bottom = cube.Faces[Aspect.Bottom].Stickers;
            var back = cube.Faces[Aspect.Back].Stickers;

            const int faceWidth = 3 * 2 - 1; // 3 stickers, 1 space between each
            const int indent = faceWidth + 2; // spaces to center top/bottom/back

            // Helper to print a face row with indentation
            void PrintIndentedRow(Colour[,] face, int row)
            {
                Console.Write(new string(' ', indent));
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(C(face[row, col]));
                    if (col < 2) Console.Write(' ');
                }
                Console.WriteLine();
            }

            // Print Top
            for (int row = 0; row < 3; row++)
                PrintIndentedRow(top, row);

            // Print Left, Front, Right
            for (int row = 0; row < 3; row++)
            {
                // Left
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(C(left[row, col]));
                    if (col < 2) Console.Write(' ');
                }
                Console.Write("  ");

                // Front
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(C(front[row, col]));
                    if (col < 2) Console.Write(' ');
                }
                Console.Write("  ");

                // Right
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(C(right[row, col]));
                    if (col < 2) Console.Write(' ');
                }
                Console.WriteLine();
            }

            // Print Bottom
            for (int row = 0; row < 3; row++)
                PrintIndentedRow(bottom, row);

            // Print Back
            for (int row = 0; row < 3; row++)
                PrintIndentedRow(back, row);
        }
    }
}