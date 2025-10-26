using RubiksCube.Library.Constants;
using RubiksCube.Library.Definitions;

namespace RubiksCube.Library.CubeModels
{
    internal class CubieCube
    {
        // Corners
        public Corner[] CornerPermutation { get; set; } = new Corner[8]; // This indicates which cubie is at each of the 8 corner positions (URF => DRB)
        public int[] CornerOrientation { get; set; } = new int[8]; // This indicates the orientation of each corner cubie (0, 1, or 2)

        // Edges
        public Edge[] EdgePermuation { get; set; } = new Edge[12]; // This indicates which cubie is at each of the 12 edge positions (UR => DB)
        public int[] EdgeOrientation { get; set; } = new int[12]; // This indicates the orientation of each edge cubie (0 or 1)

        /// <summary>
        /// Instantiates a new instance of a CubieCube, either from given parameters or as a solved cube.
        /// </summary>
        /// <param name="cornerP">Corner Permutations</param>
        /// <param name="cornerO">Corner Orientations</param>
        /// <param name="edgeP">Edge Permutations</param>
        /// <param name="edgeO">Edge Orientations</param>
        public CubieCube(Corner[]? cornerP = null, int[]? cornerO = null, Edge[]? edgeP = null, int[]? edgeO = null)
        {
            CornerPermutation = cornerP ?? [.. Enumerable.Range(0, 8).Select(c => (Corner)c)];
            CornerOrientation = cornerO ?? new int[8];

            EdgePermuation = edgeP ?? [.. Enumerable.Range(0, 12).Select(e => (Edge)e)];
            EdgeOrientation = edgeO ?? new int[12];
        }

        /// <summary>
        /// Instantiates a new instance of a CubieCube as a clone of the provided CubieCube.
        /// </summary>
        /// <param name="cube"></param>
        public CubieCube(CubieCube cube)
        {
            CornerPermutation = (Corner[])cube.CornerPermutation.Clone();
            CornerOrientation = (int[])cube.CornerOrientation.Clone();
            EdgePermuation = (Edge[])cube.EdgePermuation.Clone();
            EdgeOrientation = (int[])cube.EdgeOrientation.Clone();
        }

        /// <summary>
        /// Gets a representation of a CubieCube as a string
        /// </summary>
        /// <returns>CubieCubie as a string</returns>
        public static string GetCubeString()
        {
            // TODO

            // from enums import Color, Corner as Co, Edge as Ed

            // cp is cornerPermutation
            // co is cornerOrientation

            // ep is edgePermutation
            // eo is edgeOrientation

            //def __str__(self):
            //"""Print string for a cubie cube."""
            //s = ''
            //for i in Co:
            //    s = s + '(' + str(self.cp[i]) + ',' + str(self.co[i]) + ')'
            //s += '\n'
            //for i in Ed:
            //    s = s + '(' + str(self.ep[i]) + ',' + str(self.eo[i]) + ')'
            //return s

            return "";
        }

        /// <summary>
        /// Determines whether the provided CubieCube is the same as this CubieCube.
        /// </summary>
        /// <param name="cube"></param>
        /// <returns></returns>
        public bool IsEqualToCube(CubieCube cube)
        {
            return CornerOrientation == cube.CornerOrientation &&
                   EdgeOrientation == cube.EdgeOrientation &&
                   CornerPermutation == cube.CornerPermutation &&
                   EdgePermuation == cube.EdgePermuation;
        }

        /// <summary>
        /// Creates a new CubieCube instance that is a deep copy of the current cube state.
        /// </summary>
        /// <remarks>The returned CubieCube is independent of the original; changes to the clone do not
        /// affect the original instance.</remarks>
        /// <returns>A new CubieCube object with the same corner and edge permutations and orientations as the current instance.</returns>
        public CubieCube Clone()
        {
            return new CubieCube(
               cornerP: (Corner[])CornerPermutation.Clone(),
               cornerO: (int[])CornerOrientation.Clone(),
               edgeP: (Edge[])EdgePermuation.Clone(),
               edgeO: (int[])EdgeOrientation.Clone()
           );
        }

        /// <summary>
        /// Returns the string representation of the cube in facelet notation.
        /// Reminder, facelet notation shows the colours of the stickers on each face of the cube.
        /// </summary>
        /// <returns>String representation of this cube in facelet notation</returns>
        public FaceCube ToFaceCube()
        {
            var faceCube = new FaceCube();

            //  There are 8 corners in a cube:

            //  URF => Upper, Right, Front (0)
            //  UFL => Upper, Front, Left (1)
            //  ULB => Upper, Left, Bottom (2)
            //  UBR => Upper, Bottom, Right (3)
            //  DFR => Down, Front, Right (4)
            //  DLF => Down, Left, Front (5)
            //  DBL => Down, Bottom, Left (6)
            //  DRB => Down, Right, Bottom (7)

            //  The CornerPermutation array indicates which corner is at each of these positions.

            //  NB. The index is the position, the value is the corner at that position.

            //  e.g. Therefore CornerPermutation[0] = URF means that the URF corner is at the URF position (solved state).
            //  e.g. Therefore CornerPermutation[0] = DLF means that the DLF corner is at the URF position (unsolved state).

            for (int cornerIndex = 0; cornerIndex < 8; cornerIndex++)
            {

                // Get the corner at each position, and its orientation
                Corner corner = CornerPermutation[cornerIndex];
                int cornerOrientation = CornerOrientation[cornerIndex];

                // Grab the three facelets locations for the corner position
                // i.e. What is URF's facelet ids (U9, R1, F3)
                Facelet[] arrayFacelets = Facelets.cornerFacelets[cornerIndex];

                // Map the corner to its facelets and colors
                for (int cornerFace = 0; cornerFace < 3; cornerFace++)
                {
                    var faceIndexAdjustedForOrientation = (int)arrayFacelets[(cornerFace + cornerOrientation) % 3];

                    var colour = Facelets.cornerColours[(int)corner][cornerFace];

                    faceCube.Facelets[faceIndexAdjustedForOrientation] = colour;
                }
            }

            // There are 12 edges in a cube:

            //  UR => Upper, Right (0)  |   UF => Upper, Front (1)
            //  UL => Upper, Left (2)   |   UB => Upper, Back (3)
            //  DR => Down, Right (4)   |   DF => Down, Front (5)
            //  DL => Down, Left (6)    |   DB => Down, Back (7)
            //  FR => Front, Right (8)  |   FL => Front, Left (9)
            //  BL => Back, Left (10)   |   BR => Back, Right (11)

            //  The EdgePermutation array indicates which edge is at each of these positions.

            //  NB. The index is the position, the value is the edge at that position.

            //  e.g. Therefore EdgePermutation [0] = UR means that the UR edge is at the UR position (solved state).
            //  e.g. Therefore EdgePermutation [0] = DB means that the DB edge is at the UR position (unsolved state).

            for (int edgeIndex = 0; edgeIndex < 12; edgeIndex++)
            {
                // Get the edge at each position, and its orientation
                Edge edge = EdgePermuation[edgeIndex];
                int edgeOrientation = EdgeOrientation[edgeIndex];

                // Grb the two facelet locations for the edge position
                // i.e. What is UR's facelet ids (U6, R2)
                Facelet[] edgeFacelet = Facelets.edgeFacelets[edgeIndex];

                // Map the edge to its facelets and colors
                for (int edgeFace = 0; edgeFace < 2; edgeFace++)
                {
                    var faceIndexAdjustedForOrientation = (int)edgeFacelet[(edgeFace + edgeOrientation) % 2];

                    var colour = Facelets.edgeColours[(int)edge][edgeFace];

                    faceCube.Facelets[faceIndexAdjustedForOrientation] = colour;
                }
            }

            return faceCube;
        }
    }
}
