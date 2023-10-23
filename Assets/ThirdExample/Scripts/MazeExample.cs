using System;
using UnityEngine;

public class MazeExample : MonoBehaviour
{
    [SerializeField] private CellType _cellType;
    [SerializeField] private MazeFormType _mazeForm;
    [SerializeField, Range(0, 100)] private int _numberOfCells;

    [SerializeField] private Maze _maze;

    [ContextMenu("BuildMaze")]
    public void BuildMaze()
    {
        MazeFormFactory factory;

        switch (_cellType)
        {
            case CellType.Square:
                factory = new SquareMazeFormFactory();
                break;

            case CellType.Hex:
                factory = new HexMazeFormFactory();
                break;

            default:
                throw new InvalidOperationException();
        }

        _maze.Build(factory.Get(_mazeForm), _numberOfCells);
    }
}
