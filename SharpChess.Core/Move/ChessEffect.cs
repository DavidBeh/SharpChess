namespace SharpChess.Core.Move;

public class ChessEffect
{
    public class Death : ChessEffect
    {
        public readonly Vec Pos;

        public Death(Vec pos)
        {
            Pos = pos;
        }
    }

    public class Move : ChessEffect
    {
        public readonly Vec From;
        public readonly Vec To;

        public Move(Vec @from, Vec to)
        {
            From = @from;
            To = to;
        }
    }

    public class Promotion : ChessEffect
    {
        public readonly Vec Pos;
        public readonly PieceType NewPiece;

        public Promotion(Vec pos, PieceType newPiece)
        {
            Pos = pos;
            NewPiece = newPiece;
        }
    }
}