namespace SharpChess.Core.Move;

// ReSharper disable once InconsistentNaming
/// <summary>
/// ChessMoves that do not need any more information from the user,
/// other than the start and end position of the move, need to derive from this
///
/// ChessMoves that require additional information (promotion) will first need to
/// be converted using a conversion method
/// </summary>
public class ReadyChessMove : ChessMove
{
    public ReadyChessMove(Vec @from, Vec to) : base(@from, to)
    {
    }
}

