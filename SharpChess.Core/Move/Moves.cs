using System.Collections.ObjectModel;

namespace SharpChess.Core.Move;

public class GenericMove : ReadyChessMove
{
    public GenericMove(Vec from, Vec to) : base(from, to)
    {
    }
}

public class PromotionMove : ChessMove
{
    public PromotionMove(Vec from, Vec to) : base(from, to)
    {
        
    }

    public ReadyChessMovePromotionMove ToReadyMove(PieceType newPiece)
    {
        return new ReadyChessMovePromotionMove(this, newPiece);
    }
}

public class ReadyChessMovePromotionMove : ReadyChessMove
{
    public ReadyChessMovePromotionMove(PromotionMove source, PieceType newPiece) : base(source.From, source.To)
    {
        NewPiece = newPiece;
        _effects.Add(new ChessEffect.Promotion(source.To, newPiece));
    }

    public readonly PieceType NewPiece;
}