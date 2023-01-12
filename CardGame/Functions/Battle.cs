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
        /// <summary>
        /// Short output of current stats
        /// </summary>
        public void InterimResult()
        {
            Console.Write("PlayerCard ");
            Player.ActiveCard.ShowOutput();
            Console.Write("EnemyCard ");
            Enemy.ActiveCard.ShowOutput();
        }
        /// <summary>
        /// Indicates player turn
        /// </summary>
        public void playerInput()
        {
            char action;
            string[] actions = new string[] {"Normal attack", "Elemental attack", "Role ability", "Show Status" };
            Console.WriteLine("Your turn: ");
            action = GenerateInput.PlayerInput(actions, "action");
            turn(action);
        }
        /// <summary>
        /// Indicates enemy turn
        /// </summary>
        public void enemyInput()
        {
            Enemy.ActiveCard.AttackEnemy(Player.ActiveCard);
            // Todo! switch function to be operational for enemy and player
            //turn('1');

        }
        /// <summary>
        /// Actions to be executed
        /// </summary>
        /// <param name="action">char indicating action, ranges from 1 to 4</param>
        public void turn(char action)
        {
            Cards playerActive = Player.ActiveCard;
            Cards enemyActive = Enemy.ActiveCard;
            switch (action)
            {
                case '1':
                    Console.WriteLine("You use a normal attck");
                    playerActive.AttackEnemy(enemyActive);
                    break;
                case '2':
                    Console.WriteLine("You use an elemental attck");
                    playerActive.ElementalAttack(enemyActive);
                    break;
                case '3':
                    Console.WriteLine("You use your special ability");
                    playerActive.Role.SpecialAbility(playerActive, enemyActive);
                    break;
                case '4':
                    Console.WriteLine("Showing stats");
                    InterimResult();
                    playerInput();
                    break;
                default:
                    Console.WriteLine("Unexpected input, try again");
                    playerInput();
                    break;
            }
        }
        /// <summary>
        /// main function of battle
        /// </summary>
        public void round()
        {
            Console.WriteLine("The battle begins");
            playerInput();
            Console.WriteLine("Enemy turn");
            enemyInput();
        }
    }
}
