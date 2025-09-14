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
        public Edge Edge { get; private set; } // Column or Row
        public int Index { get; private set; }  // 1-based index
        public bool Reverse { get; private set; } // true if the edge should be reversed when moved

        public AdjacentEdge(Aspect face, Edge edge, int index, bool reverse)
        {
            Face = face;
            Edge = edge;
            Index = index;
            Reverse = reverse;
        }
    }
}
