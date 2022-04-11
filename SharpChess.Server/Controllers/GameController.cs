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
    /// Get Current Board
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}/Board")]
    [ProducesResponseType(typeof(IEnumerable<FieldData>),StatusCodes.Status200OK)]
    public IActionResult GetBoard(string id)
    {
        return Ok();
    }

    [HttpPost("{id}/Board/Move")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddMove(Movement move)
    {
        return Ok();
    }




    /// <summary>
    /// Add move to board
    /// </summary>
    /// <param name="id">the id of the board</param>
    /// <response code="200">Move added</response>
    [ProducesResponseType(200)]
    [HttpPost("Board/{id}")]
    public IActionResult GetBoard(string id, Vec vec)
    {
        throw new NotImplementedException();
    }


    class BoardResponseData
    {
        public string Board { get; set; }
        public string? ErrorMessage;
    }
}