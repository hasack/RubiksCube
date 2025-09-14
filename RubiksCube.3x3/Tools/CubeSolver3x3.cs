using System;
using RubiksCube.Library.Interfaces;
using RubiksCube.Library.Models;

namespace RubiksCube.Cube3x3.Tools;

public class CubeSolver3x3 : ICubeSolver
{
    public List<Move> Solve(ICube cube)
    {
        throw new NotImplementedException();
    }

    public Task<List<Move>> SolveAsync(ICube cube)
    {
        throw new NotImplementedException();
    }
}
