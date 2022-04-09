namespace SharpChess.Core;

public class ChessGame : IReadOnlyBoard<GameField>
{
    // Implement 2D Indexer. Access board fields, and their moves using <c>game[x, y]</c>
    //public GameField this[int x, int y] => _currentBoard[x, y];

    private Board<GameField> _currentBoard = null!;

    private Board<BoardField> _initialBoard = null!;

    // Getter for initial board, returns IReadOnlyBoard
    public IReadOnlyBoard<BoardField> InitialBoard => _initialBoard;

    /// Getter for current board, returns IReadOnlyBoard.
    /// You can also use the indexer of ChessGame to access a specific field
    public IReadOnlyBoard<GameField> CurrentBoard => _currentBoard;

    #region BoardAccessors

    /// <summary>
    /// Returns a copy of the initial board
    /// </summary>

    #endregion
    public GameField this[int x, int y] => _currentBoard[x, y];

    public int Rows => _currentBoard.Rows;
    public int Columns => _currentBoard.Columns;
    
    
}