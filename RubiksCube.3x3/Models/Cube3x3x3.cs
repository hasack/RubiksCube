using System;
using RubiksCube.Library.Enums;
using RubiksCube.Library.Models;

namespace RubiksCube.Cube3x3.Models;

public class Cube3x3x3
{

    public Dictionary<Aspect, CubeFace3x3> Faces { get; set; } = new()
        {
            { Aspect.Top, new CubeFace3x3() },
            { Aspect.Front, new CubeFace3x3() },
            { Aspect.Back, new CubeFace3x3() },
            { Aspect.Left, new CubeFace3x3() },
            { Aspect.Right, new CubeFace3x3() },
            { Aspect.Bottom, new CubeFace3x3() }
        };

    public Cube3x3x3 AddTop(CubeFace3x3 face)
    {
        Faces[Aspect.Top] = face;
        return this;
    }
    public Cube3x3x3 AddFront(CubeFace3x3 face)
    {
        Faces[Aspect.Front] = face;
        return this;
    }
    public Cube3x3x3 AddLeft(CubeFace3x3 face)
    {
        Faces[Aspect.Left] = face;
        return this;
    }
    public Cube3x3x3 AddRight(CubeFace3x3 face)
    {
        Faces[Aspect.Right] = face;
        return this;
    }
    public Cube3x3x3 AddBack(CubeFace3x3 face)
    {
        Faces[Aspect.Back] = face;
        return this;
    }
    public Cube3x3x3 AddBottom(CubeFace3x3 face)
    {
        Faces[Aspect.Bottom] = face;
        return this;
    }

    public Cube3x3x3 RotateFace(FaceRotationConfig config)
    {
        if (config == null)
        {
            return this;
        }

        // 1. Rotate the face itself

        if (config.Clockwise)
            Faces[config.FaceToRotate].RotateClockwise();
        else
            Faces[config.FaceToRotate].RotateAntiClockwise();

        // 2. Cycle the edges of adjacent faces

        var edges = new List<Square[]>();

        foreach (AdjacentEdge edge in config.AdjacentEdges)
        {
            var e = edge.Edge == Edge.Row
            ? Faces[edge.Face].GetRow(edge.Index) 
            : Faces[edge.Face].GetColumn(edge.Index);

            if (edge.Reverse) Array.Reverse(e);
            edges.Add(e);
        }

        int n = edges.Count;
        for (int i = 0; i < n; i++)
        {
            int from = config.Clockwise ? (i + n - 1) % n : (i + 1) % n;
            var edgeToSet = (Square[])edges[from].Clone();
            var adjacentEdge = config.AdjacentEdges[i];
            if (adjacentEdge.Reverse == true) Array.Reverse(edgeToSet);
            if (adjacentEdge.Edge == Edge.Row)
                Faces[adjacentEdge.Face].SetRow(adjacentEdge.Index, edgeToSet);
            else
                Faces[adjacentEdge.Face].SetColumn(adjacentEdge.Index, edgeToSet);
        }

        return this;
    }

}