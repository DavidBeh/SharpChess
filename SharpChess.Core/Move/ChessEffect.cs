namespace SharpChess.Core.Input;

public class ChessEvent
{
    public class Death : ChessEvent
    {
        public readonly Vec Pos;

        public Death(Vec pos)
        {
            Pos = pos;
        }
    }

    public class Move : ChessEvent
    {
        public readonly Vec From;
        public readonly Vec To;

        public Move(Vec @from, Vec to)
        {
            From = @from;
            To = to;
        }
    }

    public class Promotion : ChessEvent
    {
        public readonly Vec Pos;
        public readonly ChessPieceId NewPiece;

        public Promotion(Vec pos, ChessPieceId newPiece)
        {
            Pos = pos;
            NewPiece = newPiece;
        }
    }
}