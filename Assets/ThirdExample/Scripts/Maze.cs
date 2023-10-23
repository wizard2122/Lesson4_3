using UnityEngine;

public class Maze : MonoBehaviour
{
    private void Initialize(MazeFormFactory factory)
    {

    }

    public void Build(MazeGridForm gridForm, int numberOfCells)
    {
        gridForm.GenerateGridCoordinates(numberOfCells);
    }
}
