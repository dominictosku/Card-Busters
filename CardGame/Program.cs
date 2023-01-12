using CardGame.ElementCards;
using CardGame.Functions;
using CardGame.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the two Players
            Player player = new Player();
            Player enemy = new Player();
            // Configure properties for Player
            player.Name = PlayerInitiate.CreateCharacter();
            player.Cards = PlayerInitiate.SelectCards();
            player.ActiveCard = player.Cards[0];
            // Configure properties for enemy
            enemy.Name = "Bot";
            enemy.Cards = CreateDeck.GenerateRandomDeck(4);
            enemy.ActiveCard = enemy.Cards[0];
            // Start the Game
            Battle battle = new Battle(player, enemy);
            battle.InterimResult();
            Console.WriteLine("---------------------------------------------");
            player.ActiveCard.AttackEnemy(enemy.ActiveCard);
            enemy.ActiveCard.AttackEnemy(player.ActiveCard);
            battle.InterimResult();
            Console.ReadKey();
        }
    }
}
