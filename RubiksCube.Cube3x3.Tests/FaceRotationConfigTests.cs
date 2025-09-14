using RubiksCube.Cube3x3.Models;
using RubiksCube.Library.Enums;
using RubiksCube.Library.Models;
using RubiksCube.Cube3x3.Configs;

namespace RubiksCube.Cube3x3.Tests
{
    public class FaceRotationConfigPhysicalTests
    {
        [TestCase("TopClockWise", "Top", 1)]
        [TestCase("TopAntiClockwise", "Top", 1)]
        [TestCase("BottomClockwise", "Bottom", 3)]
        [TestCase("BottomAntiClockwise", "Bottom", 3)]
        [TestCase("LeftClockwise", "Left", 1)]
        [TestCase("LeftAnticlockwise", "Left", 1)]
        [TestCase("RightClockwise", "Right", 3)]
        [TestCase("RightAntiClockwise", "Right", 3)]
        [TestCase("FrontClockwise", "Front", 3)]
        [TestCase("FrontAntiClockwise", "Front", 3)]
        [TestCase("BackClockwise", "Back", 1)]
        [TestCase("BackAntiClockwise", "Back", 1)]
        public void FaceRotationConfig_Prints_AffectedSquares(string configName, string faceName, int rowOrCol)
        {
            var cube = GetSolvedCube();
            var fieldInfo = typeof(FaceRotationConfigs).GetField(configName);
            var config = fieldInfo?.GetValue(null) as FaceRotationConfig;
            cube.RotateFace(config);

            // Print the rotated face
            PrintFace(faceName + " face", GetFace(cube, faceName));

            // Print affected rows/columns of adjacent faces
            foreach (var edge in config.AdjacentEdges)
            {
                var adjFace = GetFace(cube, edge.Face.ToString());
                if (edge.Edge == Edge.Row)
                    PrintRow($"{edge.Face} row {edge.Index}", adjFace, edge.Index);
                else
                    PrintCol($"{edge.Face} col {edge.Index}", adjFace, edge.Index);
            }
        }

        private Cube3x3x3 GetSolvedCube()
        {
            return new Cube3x3x3()
                .AddTop(new CubeFace3x3(Square.White, Square.White, Square.White,
                                        Square.White, Square.White, Square.White,
                                        Square.White, Square.White, Square.White))
                .AddFront(new CubeFace3x3(Square.Red, Square.Red, Square.Red,
                                          Square.Red, Square.Red, Square.Red,
                                          Square.Red, Square.Red, Square.Red))
                .AddLeft(new CubeFace3x3(Square.Blue, Square.Blue, Square.Blue,
                                         Square.Blue, Square.Blue, Square.Blue,
                                         Square.Blue, Square.Blue, Square.Blue))
                .AddRight(new CubeFace3x3(Square.Green, Square.Green, Square.Green,
                                          Square.Green, Square.Green, Square.Green,
                                          Square.Green, Square.Green, Square.Green))
                .AddBack(new CubeFace3x3(Square.Orange, Square.Orange, Square.Orange,
                                         Square.Orange, Square.Orange, Square.Orange,
                                         Square.Orange, Square.Orange, Square.Orange))
                .AddBottom(new CubeFace3x3(Square.Yellow, Square.Yellow, Square.Yellow,
                                           Square.Yellow, Square.Yellow, Square.Yellow,
                                           Square.Yellow, Square.Yellow, Square.Yellow));
        }

        private CubeFace3x3 GetFace(Cube3x3x3 cube, string faceName)
        {
            return faceName switch
            {
                "Top" => cube.Faces[Aspect.Top],
                "Front" => cube.Faces[Aspect.Front],
                "Left" => cube.Faces[Aspect.Left],
                "Right" => cube.Faces[Aspect.Right],
                "Back" => cube.Faces[Aspect.Back],
                "Bottom" => cube.Faces[Aspect.Bottom],
                _ => throw new System.ArgumentException($"Unknown face: {faceName}")
            };
        }

        private void PrintFace(string name, CubeFace3x3 face)
        {
            TestContext.WriteLine($"{name}:");
            for (int i = 1; i <= 3; i++)
            {
                var row = face.GetRow(i);
                TestContext.WriteLine(string.Join(" ", row));
            }
        }

        private void PrintRow(string name, CubeFace3x3 face, int row)
        {
            var rowVals = face.GetRow(row);
            TestContext.WriteLine($"{name}: {string.Join(" ", rowVals)}");
        }

        private void PrintCol(string name, CubeFace3x3 face, int col)
        {
            var colVals = face.GetColumn(col);
            TestContext.WriteLine($"{name}: {string.Join(" ", colVals)}");
        }
    }
}
