using SharpChess.Server.Controllers;

namespace SharpChess.Server.Models;

public record Move(
        Movement Movement,
        Vec? Kill, PieceIdData? Promote, // Potential Kill / Promotion
        Vec? SecFrom, Vec? SecTo); // Potential Secondary Movement (Castling)
