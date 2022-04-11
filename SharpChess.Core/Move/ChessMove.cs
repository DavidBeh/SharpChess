namespace SharpChess.Core.Move;

/// <summary>
/// An Possible Move
/// </summary>
public abstract class ChessMove
{
    public ChessMove(Vec from, Vec to)
    {
        From = from;
        To = to;
    }

    public readonly Vec From;
    public readonly Vec To;

    public IReadOnlyList<ChessEffect> Effects => _effects.AsReadOnly();
    internal List<ChessEffect> _effects = new();
    
    
    
}

