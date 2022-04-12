using System.Numerics;
using SharpChess.Core.Move;

namespace SharpChess.Core;

/// <summary>
/// Represents a field from a Chess<b>Board</b>.
/// For information about a Chess<b>Game</b>s Field see <see cref="GameField"/>
/// </summary>
public class BoardField
{
    public PieceType PieceType { get; init; }
    public Player Player { get; init; }
    
    /// Creates an empty board
    public static BoardField[,] CreateBoard(int rows = 8, int? cols = null)
    {
        cols ??= rows;
        return new BoardField[rows, cols.Value];
    }
}

/// <summary>
/// Represents a field from a Chess<b>Game</b>, not only a <b>Board</b>.
/// </summary>
public class GameField : BoardField
{
    public Vector<int> Position { get; init; }
    public IReadOnlyList<ChessMove> Moves => _moves.AsReadOnly();

    public readonly List<ChessMove> _moves = new();
    
    /// Creates an empty board
    public static GameField[,] CreateBoard(int rows = 8, int? cols = null)
    {
        cols ??= rows;
        return new GameField[rows, cols.Value];
    }
}

public static class ChessFieldExtensions
{
    // Extend BoardField[,] to return number of columns
    public static int X(this BoardField[,] board) => board.GetLength(0);
    
    public static int Y(this BoardField[,] board) => board.GetLength(1);
}