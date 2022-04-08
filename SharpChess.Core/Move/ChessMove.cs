namespace SharpChess.Core.Move;

/// <summary>
/// An Possible Move
/// </summary>
public abstract class ChessInput
{
    public ChessInput(Vec from, Vec to)
    {
        From = from;
        To = to;
    }

    public readonly Vec From;
    public readonly Vec To;

    public IReadOnlyList<ChessEffect> Effects => _effects.AsReadOnly();
    private List<ChessEffect> _effects = new();

}