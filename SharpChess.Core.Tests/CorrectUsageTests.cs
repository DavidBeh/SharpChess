using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using SharpChess.Core.Move;

namespace SharpChess.Core.Tests;

public class CorrectUsageTests
{
    /*
    [SetUp]
    public void Setup()
    {
        
    }
    */

    // Used to ensure that Ready-interface is only used on ChessMove.
    // Is now obsolete as Ready-interface became a class and derives from ChessMove.
    /*
    [Test]
    public void ReadyInterface()
    {
        // Ready Interface
        var rI = typeof(ReadyChessMove);
        
        // All types from core that implement Ready interface (also makes sure to exclude interface itself)
        var impl = Assembly.GetAssembly(rI)!.GetTypes()
            .Where(type => typeof(ReadyChessMove).IsAssignableFrom(type) && type != rI);
        // Check if types in impl are not ChessMove
        var wrong = impl.Where(type => !typeof(ChessMove).IsAssignableFrom(type)).ToList();

        try
        {
            Assert.IsEmpty(wrong);
        }
        catch (AssertionException)
        {
            TestContext.Out.WriteLine("Wrong types in Ready interface: " + String.Join(", ", wrong));
            throw;
        }
    }
    */
}