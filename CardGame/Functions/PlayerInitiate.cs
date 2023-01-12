using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CardGame.Functions
{
    public static class PlayerInitiate
    {
        public const string Line = "----------------------";
        /// <summary>
        /// Creates a new Player
        /// </summary>
        /// <returns>Player name</returns>
        public static string CreateCharacter()
        {
            string playerName;
            string pattern = "^[a-zA-Z0-9]+$";
            bool invalid = false;
            Regex regex = new Regex(pattern);
            Console.WriteLine("Welcome to Card Busters!");
            do
            {
                if (invalid)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Username, please try again");
                }
                Console.Write("Please Enter your Name: ");
                playerName = Console.ReadLine();
                invalid = true;
            } while (!regex.IsMatch(playerName));
            Console.WriteLine(Line);
            return playerName;
        }
        /// <summary>
        /// Creates a card from player input
        /// </summary>
        /// <returns> List with choosen Card and 3 random cards</returns>
        public static List<Cards> SelectCards() {
            List<Cards> deck;
            Cards selectedCard;
            char element, role;
            string[] selection = new string[4] { "Pyro", "Hydro", "Anemo", "Geo" }, 
                     selection2 = new string[4] { "Attacker", "Healer", "Support", "Tank" };
            string textoutput = "element";
            string textoutput2 = "role";
            Console.WriteLine("Please choose 1 card you wish to have in your Deck");
            Console.WriteLine(Line);
            element = GenerateInput.PlayerInput(selection, textoutput);
            role = GenerateInput.PlayerInput(selection2, textoutput2);
            selectedCard = GenerateCard.CreateCard(element,role);
            Console.WriteLine("Generating 3 random extra Cards");
            Thread.Sleep(3000);
            deck = CreateDeck.GenerateRandomDeck(3);
            deck.Add(selectedCard);
            return deck;
        }
    }
}
