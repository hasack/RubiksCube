
using RubiksCube.Library.Enums;
using RubiksCube.Library.Models;

namespace RubiksCubeSolver.Config
{
    internal static class FaceRotationConfigs
    {
        public static FaceRotationConfig TopClockWise = new()
        {
            FaceToRotate = Aspect.Top,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Front, Edge.Row, 1, false),
                new(Aspect.Right, Edge.Row, 1, false),
                new(Aspect.Back, Edge.Row, 1, false),
                new(Aspect.Left, Edge.Row, 1, false)
            ]
        };

        public static FaceRotationConfig TopAntiClockwise = new()
        {
            FaceToRotate = Aspect.Top,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Front, Edge.Row, 1, false),
                new(Aspect.Right, Edge.Row, 1, false),
                new(Aspect.Back, Edge.Row, 1, false),
                new(Aspect.Left, Edge.Row, 1, false)
            ]
        };

        public static FaceRotationConfig BottomClockwise = new()
        {
            FaceToRotate = Aspect.Bottom,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Front, Edge.Row, 3, false),
                new(Aspect.Right, Edge.Row, 3, false),
                new(Aspect.Back, Edge.Row, 3, false),
                new(Aspect.Left, Edge.Row, 3, false)
            ]
        };

        public static FaceRotationConfig BottomAntiClockwise = new()
        {
            FaceToRotate = Aspect.Bottom,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Front, Edge.Row, 3, false),
                new(Aspect.Right, Edge.Row, 3, false),
                new(Aspect.Back, Edge.Row, 3, false),
                new(Aspect.Left, Edge.Row, 3, false)
            ]
        };

        public static FaceRotationConfig LeftClockwise = new()
        {
            FaceToRotate = Aspect.Left,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Column, 1, false),
                new(Aspect.Front, Edge.Column, 1, false),
                new(Aspect.Bottom, Edge.Column, 1, false),
                new(Aspect.Back, Edge.Column, 3, true) // reversed because population of squares from top down
            ]
        };

        public static FaceRotationConfig LeftAnticlockwise = new()
        {
            FaceToRotate = Aspect.Left,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Column, 1, false),
                new(Aspect.Back, Edge.Column, 3, true),
                new(Aspect.Front, Edge.Column, 1, false),
                new(Aspect.Bottom, Edge.Column, 1, false),
            ]
        };

        public static FaceRotationConfig RightClockwise = new()
        {
            FaceToRotate = Aspect.Right,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Column, 3, false),
                new(Aspect.Front, Edge.Column, 3, false),
                new(Aspect.Bottom, Edge.Column, 3, false),
                new(Aspect.Back, Edge.Column, 1, true) 
            ]
        };

        public static FaceRotationConfig RightAntiClockwise = new()
        {
            FaceToRotate = Aspect.Right,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Column, 3, false),
                new(Aspect.Back, Edge.Column, 1, true),
                new(Aspect.Bottom, Edge.Column, 1, false),
                new(Aspect.Front, Edge.Column, 3, false)
            ]
        };

        public static FaceRotationConfig FrontClockwise = new()
        {
            FaceToRotate = Aspect.Front,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Row, 3, false),
                new(Aspect.Right, Edge.Column, 1, false),
                new(Aspect.Bottom, Edge.Row, 1, true),
                new(Aspect.Left, Edge.Column, 3, true)
            ]
        };

        public static FaceRotationConfig FrontAntiClockwise = new()
        {
            FaceToRotate = Aspect.Front,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Row, 3, false),
                new(Aspect.Left, Edge.Column, 3, true),
                new(Aspect.Bottom, Edge.Row, 1, true),
                new(Aspect.Right, Edge.Column, 1, false)
            ]
        };

        public static FaceRotationConfig BackClockwise = new()
        {
            FaceToRotate = Aspect.Back,
            Clockwise = true,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Row, 1, false),
                new(Aspect.Left, Edge.Column, 1, false),
                new(Aspect.Bottom, Edge.Row, 3, true),
                new(Aspect.Right, Edge.Column, 3, true)
            ]
        };

        public static FaceRotationConfig BackAntiClockwise = new()
        {
            FaceToRotate = Aspect.Back,
            Clockwise = false,
            AdjacentEdges =
            [
                new(Aspect.Top, Edge.Row, 1, false),
                new(Aspect.Right, Edge.Column, 3, true),
                new(Aspect.Bottom, Edge.Row, 3, true),
                new(Aspect.Left, Edge.Column, 1, false)
            ]
        };


    }
}
