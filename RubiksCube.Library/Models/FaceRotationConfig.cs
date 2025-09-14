using RubiksCube.Library.Enums;

namespace RubiksCube.Library.Models
{
    public class FaceRotationConfig
    {
        public Aspect FaceToRotate { get; set; }
        public bool Clockwise { get; set; }
        public List<AdjacentEdge> AdjacentEdges { get; set; } = [];
    }

    public class AdjacentEdge
    {
        public Aspect Face { get; private set; }
        public bool IsRow { get; private set; } // true for row, false for column
        public int Index { get; private set; }  // 1-based index
        public bool Reverse { get; private set; } // true if the edge should be reversed when moved

        public AdjacentEdge(Aspect face, bool isRow, int index, bool reverse)
        {
            Face = face;
            IsRow = isRow;
            Index = index;
            Reverse = reverse;
        }
    }
}
