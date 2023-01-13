using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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
        private void PlayerInput()
        {
            char action;
            string[] actions = new string[] {"Normal attack", "Elemental attack", "Role ability", "Show Status" };
            Console.WriteLine("Your turn: ");
            action = GenerateInput.PlayerInput(actions, "action");
            Turn(action, false);
        }
        /// <summary>
        /// Indicates enemy turn
        /// </summary>
        private void EnemyInput()
        {
            Console.WriteLine("Enemy turn");
            Turn('1', true);

        }
        /// <summary>
        /// Actions to be executed
        /// </summary>
        /// <param name="action">char indicating action, ranges from 1 to 4</param>
        /// <param name="actor">bool indicating actor, 0 for player, 1 for bot</param>
        private void Turn(char action, bool actor)
        {
            Cards ownCard;
            Cards opponentCard;
            string actorInfo;
            string attackInfo;
            // Checkss which actor is calling this function
            switch (actor)
            {
                case false:
                    actorInfo = "You";
                    attackInfo = "use:";
                    ownCard = Player.ActiveCard;
                    opponentCard = Enemy.ActiveCard;
                    break;
                case true:
                    actorInfo = "Opponent";
                    attackInfo = "uses";
                    ownCard = Enemy.ActiveCard;
                    opponentCard= Player.ActiveCard;
                    break;
                default:
                    throw new InvalidOperationException("I don't know how, but you completly broke the game. Bool can't be null");
            }
            // Selection of commands
            switch (action)
            {
                case '1':
                    Console.WriteLine("{0} {1} normal attack", actorInfo, attackInfo);
                    ownCard.AttackEnemy(opponentCard);
                    break;
                case '2':
                    Console.WriteLine("{0} {1} elemental attck", actorInfo, attackInfo);
                    ownCard.ElementalAttack(opponentCard);
                    break;
                case '3':
                    Console.WriteLine("{0} {1} special ability", actorInfo, attackInfo);
                    ownCard.Role.SpecialAbility(ownCard, opponentCard);
                    break;
                case '4':
                    Console.WriteLine("Showing stats");
                    InterimResult();
                    PlayerInput();
                    break;
                default:
                    Console.WriteLine("Unexpected input, try again");
                    PlayerInput();
                    break;
            }
        }
        /// <summary>
        /// Main function of battle
        /// Controls the fight
        /// </summary>
        public void Round()
        {
            byte counter = 0;
            Console.WriteLine(PlayerInitiate.Line);
            Console.WriteLine("The battle begins");
            // Round continues until one card is destroyed
            while (Player.ActiveCard.Health > 0 && Enemy.ActiveCard.Health > 0)
            {
                PlayerInput();
                Console.WriteLine(PlayerInitiate.Line);
                EnemyInput();
                counter++;
                // Prompt to exit the game if it takes to long
                if (counter % 10 == 0){
                    Console.WriteLine(PlayerInitiate.Line);
                    Console.WriteLine("Do you want to exit?");
                    Console.WriteLine("Press y, else any other key");
                    char userContinue = Console.ReadKey(true).KeyChar;
                    if (userContinue == 'y')
                        break;
                }
            }
            //Todo! Text who won
            Console.WriteLine(PlayerInitiate.Line);
            Console.WriteLine("round over");
        }
    }
}
