using RubiksCube.Library.CubeModels;

namespace RubiksCube.Library.ExtensionMethods
{
    internal static class FaceCubeExtensions
    {
        public static string ToString(this FaceCube faceCube)
        {
            string faceletString = "";

            foreach (var colour in faceCube.Facelets)
            {
                faceletString += colour.ToString();
            }

            return faceletString;
        }
    }
}
