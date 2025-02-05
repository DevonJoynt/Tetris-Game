using UnityEngine;
using UnityEngine.Tilemaps;
public enum Tetromino
{
    I,
    J,
    L,
    O,
    S,
    T,
    V,
    Z
}
[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells;

    public void Initialize()
    {

    }
}