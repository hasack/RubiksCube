using System;
using RubiksCube.Library.Models;

namespace RubiksCube.Library.Interfaces;

public interface ICubeSolver
{
    // Method for Solving Cube
    List<Move> Solve(ICube cube);
    Task<List<Move>> SolveAsync(ICube cube);
}
