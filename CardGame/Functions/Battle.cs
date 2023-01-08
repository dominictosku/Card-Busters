using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Functions
{
    public class Battle
    {
        public Battle(Player player, Player enemy)
        {
            Player = player;
            Enemy = enemy;
        }
        public Player Player { get; set; }
        public Player Enemy { get; set; }
        public void InterimResult()
        {
            Console.Write("PlayerCard ");
            Player.ActiveCard.ShowOutput();
            Console.Write("EnemyCard ");
            Enemy.ActiveCard.ShowOutput();
        }
        public void round()
        {

        }
    }
}
