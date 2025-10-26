// UBL string is a string that denotes the faces of a cube
// in a particular order. That order is: 
// U - Up 1 to 9
// R - Right 1 to 9
// F - Front 1 to 9
// D - Down (or underside) 1 to 9
// L - Left 1 to 9
// B - Back 1 to 9

// Each of the individual covered squares is know as a "facelet"
// Corner cubies have 3 facelets.
// Edge cubies have 2 facelets.
// Center cubies have 1 facelet.

namespace RubiksCube.Library.Constants;

public enum Facelet
{
    U1,
    U2,
    U3,
    U4,
    U5,
    U6,
    U7,
    U8,
    U9,
    R1,
    R2,
    R3,
    R4,
    R5,
    R6,
    R7,
    R8,
    R9,
    F1,
    F2,
    F3,
    F4,
    F5,
    F6,
    F7,
    F8,
    F9,
    D1,
    D2,
    D3,
    D4,
    D5,
    D6,
    D7,
    D8,
    D9,
    L1,
    L2,
    L3,
    L4,
    L5,
    L6,
    L7,
    L8,
    L9,
    B1,
    B2,
    B3,
    B4,
    B5,
    B6,
    B7,
    B8,
    B9
}
