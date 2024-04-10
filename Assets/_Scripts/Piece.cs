using System;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Board board { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3Int[] cells { get; private set; }
    public Vector3Int position { get; private set; }

    public void Initalize(Board board, Vector3Int position, TetrominoData data)
    {
        this.board = board;
        this.position = position;
        this.data = data;

        if (this.cells == null)
        {
            this.cells = new Vector3Int[data.cells.Length];
        }

        for (int i = 0; i < this.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i];
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector2Int.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector2Int.right);
        }
    }

    private void Move(Vector2Int translation)
    {
        Vector3Int newPosition = this.position;
        newPosition.Set(newPosition.x + translation.x, newPosition.y + translation.y, 0);
    }
}