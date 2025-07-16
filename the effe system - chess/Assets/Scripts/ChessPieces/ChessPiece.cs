  using UnityEngine;

public enum ChessPieceType
{
    None = 0,
    Pawn = 1,
    Knight = 3,
    Bishop =4,
    Rook = 2,
    Queen =5,
    King = 6
}
public class ChessPiece : MonoBehaviour
{
    public int team;
    public int currentX;
    public int currentY;
    public ChessPieceType type;

    private Vector3 desiredPosition;
    private Vector3 desiredScale;
}
