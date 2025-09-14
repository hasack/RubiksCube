using RubiksCube.Library.Enums;
using RubiksCube.Library.Interfaces;

namespace RubiksCube.Library.Tools
{
    public class CubeBuilder
    {
    private readonly Dictionary<Aspect, ICubeFace> _faces = new();

        // Static entry points for fluent building (with custom face)
        public static CubeBuilder StartWithTop(ICubeFace face) => new CubeBuilder().SetTop(face);
        public static CubeBuilder StartWithFront(ICubeFace face) => new CubeBuilder().SetFront(face);
        public static CubeBuilder StartWithBack(ICubeFace face) => new CubeBuilder().SetBack(face);
        public static CubeBuilder StartWithLeft(ICubeFace face) => new CubeBuilder().SetLeft(face);
        public static CubeBuilder StartWithRight(ICubeFace face) => new CubeBuilder().SetRight(face);
        public static CubeBuilder StartWithBottom(ICubeFace face) => new CubeBuilder().SetBottom(face);

        // Instance methods for chaining
        public CubeBuilder SetTop(ICubeFace face)
        {
            _faces[Aspect.Top] = face;
            return this;
        }
        public CubeBuilder SetFront(ICubeFace face)
        {
            _faces[Aspect.Front] = face;
            return this;
        }
        public CubeBuilder SetBack(ICubeFace face)
        {
            _faces[Aspect.Back] = face;
            return this;
        }
        public CubeBuilder SetLeft(ICubeFace face)
        {
            _faces[Aspect.Left] = face;
            return this;
        }
        public CubeBuilder SetRight(ICubeFace face)
        {
            _faces[Aspect.Right] = face;
            return this;
        }
        public CubeBuilder SetBottom(ICubeFace face)
        {
            _faces[Aspect.Bottom] = face;
            return this;
        }

        public CubeBuilder ClearFace(Aspect aspect)
        {
            _faces.Remove(aspect);
            return this;
        }

        public List<string> Validate()
        {
            var errors = new List<string>();
            var requiredAspects = new[] { Aspect.Top, Aspect.Front, Aspect.Back, Aspect.Left, Aspect.Right, Aspect.Bottom };
            foreach (var aspect in requiredAspects)
            {
                if (!_faces.ContainsKey(aspect))
                {
                    errors.Add($"Missing face: {aspect}");
                }
            }
            return errors;
        }

        public ICube Build(ICube emptyCube)
        {

            var errors = Validate();
            if (errors.Count > 0)
            {
                throw new InvalidOperationException($"Cannot build cube. Errors: {string.Join(", ", errors)}");
            }

            var cube = emptyCube;
            if (_faces.TryGetValue(Aspect.Top, out var top)) cube = cube.AddTop(top);
            if (_faces.TryGetValue(Aspect.Front, out var front)) cube = cube.AddFront(front);
            if (_faces.TryGetValue(Aspect.Back, out var back)) cube = cube.AddBack(back);
            if (_faces.TryGetValue(Aspect.Left, out var left)) cube = cube.AddLeft(left);
            if (_faces.TryGetValue(Aspect.Right, out var right)) cube = cube.AddRight(right);
            if (_faces.TryGetValue(Aspect.Bottom, out var bottom)) cube = cube.AddBottom(bottom);
            return cube;
        }
    }
}