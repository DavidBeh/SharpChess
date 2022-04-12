using SharpChess.Core.Move;

namespace SharpChess.Core;

public class ChessGame : IReadOnlyBoard<GameField>
{
    // Implement 2D Indexer. Access board fields, and their moves using <c>game[x, y]</c>
    //public GameField this[int x, int y] => _currentBoard[x, y];

    private Board<GameField> _currentBoard = null!;

    private Board<BoardField> _initialBoard = null!;

    /// Getter for initial board, returns IReadOnlyBoard
    public IReadOnlyBoard<BoardField> InitialBoard => _initialBoard;

    /// Getter for current board, returns IReadOnlyBoard.
    /// You can also use the indexer of ChessGame to access a specific field
    public IReadOnlyBoard<GameField> CurrentBoard => _currentBoard;
    
    private List<ReadyChessMove> _moveHistory = new();

    private IReadOnlyList<ReadyChessMove> MoveHistory => _moveHistory.AsReadOnly();

    public void AddMove(ReadyChessMove move)
    {
        throw new NotImplementedException();
    }

    public void UndoLastMove()
    {
        throw new NotImplementedException();
    }
    
    // TODO : Create constructor 
    
    
    public GameField this[int x, int y] => _currentBoard[x, y];

    public int Rows => _currentBoard.Rows;
    public int Columns => _currentBoard.Columns;
}