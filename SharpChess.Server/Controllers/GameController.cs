using System.Net;
using Microsoft.AspNetCore.Mvc;
using NJsonSchema.Annotations;
using NSwag.Annotations;
using SharpChess.Server.Models;

namespace SharpChess.Server.Controllers;

/// <summary>
/// My Controller
/// </summary>
[ApiController]
[OpenApiTag("Game", Description = "Game API")]
[Route("[controller]")]
public class GameController : ControllerBase
{
    /// <summary>
    /// Server Statistics
    /// </summary>
    /// <response code="200">Statistics</response>
    [HttpGet("Statistics")]
    [ProducesResponseType(typeof(Statistics), 200)]
    public ActionResult<Statistics> GetStatistics()
    {
        throw new NotImplementedException();
    }


    public record Statistics(
        int CurrentGames,
        int TotalGames,
        int ChatMessagesPerMinute
    );
    

    /// <summary>
    /// Add Move
    /// </summary>
    /// <param name="move"></param>
    /// <returns></returns>
    [HttpPost("{id}/Moves/")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddMove(Movement move, string id)
    {
        return Ok();
    }


    /// <summary>
    /// Get Board
    /// </summary>
    /// <param name="id">Id of the board</param>
    [HttpGet("{id}/Board")]
    [ProducesResponseType(typeof(BoardResponseData), 200)]
    public IActionResult GetBoard(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Revert last Move
    /// </summary>
    /// <param name="id">Id of the board</param>
    [HttpDelete("{id}/Moves")]
    [ProducesResponseType(typeof(BoardResponseData), 200)]
    public IActionResult UndoMove(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get Move history
    /// </summary>
    /// <param name="id">the id of the board</param>
    /// <response code="200">Returns Moves of the board</response>
    [ProducesResponseType(200)]
    [HttpGet("{id}/Moves")]
    public IActionResult GetBoard(string id)
    {
        throw new NotImplementedException();
    }

    
    /// <summary>
    /// Get possible moves
    /// </summary>
    /// <param name="id">the id of the board</param>
    /// <response code="200">Returns Moves of the board</response>
    [ProducesResponseType(200)]
    [HttpGet("{id}/PossibleMove")]
    public IActionResult GetPossibleMoves(string id)
    {
        throw new NotImplementedException();
    }

    class BoardResponseData
    {
        public string Board { get; set; }
        public string? ErrorMessage;
    }
}