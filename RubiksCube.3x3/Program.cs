using RubiksCube.Cube3x3.Models;
using RubiksCube.Library.Enums;

namespace RubiksCube.Cube3x3;

class Program
{
    static void Main(string[] args)
    {
        var cube = SetupCube();
    }

    private static Cube3x3x3 SetupCube()
    {
        var cube = new Cube3x3x3()
            .AddTop(new CubeFace3x3(
                Square.White, Square.White, Square.White,
                Square.White, Square.White, Square.White,
                Square.White, Square.White, Square.White))
            .AddFront(new CubeFace3x3(
                Square.Red, Square.Red, Square.Red,
                Square.Red, Square.Red, Square.Red,
                Square.Red, Square.Red, Square.Red))
            .AddLeft(new CubeFace3x3(
                Square.Blue, Square.Blue, Square.Blue,
                Square.Blue, Square.Blue, Square.Blue,
                Square.Blue, Square.Blue, Square.Blue))
            .AddRight(new CubeFace3x3(
                Square.Green, Square.Green, Square.Green,
                Square.Green, Square.Green, Square.Green,
                Square.Green, Square.Green, Square.Green))
            .AddBack(new CubeFace3x3(
                Square.Orange, Square.Orange, Square.Orange,
                Square.Orange, Square.Orange, Square.Orange,
                Square.Orange, Square.Orange, Square.Orange))
            .AddBottom(new CubeFace3x3(
                Square.Yellow, Square.Yellow, Square.Yellow,
                Square.Yellow, Square.Yellow, Square.Yellow,
                Square.Yellow, Square.Yellow, Square.Yellow));

            return cube;
    }
}
