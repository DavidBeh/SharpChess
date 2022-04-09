using SharpChess.Core.Move;

namespace SharpChess.Core;

public interface IReadOnlyBoard<T> where T : BoardField
{
    
    
    // Indexer returns T 2d array
    T this[int x, int y] { get; }

    public int Rows { get; }
    public int Columns { get; }

    public Board<T> Clone()
    {
        var board = new Board<T>(Rows, Columns);
        for (int x = 0; x < Rows; x++)
        {
            for (int y = 0; y < Columns; y++)
            {
                board[x, y] = this[x, y];
            }
        }
        return board;
    }
}

public sealed class Board<T> : IReadOnlyBoard<T> where T : BoardField
{
    public static Board<BoardField> CreateDefault()
    {
        // TODO Fill board with pieces
        return new Board<BoardField>(8,8);
    }

    // Constructor takes size
    public Board(int rows = 8, int? columns = null)
    {
        columns ??= rows;
        _board = new T[rows, columns.Value];
    }
    
    private readonly T[,] _board;

    public T this[int x, int y]
    {
        get => _board[x, y];
        set => _board[x, y] = value;
    }

    /// Max X
    public int Columns => _board.GetLength(0);

    /// Max Y
    public int Rows => _board.GetLength(1);
}


// There would be two ways to return a Board as readonly:
// 1. Create a new class that implements IReadOnlyBoard<T> wraps a Board<T>
// 2. Cast the Board<T> to IReadOnlyBoard<T>
//    However the consumer could cast it back to Board<T> and modify it.
//
// The consumer could always use reflection to modify the board.
// Draft:
/*
internal class ReadOnlyBoardWrapper<T> : IReadOnlyBoard<T> where T : BoardField
{
    private readonly IReadOnlyBoard<T> _board;

    public ReadOnlyBoardWrapper(IReadOnlyBoard<T> board)
    {
        _board = board;
    }

    public T this[int x, int y] => _board[x, y];
}*/