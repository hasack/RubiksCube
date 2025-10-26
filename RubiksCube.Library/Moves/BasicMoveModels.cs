using RubiksCube.Library.CubeModels;

namespace RubiksCube.Library.Moves
{

    internal class BasicMoveModels
    {
        // These are the basic move models for a Rubik's Cube.
        // They define the 6 basic face turns: U, D, L, R, F, B.
        // Put another way, they define the clockwise 90-degree
        // rotations of each face of the cube.

        //  The arrays determine what each of the corners and edges become after the move is applied.

        //  cp = corner permutation
        //  co = corner orientation
        //  ep = edge permutation
        //  eo = edge orientation

        //  Remember, the corners are labeled as below. And are in an enum so they have a numerical value (in brackets).

        //  URF => Upper, Right, Front (0)
        //  UFL => Upper, Front, Left (1)
        //  ULB => Upper, Left, Bottom (2)
        //  UBR => Upper, Bottom, Right (3)
        //  DFR => Down, Front, Right (4)
        //  DLF => Down, Left, Front (5)
        //  DBL => Down, Bottom, Left (6)
        //  DRB => Down, Right, Bottom (7)

        //  UP FACE CLOCKWISE TURN

        //  Explanation
        //  For example, for face clockwise turn, UBR goes to URF, URF goes to UFL, UFL goes to ULB, ULB goes to UBR.
        //  The other corners remain in the same position.

        public readonly Corner[] cpU = [Corner.UBR, Corner.URF, Corner.UFL, Corner.ULB, Corner.DFR, Corner.DLF, Corner.DBL, Corner.DRB];
        public readonly int[] coU = [0, 0, 0, 0, 0, 0, 0, 0];

        public readonly Edge[] epU = [Edge.UB, Edge.UR, Edge.UF, Edge.UL, Edge.DR, Edge.DF, Edge.DL, Edge.DB, Edge.FR, Edge.FL, Edge.BL, Edge.BR];
        public readonly int[] eoU = [0, 0, 0, 0, 0, 0, 0, 0];

        //  RIGHT FACE CLOCKWISE TURN

        public readonly Corner[] cpR = [Corner.DFR, Corner.UFL, Corner.ULB, Corner.URF, Corner.DRB, Corner.DLF, Corner.DBL, Corner.UBR];
        public readonly int[] coR = [2, 0, 0, 1, 1, 0, 0, 2];

        public readonly Edge[] epR = [Edge.FR, Edge.UF, Edge.UL, Edge.UB, Edge.BR, Edge.DF, Edge.DL, Edge.DB, Edge.DR, Edge.FL, Edge.BL, Edge.UR];
        public readonly int[] eoR = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        // FRONT FACE CLOCKWISE TURN

        public readonly Corner[] cpF = [Corner.UFL, Corner.DLF, Corner.ULB, Corner.UBR, Corner.URF, Corner.DFR, Corner.DBL, Corner.DRB];
        public readonly int[] coF = [1, 2, 0, 0, 2, 1, 0, 0];

        public readonly Edge[] epF = [Edge.UR, Edge.FL, Edge.UL, Edge.UB, Edge.DR, Edge.FR, Edge.DL, Edge.DB, Edge.UF, Edge.DF, Edge.BL, Edge.BR];
        public readonly int[] eoF = [0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0];

        // DOWN FACE CLOCKWISE TURN

        public readonly Corner[] cpD = [Corner.URF, Corner.UFL, Corner.ULB, Corner.UBR, Corner.DLF, Corner.DBL, Corner.DRB, Corner.DFR];
        public readonly int[] coD = [0, 0, 0, 0, 0, 0, 0, 0];

        public readonly Edge[] epD = [Edge.UR, Edge.UF, Edge.UL, Edge.UB, Edge.DF, Edge.DL, Edge.DB, Edge.DR, Edge.FR, Edge.FL, Edge.BL, Edge.BR];
        public readonly int[] eoD = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        // LEFT FACE CLOCKWISE TURN

        public readonly Corner[] cpL = [Corner.URF, Corner.ULB, Corner.DBL, Corner.UBR, Corner.DFR, Corner.UFL, Corner.DLF, Corner.DRB];
        public readonly int[] coL = [0, 1, 2, 0, 0, 2, 1, 0];

        public readonly Edge[] epL = [Edge.UR, Edge.UF, Edge.BL, Edge.UB, Edge.DR, Edge.DF, Edge.FL, Edge.DB, Edge.FR, Edge.UL, Edge.DL, Edge.BR];
        public readonly int[] eoL = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        // BACK FACE CLOCKWISE TURN

        public readonly Corner[] cpB = [Corner.URF, Corner.UFL, Corner.UBR, Corner.DRB, Corner.DFR, Corner.DLF, Corner.ULB, Corner.DBL];
        public readonly int[] coB = [0, 0, 1, 2, 0, 0, 2, 1];

        public readonly Edge[] epB = [Edge.UR, Edge.UF, Edge.UL, Edge.BR, Edge.DR, Edge.DF, Edge.DL, Edge.BL, Edge.FR, Edge.FL, Edge.UB, Edge.DB];
        public readonly int[] eoB = [0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1];

    }
}
