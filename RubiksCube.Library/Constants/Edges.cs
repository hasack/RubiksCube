// Edges are the pieces with two colours that sit between the corners on each face

namespace RubiksCube.Library.Constants;

public enum Edge
{
    UR, // [Cube that sits on join between] Upper and Right
    UF, // Upper and Front
    UL, // Upper and Left
    UB, // Upper and Back
    DR, // Down and Right
    DF, // Down and Front
    DL, // Down and Left
    DB, // Down and Back
    FR, // Front and Right
    FL, // Front and Left
    BL, // Back and Left
    BR  // Back and Right
}