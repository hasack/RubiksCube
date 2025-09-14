using System;
using RubiksCube.Library.Enums;

namespace RubiksCube.Library.Models;

    public class Move(Aspect face, MoveDirection direction)
{
    public Aspect Face { get; } = face;
    public MoveDirection Direction { get; } = direction;

    public override string ToString()
        {
            return Direction switch
            {
                MoveDirection.Clockwise => Face.ToString()[..1],
                MoveDirection.AntiClockwise => string.Concat(Face.ToString().AsSpan(0, 1), "'"),
                MoveDirection.Double => string.Concat(Face.ToString().AsSpan(0, 1), "2"),
                _ => Face.ToString()
            };
        }
    }