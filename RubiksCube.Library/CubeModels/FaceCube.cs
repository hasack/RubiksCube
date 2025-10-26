using RubiksCube.Library.Constants;

namespace RubiksCube.Library.CubeModels
{
    public class FaceCube
    {
        public Colour[] Facelets { get; }

        public FaceCube(Colour[]? facelets = null)
        {
            if (facelets is not null)
            {
                Facelets = facelets;
            }
            else
            {
                Facelets = new Colour[54];

                for (int i = 0; i < 9; i++) Facelets[i] = Colour.U;
                for (int i = 9; i < 18; i++) Facelets[i] = Colour.R;
                for (int i = 18; i < 27; i++) Facelets[i] = Colour.F;
                for (int i = 27; i < 36; i++) Facelets[i] = Colour.D;
                for (int i = 36; i < 45; i++) Facelets[i] = Colour.L;
                for (int i = 45; i < 54; i++) Facelets[i] = Colour.B;
            }
        }
    }
}
