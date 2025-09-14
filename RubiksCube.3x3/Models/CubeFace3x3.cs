using RubiksCube.Library.Enums;
using RubiksCube.Library.Interfaces;

namespace RubiksCube.Cube3x3.Models;

public class CubeFace3x3 : ICubeFace
{
    // A CubeFace as a 3x3 array of Squares
    public Square[,] Squares { get; set; } = new Square[3, 3];

    public CubeFace3x3()
    {

    }

    // Constructor to initialize a CubeFace with 9 Squares
    public CubeFace3x3(Square topLeft, Square topMiddle, Square topRight,
                    Square middleLeft, Square middleMiddle, Square middleRight,
                    Square bottomLeft, Square bottomMiddle, Square bottomRight)
    {

        // [row, column], zero-based indexing

        Squares[0, 0] = topLeft;
        Squares[0, 1] = topMiddle;
        Squares[0, 2] = topRight;
        Squares[1, 0] = middleLeft;
        Squares[1, 1] = middleMiddle;
        Squares[1, 2] = middleRight;
        Squares[2, 0] = bottomLeft;
        Squares[2, 1] = bottomMiddle;
        Squares[2, 2] = bottomRight;
    }

    public Square[] GetRow(int rowOneBasedIndex)
    {
        if (rowOneBasedIndex < 1 || rowOneBasedIndex > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(rowOneBasedIndex), "Row index must be between 1 and 3.");
        }

        int rowIndex = rowOneBasedIndex - 1; // Convert to zero-based index
        return [Squares[rowIndex, 0], Squares[rowIndex, 1], Squares[rowIndex, 2]];
    }

    public void SetRow(int rowOneBasedIndex, Square[] newRow)
    {
        if (rowOneBasedIndex < 1 || rowOneBasedIndex > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(rowOneBasedIndex), "Row index must be between 1 and 3.");
        }

        if (newRow.Length != 3)
        {
            throw new ArgumentException("New row must contain exactly 3 squares.", nameof(newRow));
        }

        int rowIndex = rowOneBasedIndex - 1; // Convert to zero-based index
        Squares[rowIndex, 0] = newRow[0];
        Squares[rowIndex, 1] = newRow[1];
        Squares[rowIndex, 2] = newRow[2];
    }

    public Square[] GetColumn(int columnOneBasedIndex)
    {
        if (columnOneBasedIndex < 1 || columnOneBasedIndex > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(columnOneBasedIndex), "Column index must be between 1 and 3.");
        }

        int columnIndex = columnOneBasedIndex - 1; // Convert to zero-based index
        return [Squares[0, columnIndex], Squares[1, columnIndex], Squares[2, columnIndex]];
    }

    public void SetColumn(int columnOneBasedIndex, Square[] newColumn)
    {
        if (columnOneBasedIndex < 1 || columnOneBasedIndex > 3)
        {
            throw new ArgumentOutOfRangeException(nameof(columnOneBasedIndex), "Column index must be between 1 and 3.");
        }

        if (newColumn.Length != 3)
        {
            throw new ArgumentException("New column must contain exactly 3 squares.", nameof(newColumn));
        }

        int columnIndex = columnOneBasedIndex - 1; // Convert to zero-based index
        Squares[0, columnIndex] = newColumn[0];
        Squares[1, columnIndex] = newColumn[1];
        Squares[2, columnIndex] = newColumn[2];
    }

    public void RotateClockwise()
    {
        // Rotate the face 90 degrees clockwise
        Square[,] newSquares = new Square[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                newSquares[j, 2 - i] = Squares[i, j];
            }
        }
        Squares = newSquares;
    }

    public void RotateAntiClockwise()
    {
        // Rotate the face 90 degrees anti-clockwise
        Square[,] newSquares = new Square[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                newSquares[2 - j, i] = Squares[i, j];
            }
        }
        Squares = newSquares;
    }
}
