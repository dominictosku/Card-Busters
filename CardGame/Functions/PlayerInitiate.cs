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
        private const string Line = "----------------------";
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
        public static List<Cards> SelectCards() {
            List<Cards> deck;
            Cards selectedCard;
            bool invalid = false;
            char element;
            char role;
            char[] validInput = new char[4] {'1','2','3','4'};
            Console.WriteLine("Please choose 1 card you wish to have in your Deck");
            Console.WriteLine(Line);
            do {
                if (invalid)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid element, please type a number shown left");
                }
                Console.WriteLine("Select element");
                Console.WriteLine("1: Pyro");
                Console.WriteLine("2: Hydro");
                Console.WriteLine("3: Anemo");
                Console.WriteLine("4: Geo");
                element = Console.ReadKey().KeyChar;
                invalid = true;
            } while (!validInput.Any(x => x.Equals(element)));
            invalid = false;
            do
            {
                if (invalid)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid role, please type a number shown left");
                }
                Console.WriteLine("Select role");
                Console.WriteLine("1: Attacker");
                Console.WriteLine("2: Healer");
                Console.WriteLine("3: Support");
                Console.WriteLine("4: Tank");
                role = Console.ReadKey().KeyChar;
                invalid = true;
            } while (!validInput.Any(x => x.Equals(role)));
            selectedCard = GenerateCard.CreateCard(element,role);
            Console.WriteLine("Generating 3 random extra Cards");
            Thread.Sleep(3000);
            deck = CreateDeck.GenerateRandomDeck(3);
            deck.Add(selectedCard);
            return deck;
        }
    }
}
