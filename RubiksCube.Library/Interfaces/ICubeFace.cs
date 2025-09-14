using System;
using RubiksCube.Library.Enums;

namespace RubiksCube.Library.Interfaces;

public interface ICubeFace
{
    // The face is represented as a 2D array of Squares
    Square[,] Squares { get; set; }

    // Methods to get and set rows and columns
    Square[] GetRow(int rowOneBasedIndex);
    void SetRow(int rowOneBasedIndex, Square[] newRow);
    Square[] GetColumn(int columnOneBasedIndex);
    void SetColumn(int columnOneBasedIndex, Square[] newColumn);

    // Methods to rotate the face
    void RotateClockwise();
    void RotateAntiClockwise();
}