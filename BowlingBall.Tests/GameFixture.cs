using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        Game game;
        public GameFixture()
        {
            game = new Game();
        }


        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }


        [TestMethod]
        public void Strike()
        {
            game.Roll(10);
            game.Roll(4);
            game.Roll(4);
            Roll(game,17, 0);
            Assert.AreEqual(26, game.GetScore());
        }

        [TestMethod]
        public void Fullscore()
        {
            Roll(game,10, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }


        
    }
}
