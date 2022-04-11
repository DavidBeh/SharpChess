namespace SharpChess.Server.Models;




public record FieldData(Vec pos ,bool isBlack, PieceIdData pieceId);


public enum PieceIdData {
    Pawn,
    Tower,
    Horse,
    Bishop,
    Queen,
    King
}