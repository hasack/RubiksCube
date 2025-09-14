using System;
using RubiksCube.Library.Enums;

namespace RubiksCube.Library.Interfaces;

public interface ICube
{
    // Modelling a Cube as a Dictionary<Aspect, CubeFaces>
    Dictionary<Aspects, ICubeFace> Faces { get; set; }

    // Methods for Setting Up Cube
    ICube AddTop(ICubeFace face);
    ICube AddLeft(ICubeFace face);
    ICube AddFront(ICubeFace face);
    ICube AddRight(ICubeFace face);
    ICube AddBottom(ICubeFace face);
    ICube AddBack(ICubeFace face);

}
