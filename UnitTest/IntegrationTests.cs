using BGame;
using System;
using Xunit;

namespace UnitTest
{
    public class IntegrationTests
    {
        [Fact]
        public void TestGameWithThreePlayers()
        {
            var numberOfPlayers = 3;
            var cells = new char[] { 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'H', 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'H', 'J', 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'E', 'H', 'E' };
            var diceInput = new int[] { 4, 4, 4, 6, 7, 8, 5, 11, 10, 12, 2, 3, 5, 6, 7, 8, 5, 11, 10, 12, 2, 3, 5, 6, 7, 8, 5, 11, 10, 12 };

            var game = new Game(numberOfPlayers, cells);

            var finalScores = game.Play(diceInput);

            Assert.Equal(1200, finalScores[1]);
            Assert.Equal(1200, finalScores[2]);

        }

        [Fact]
        public void TestGameWithFourPlayers()
        {
            var numberOfPlayers = 4;
            var cells = new char[] { 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'H', 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'H', 'J', 'E', 'E', 'J', 'H', 'E', 'T', 'J', 'T', 'E', 'E', 'H', 'J', 'T', 'E', 'H', 'E' };
            var diceInput = new int[] { 4, 4, 4, 6, 7, 8, 5, 11, 10, 12, 2, 3};

            var game = new Game(numberOfPlayers, cells);

            var finalScores = game.Play(diceInput);

            Assert.Equal(1000, finalScores[1]);
            Assert.Equal(800, finalScores[2]);
            Assert.Equal(900, finalScores[3]);
            Assert.Equal(1250, finalScores[4]);

        }
    }
}
