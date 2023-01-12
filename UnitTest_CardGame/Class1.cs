using CardGame;
using CardGame.ElementCards;
using CardGame.Functions;
using CardGame.Roles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_CardGame
{
    [TestFixture]
    public class TestGenerateRandomDeck
    {
        [Test]
        public void TestDoBattle()
        {
            //arrange
            Player player = new Player();
            Player enemy = new Player();
            player.Name = "Bot";
            player.Cards = new List<Cards> { new PyroCard(new Attacker()) };
            player.ActiveCard = player.Cards[0];
            enemy.Name = "Bot2";
            enemy.Cards = new List<Cards> { new PyroCard(new Attacker()) };
            enemy.ActiveCard = enemy.Cards[0];
            //act
            player.ActiveCard.AttackEnemy(enemy.ActiveCard);
            enemy.ActiveCard.AttackEnemy(player.ActiveCard);
            int result = player.ActiveCard.Health;
            //assert
            Assert.AreEqual(700, result);
        }
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(25, ExpectedResult = 25)]
        public int TestGetGenerateRandomDeck(byte times)
        {
            //arrange
            List<Cards> deck;
            //act
            deck = CreateDeck.GenerateRandomDeck(times);
            int result = deck.Count();
            //assert
            return result;
        }
    }
}
