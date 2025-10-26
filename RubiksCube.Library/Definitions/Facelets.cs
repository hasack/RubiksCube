using RubiksCube.Library.Constants;

namespace RubiksCube.Library.Definitions;

public static class Facelets
{
    public static readonly Facelet[][] cornerFacelets =
    [
        [Facelet.U9, Facelet.R1, Facelet.F3],   // URF
        [Facelet.U7, Facelet.F1, Facelet.L3],   // UFL
        [Facelet.U1, Facelet.L1, Facelet.B3],   // ULB
        [Facelet.U3, Facelet.B1, Facelet.R3],   // UBR
        [Facelet.D3, Facelet.F9, Facelet.R7],   // DFR
        [Facelet.D1, Facelet.L9, Facelet.F7],   // DLF
        [Facelet.D7, Facelet.B9, Facelet.L7],   // DBL
        [Facelet.D9, Facelet.R9, Facelet.B7]    // DRB
    ];

    public static readonly Facelet[][] edgeFacelets =
    [
        [Facelet.U6, Facelet.R2],   // UR
        [Facelet.U8, Facelet.F2],   // UF
        [Facelet.U4, Facelet.L2],   // UL
        [Facelet.U2, Facelet.B2],   // UB
        [Facelet.D6, Facelet.R8],   // DR
        [Facelet.D2, Facelet.F8],   // DF
        [Facelet.D4, Facelet.L8],   // DL
        [Facelet.D8, Facelet.B8],   // DB
        [Facelet.F6, Facelet.R4],   // FR
        [Facelet.F4, Facelet.L6],   // FL
        [Facelet.B6, Facelet.L4],   // BL
        [Facelet.B4, Facelet.R6]    // BR
    ];

    public static readonly Colour[][] cornerColours =
    [
        [Colour.U, Colour.R, Colour.F], // URF
        [Colour.U, Colour.F, Colour.L], // UFL
        [Colour.U, Colour.L, Colour.B], // ULB
        [Colour.U, Colour.B, Colour.R], // UBR
        [Colour.D, Colour.F, Colour.R], // DFR
        [Colour.D, Colour.L, Colour.F], // DLF
        [Colour.D, Colour.B, Colour.L], // DBL
        [Colour.D, Colour.R, Colour.B]  // DRB

    ];

    public static readonly Colour[][] edgeColours =
    [
        [Colour.U, Colour.R],   // UR
        [Colour.U, Colour.F],   // UF
        [Colour.U, Colour.L],   // UL
        [Colour.U, Colour.B],   // UB
        [Colour.D, Colour.R],   // DR
        [Colour.D, Colour.F],   // DF
        [Colour.D, Colour.L],   // DL
        [Colour.D, Colour.B],   // DB
        [Colour.F, Colour.R],   // FR
        [Colour.F, Colour.L],   // FL
        [Colour.B, Colour.L],   // BL
        [Colour.B, Colour.R]    // BR
    ];
}