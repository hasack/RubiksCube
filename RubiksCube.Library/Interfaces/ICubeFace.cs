using System;
using RubiksCube.Library.Enums;

namespace RubiksCube.Library.Interfaces;

public interface ICubeFace
{
    Square[] GetRow(int rowOneBasedIndex);
    void SetRow(int rowOneBasedIndex, Square[] newRow);
    Square[] GetColumn(int columnOneBasedIndex);
    void SetColumn(int columnOneBasedIndex, Square[] newColumn);
}
